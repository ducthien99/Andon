using System;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Andon.Entity;
//using ActUtlTypeLib;
using System.Collections.Generic;
using Andon.Utils;
using System.Text;
using System.IO;
using System.Xml;
using System.Configuration;
using Andon.ControlApp;

namespace Andon.UI
{
    public partial class MAIN : Form
    {
        private MachineState[] _machineStates = new MachineState[25];

        public MAIN()
        {
            InitializeComponent();
            _machineStates = Data.machineStates();

            new Scheduler().Start();
            Control.SetInitial(this);
            AbrirFormulario<HomeSlide>();
            AppState.PageConnect = false;
            AppState.StatusConnect = false;
            AppState.FlagCleanScreen = true;
            AppState.Count = 0;
            ButtonHome.selected = true;
            panel2.Width = 200;
            Control.plc.SetDevice("M3", 0);
            Control.plc.SetDevice("M4", 0);
            Control.plc.SetDevice("M5", 0);
            Control.plc.SetDevice("M10", 0);
            Control.plc.SetDevice("M11", 1);
            Control.plc.SetDevice("M11", 0);
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void Panel1_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void AbrirFormulario<MiForm>() where MiForm : Form, new()
        {
            Form formulario;

            formulario = panelDesktop.Controls.OfType<MiForm>().FirstOrDefault();//Busca en la colecion el formulario
                                                                                 //si el formulario/instancia no existe
            
            if (formulario == null)
            {
                formulario = new MiForm();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;
                panelDesktop.Controls.Add(formulario);
                panelDesktop.Tag = formulario;
                formulario.Show();

                formulario.BringToFront();
                formulario.FormClosed += new FormClosedEventHandler(CloseForms);

            }
            else
            {
                formulario.BringToFront();
            }
        }
        private void CloseForms(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms["HomeSlide"] == null)
                ButtonHome.BackColor = Color.FromArgb(4, 41, 68);
            if (Application.OpenForms["Connect"] == null)
                ButtonConnect.BackColor = Color.FromArgb(4, 41, 68);
        }



        static bool status = false;
        private void MaintClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
            }
            else
            {
                Control.plc.SetDevice("M5", 1);
                Control.plc.SetDevice("M5", 0);
            }
        }

        private void ButtonCloseForm_Click(object sender, EventArgs e)
        {
            new LoginClose().ShowDialog();
        }

        private void ButtonHideForm_Click(object sender, EventArgs e)
        {
            Control.Minimized(this);
        }

        private void ButtonMaximumForm_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            Control.DoMaximed(this, btn);
        }


        private void Timer1_Tick(object sender, EventArgs e)
        {
            Reset();
            Control.plc.GetDevice("M204", out int Data);
            Control.plc.GetDevice("M205", out int Data1);
            Control.plc.GetDevice("M0", out int Dataconnect);

            AppState.StatusConnect = Dataconnect == 1;

            if(Dataconnect == 1)
            {
                MachineLog();
                if ((Data == 1 || Data1 == 1))
                {
                    AbrirFormulario<DisplayScreen>();
                    status = true;
                }
                else /*if(Data == 0 && Data1 == 0)*/
                {
                    if(status && AppState.Count == 0)
                    {
                        AbrirFormulario<HomeSlide>();
                        status = false;
                    }
                }
            }
        }
        private void MachineLog()
        {
            var listDownTimeToAdd = new List<MachineState>();

            if (AppState.StatusConnect && AppState.StatusRecord)
            {
                foreach (var machineState in _machineStates)
                {
                    int mainState, downtime;
                    Control.plc.GetDevice(machineState.AddressTimer, out downtime);
                    Control.plc.GetDevice(machineState.Address, out mainState);

                    if (mainState == 1)
                    {
                        if (machineState.State == 1) { machineState.Date = DateTime.Now; }
                        machineState.State = 0;
                        machineState.Downtime = downtime;
                    }
                    else if (machineState.Downtime > 0)
                    {
                        machineState.State = 1;
                        var now = DateTime.Now;
                        var dateStart = new DateTime(now.Ticks - downtime);

                        listDownTimeToAdd.Add(new MachineState
                        {
                            Downtime = machineState.Downtime,
                            Name = machineState.Name,
                            FlagDown = true,
                            Address = machineState.Address,
                            AddressTimer = machineState.AddressTimer,
                            Date = machineState.Date,
                            DateStart = dateStart,
                            State = 1
                        });
                        machineState.Downtime = 0;
                    }
                }
                if (listDownTimeToAdd.Count > 0)
                {
                    Console.WriteLine("Record" + listDownTimeToAdd.Count.ToString());
                    using (var db = new MyDbContext())
                    {
                        db.MachineCollection.InsertBulk(listDownTimeToAdd);
                        listDownTimeToAdd.Clear();
                        db.Dispose();
                    }
                }
            }
        }

        private void Reset()
        {
            var DateReset = DateTime.Now.ToString("HH:mm:ss");
            var DateScheduler = "23:59:59";//Thời gian disable read data downtime(kết thúc downtime để xuất file data)
            var DateScheduler1 = "00:00:05";//Thời gian enable read data downtime(sau khi xuất file xong sẽ cho phép đọc downtime)
            var DateScheduler2 = "00:00:10";//Thời gian reset giá trị time running và issue
            if (DateReset == DateScheduler)
            { Control.plc.SetDevice("M10", 1); }
            else if (DateReset == DateScheduler1)
            {
                Control.plc.SetDevice("M10", 0);
            }
            if (DateReset == DateScheduler2)
            {
                Control.plc.SetDevice("M3", 1);
                Control.plc.SetDevice("M3", 0);
            }
        }


        private void ButtonMenu_Click_1(object sender, EventArgs e)
        {
            if (panel2.Width == 40)
            {
                //panel2.Visible = false;
                panel2.Width = 200;

                Transition1.ShowSync(panel2);
            }
            else
            {
                //panel2.Visible = false;
                panel2.Width = 40;

                Transition1.ShowSync(panel2);
            }
        }

        private void ButtonHome_Click_1(object sender, EventArgs e)
        {
            AbrirFormulario<HomeSlide>();
            Timer1.Start();
        }

        private void ButtonConnect_Click_2(object sender, EventArgs e)
        {
            AbrirFormulario<Connect>();
            Timer1.Stop();
        }

        private void Main_Load(object sender, EventArgs e)
        {
        }
    }
}
