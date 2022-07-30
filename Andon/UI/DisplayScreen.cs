using Andon.Entity;
//using ActUtlTypeLib;

using Andon.Utils;
using Bunifu.Framework.UI;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using Andon.ControlApp;

namespace Andon.UI
{
    
    public partial class DisplayScreen : Form
    {
        private MachineState[] _machineStates = new MachineState[25];
        //private List<MachineError> _machineErrors = new List<MachineError>();
        private GroupBox[] _groupBoxes = new GroupBox[25];
        private List<int> _ints;
        
        public DisplayScreen()
        {
            InitializeComponent();
            _machineStates = Data.machineStates();
            _ints = new List<int>();

        }

        private void ShowListMachineError()
        {
            for (int i = 0; i < 25; i++)
            {
                string name = _machineStates[i].Name;
                int valuemaint, valuepro;
                Control.plc.GetDevice(_machineStates[i].AddressMaint, out valuemaint);
                Control.plc.GetDevice(_machineStates[i].AddressPro, out valuepro);
                if (valuemaint == 1 || valuepro == 1)
                {
                    if (_ints.Contains(i))
                    {
                        _groupBoxes[i].Visible = true;
                        UpdateColor(i,name,valuemaint,valuepro);
                        continue;
                    }
                    else
                    {
                        _groupBoxes[i] = CreateGroupBox(name, valuemaint, valuepro);
                        tableLayoutPanel1.Controls.Add(_groupBoxes[i]);
                        //_machineErrors.Add(new MachineError(_machineStates[i].Name, valuemaint, valuepro));
                        _ints.Add(i);

                    }

                }
                else
                {
                    if (_ints.Contains(i))
                    {
                        _groupBoxes[i].Visible = false;
                    }
                }
            }

        }

        private GroupBox CreateGroupBox(string name,int valuemaint,  int valuepro)
        {
            GroupBox groupBox = new GroupBox();
            groupBox.Name = "Flow" + name;
            groupBox.Size = new Size(405, 364);
            groupBox.Dock = DockStyle.Fill;

            BunifuThinButton2 button = new BunifuThinButton2();
            button.ButtonText = name;
            button.AutoSize = true;
            button.Name = "Button" + name;
            button.Dock = DockStyle.Fill;
            button.Font = new Font("Century", 75, FontStyle.Bold);
            button.Size = new Size(400, 600);
            button.AutoSize = true;
            button.IdleFillColor = Color.Red;
            button.IdleForecolor = Color.White;
            button.ActiveFillColor = Color.Red;
            button.ActiveForecolor = Color.White;
            button.TextAlign = ContentAlignment.MiddleCenter;

            if (valuemaint == 1 && valuepro == 0)
            {
                button.IdleFillColor = Color.Red;
                button.ActiveFillColor = Color.Red;
            }
            else if (valuepro == 1 && valuemaint == 0)
            {
                button.IdleFillColor = Color.Lime;
                button.ActiveFillColor = Color.Lime;
            }
            else if (valuemaint == 1 && valuepro == 1)
            {
                button.IdleFillColor = Color.RoyalBlue;
                button.ActiveFillColor = Color.RoyalBlue;
            }

            groupBox.Controls.Add(button);
            return groupBox;
        }
        private void UpdateColor(int i,string name,int valuemaint, int valuepro)
        {
            BunifuThinButton2 button = _groupBoxes[i].Controls.Find("Button" + name, false).FirstOrDefault() as BunifuThinButton2;
            if (valuemaint == 1 && valuepro == 0)
            {
                button.IdleFillColor = Color.Red;
                button.ActiveFillColor = Color.Red;
            }
            else if (valuepro == 1 && valuemaint == 0)
            {
                button.IdleFillColor = Color.Lime;
                button.ActiveFillColor = Color.Lime;
            }
            else if (valuemaint == 1 && valuepro == 1)
            {
                button.IdleFillColor = Color.RoyalBlue;
                button.ActiveFillColor = Color.RoyalBlue;
            }
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            Control.plc.GetDevice("M0", out int Dataconnect);
            
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
            if (AppState.StatusConnect && AppState.PageSreenDiplay)
            {
                int StatusUpdate;
                int StatusUpdate1;
                Control.plc.GetDevice("M204", out StatusUpdate);
                Control.plc.GetDevice("M205", out StatusUpdate1);
                if (StatusUpdate == 1|| StatusUpdate1==1)
                {
                    ShowListMachineError();
                }
                else
                {
                    if (AppState.Count > 0)
                    {
                        tableLayoutPanel1.Controls.Clear();
                    }
                }
            }
        }

        private void DisplayScreen_Load(object sender, EventArgs e)
        {

        }

        private void DisplayScreen_Closing(object sender, FormClosingEventArgs e)
        {
            tableLayoutPanel1.Controls.Clear();
        }

       
    }
}

