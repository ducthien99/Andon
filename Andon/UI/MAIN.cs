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
        private string[] listmay =      {"BM1" ,"BM2" ,"BM3", "BM4" ,"BM5",
                                         "BM6" ,"BM7" ,"BM8", "BM9" ,"BM10",
                                         "GRI" ,"2F1" ,"2F2", "2F3" ,"2F4",
                                         "2F5" ,"2F6" ,"2F7", "2F8" ,"2F9",
                                         "2F10","2F11","2F12","2F13","KAB"};// 25 MACHINE
        ////Địa chỉ giá trị Downtime
        private string[] ListDowntime = {"D50","D52","D54","D56", "D58", "D60", "D62", "D64", "D66", "D68", "D70", "D72", "D74", "D76",
                                         "D78","D80","D82","D84","D86","D88","D90","D92","D94","D96","D98"};
        //Địa chỉ xảy ra tác động gây Downtime
        private string[] ListFlashDown = { "M60","M61", "M62", "M63", "M64", "M65", "M66","M67", "M68", "M69", "M70",
                                           "M71","M72","M73","M74","M75","M76","M77","M78","M79","M80","M81","M82","M83","M84"};// 25 MACHINE
        
        private List<MachineState> lastestMachineState;
        //private AppState Page = new AppState();
        public MAIN()
        {
            InitializeComponent();
            //Control.AddFormBM();
            lastestMachineState = new List<MachineState>();
            using (var db = new MyDbContext())
            {
                for (int i = 0; i < listmay.Length; i++)
                {
                    var machineId = listmay[i];//ten may

                    var newMachine = new MachineState() { Name = machineId, Address = ListFlashDown[i], State = 1, AddressTimer = ListDowntime[i], Date = DateTime.Now, FlagDown = false };
                    lastestMachineState.Add(newMachine);

                }
            }
            new Scheduler().Start();
            Control.SetInitial(this);
            AbrirFormulario<HomeSlide>();
            AppState.PageConnect = false;
            AppState.PageSlide = true;
            AppState.PageSreenDiplay = false;
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
            Control.plc.SetDevice("M5", 1);
            Control.plc.SetDevice("M5", 0);
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

            Control.plc.GetDevice("M204", out int Data);
            Control.plc.GetDevice("M205", out int Data1);
            Control.plc.GetDevice("M0", out int Dataconnect);
            //Console.WriteLine("Trang thai trang ket noi" + ":" + AppState.PageConnect);
            //Console.WriteLine("Trang thai trang chinh" + ":" + AppState.PageSlide);
            //Console.WriteLine("Trang thai trang hien thi" + ":" + AppState.PageSreenDiplay);
            //Console.WriteLine("Trang thai chuc nang record du lieu" + ":" + AppState.StatusRecord);
            if (Dataconnect == 1)
            {
                //Control.IsConnect = true;
                AppState.StatusConnect = true;

            }
            else
            {
                //Control.IsConnect = false;
                AppState.StatusConnect = false;
            }


            if ((Data == 1 || Data1 == 1))
            {
                AbrirFormulario<DisplayScreen>();
                status = true;
                //Console.WriteLine("ok");
                AppState.PageSlide = false;
                AppState.PageSreenDiplay = true;

                //Control.IsDisplay = true;
                //Control.IsHome = false;
            }
            else /*if(Data == 0 && Data1 == 0)*/
            {
              
                if (status && AppState.Count ==0)
                {
                    AbrirFormulario<HomeSlide>();
                    //Control.IsHome = true;
                    //Control.IsConnection = true;
                    //Control.IsDisplay = false;
                    AppState.PageSlide = true;
                    AppState.PageSreenDiplay = false;
                    status = false;                  
                }
                //if(Page.PageHome == true)
                //{
                //    AbrirFormulario<HomeSlide>();
                //}    
                //else if(Page.PageSreenDiplay == true && Page.StatusConnect)
                //{
                //    AbrirFormulario<DisplayScreen>();
                //}    
                //else if(Page.PageConnect == true)
                //{
                //    AbrirFormulario<Connect>();
                //}

            }

        }
       
        private void timer2_Tick(object sender, EventArgs e)
        {
            var listDownTimeToAdd = new List<MachineState>();
            Int32[] ValueDowntime = new Int32[25];
            int[] StatusFlashDown = new int[25];
            
            if (AppState.StatusConnect && AppState.StatusRecord)
            {
                for (int i = 0; i < 25; i++)
                {
                    Control.plc.GetDevice(ListDowntime[i], out ValueDowntime[i]);
                    Control.plc.GetDevice(ListFlashDown[i], out StatusFlashDown[i]);
                    

                    //downtime 
                    var mc = lastestMachineState.FirstOrDefault(x => x.AddressTimer.ToLower() == ListDowntime[i].ToLower());
                    var mainState = StatusFlashDown[i];
                    var downtime = ValueDowntime[i];
                    if (mainState == 1)
                    {
                        var dt = DateTime.Now;
                        if (mc.State == 1) { mc.Date = dt; }
                        mc.State = 0;
                        mc.Downtime = ValueDowntime[i];
                        //Console.WriteLine("Address: " + mc.AddressTimer);
                        //Console.WriteLine("mainState: " + mainState);
                        //Console.WriteLine("downtime: " + mc.Downtime);

                    }
                    else if (mc.Downtime > 0)
                    {
                        mc.State = 1;
                        var now = DateTime.Now;
                        var dateStart = new DateTime(now.Ticks - downtime);
                        //Console.WriteLine("Address: " + mc.AddressTimer);
                        //Console.WriteLine("mainState: " + mainState);
                        //Console.WriteLine("downtime: " + mc.Downtime);
                        listDownTimeToAdd.Add(new MachineState
                        {
                            Downtime = mc.Downtime,
                            Name = mc.Name,
                            FlagDown = true,
                            Address = mc.Address,
                            AddressTimer = mc.AddressTimer,
                            //Date = DateTime.Now,
                            Date = mc.Date,
                            DateStart = dateStart,
                            State = 1
                        });
                        mc.Downtime = 0;
                        //Console.WriteLine(mc.Date);
                    }
                }
                if (listDownTimeToAdd.Count > 0)
                {
                    Console.WriteLine("Record" + listDownTimeToAdd.Count.ToString());
                    // Task.Run(() =>
                    //{
                    using (var db = new MyDbContext())
                    {
                        db.MachineCollection.InsertBulk(listDownTimeToAdd);

                        ////Insert
                        listDownTimeToAdd.Clear();
                    }
                    //});
                }
            }
           
        }

        private void Timer3_Tick(object sender, EventArgs e)
        {
            var DateReset = DateTime.Now.ToString("HH:mm:ss");
            var DateScheduler = "23:59:59";//Thời gian disable read data downtime(kết thúc downtime để xuất file data)
            var DateScheduler1 = "00:00:05";//Thời gian enable read data downtime(sau khi xuất file xong sẽ cho phép đọc downtime)
            var DateScheduler2 = "00:00:10";//Thời gian reset giá trị time running và issue
            if (DateReset== DateScheduler)
                { Control.plc.SetDevice("M10", 1); }
            else if(DateReset == DateScheduler1)
            {
                Control.plc.SetDevice("M10", 0);
            }
            if(DateReset == DateScheduler2)
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
            

            // Control.IsHome = true;
            AppState.PageSlide = true;
            AppState.PageConnect = false;
            AbrirFormulario<HomeSlide>();
        }

        private void ButtonConnect_Click_2(object sender, EventArgs e)
        {
            AppState.PageConnect = true;
            AppState.PageSlide = false;
            AbrirFormulario<Connect>();
           // Console.WriteLine(AppState.PageConnect);
            //Control.IsHome = false;

            //Control.IsConnection = true;
            
            
        }

        private void Main_Load(object sender, EventArgs e)
        {
            DisplayScreen.AddFormBM();
        }
    }
}
