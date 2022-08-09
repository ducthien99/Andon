using Bunifu.Framework.UI;
using System;
using System.Drawing;
using System.Windows.Forms;
using Andon.ControlApp;
using Andon.Entity;

namespace Andon.UI
{
    public partial class HomeSlide : Form
    {
        #region field
        private MachineState[] _machineStates = new MachineState[30];
        #endregion
        public HomeSlide()
        {
            InitializeComponent();
            _machineStates = Data.machineStates();
            AddForm();

        }
        //public static string[] listmay =    { "BM1","BM2", "BM3", "BM4", "BM5", "BM6", "BM7","BM8", "BM9", "BM10", "GRI",
        //                                      "2F1","2F2","2F3","2F4","2F5","2F6","2F7","2F8","2F9","2F10","2F11","2F12","2F13","KAB","","","","",""};// 25 MACHINE CÓ SẴN, 3 MÁY CHƯA CÓ

        //private string[] ListCounterIssue = { "D128","D130", "D132", "D134", "D146", "D142", "D144","D140", "D138", "D136", "D148",
        //                                      "D150","D152","D154","D156","D158","D160","D162","D164","D166","D168","D172","D174","D176","D170","D178","D180","D182","D184","D186"};
        //                                     //D178-D186 THEM 5 MAY DU PHONG
        ////list lưu thời gian chạy máy 
        //private string[] ListTimeRun =      {"D0","D2","D4","D6", "D8", "D10", "D12", "D14", "D16", "D18", "D20", "D22", "D24", "D26",
        //                                     "D28","D30","D32","D34","D36","D38","D40","D42","D44","D46","D48","D50","D52","D54","D56","D58"};
        //                                     //D50-D58 THEM 5 MAY DU PHONG
        int[] ValueIssue = new int[30];
        public static int[] ValueTimeRun = new int[30];
        Panel[] GroupBoxForm = new Panel[6];
        BunifuThinButton2[] _button = new BunifuThinButton2[6];
        Label[] _lableTime = new Label[6];
        Label[] _lableIssue = new Label[6];


        private void AddForm()
        {
            for (int i = 0; i < 6; i++)
            {
                GroupBoxForm[i] = new Panel();
                GroupBoxForm[i].Name = "Flow" + i;
                GroupBoxForm[i].Dock = DockStyle.Fill;
                GroupBoxForm[i].Size = new Size(600, 600);
                GroupBoxForm[i].BorderStyle = BorderStyle.None;
                //Tạo Button
                _button[i] = new BunifuThinButton2();
                _button[i].ButtonText = _machineStates[i].Name;
                _button[i].AutoSize = false;
                _button[i].Name = "Button" + i.ToString();
                _button[i].Dock = DockStyle.Top;
                _button[i].Font = new Font("Century", 70, FontStyle.Bold);
                _button[i].Size = new Size(300, 240);
                _button[i].IdleFillColor = Color.Blue;
                _button[i].IdleForecolor = Color.White;
                _button[i].ActiveFillColor = Color.Blue;
                _button[i].ActiveForecolor = Color.White;
                _button[i].IdleLineColor = Color.Transparent;
                _button[i].ActiveLineColor = Color.Transparent;
                _button[i].TextAlign = ContentAlignment.MiddleCenter;


                //Tạo Lable
                _lableTime[i] = new Label();
                _lableTime[i].Name = "lable" + i;
                _lableTime[i].Text = "0";
                _lableTime[i].Dock = DockStyle.Bottom;
                _lableTime[i].Size = new Size(100, 60);
                _lableTime[i].BorderStyle = BorderStyle.FixedSingle;
                _lableTime[i].TextAlign = ContentAlignment.MiddleRight;
                _lableTime[i].Font = new Font("Century", 42, FontStyle.Bold);
                _lableTime[i].BackColor = Color.White;
                _lableTime[i].ForeColor = Color.Blue;

                _lableIssue[i] = new Label();
                _lableIssue[i].Name = "lable" + i;
                _lableIssue[i].Text = "0";
                _lableIssue[i].Dock = DockStyle.Bottom;
                _lableIssue[i].Size = new Size(100, 60);
                _lableIssue[i].BorderStyle = BorderStyle.FixedSingle;
                _lableIssue[i].TextAlign = ContentAlignment.MiddleRight;
                _lableIssue[i].Font = new Font("Century", 42, FontStyle.Bold);
                _lableIssue[i].BackColor = Color.White;
                _lableIssue[i].ForeColor = Color.Blue;
                //Add vào form
                GroupBoxForm[i].Controls.Add(_button[i]);
                GroupBoxForm[i].Controls.Add(_lableTime[i]);
                GroupBoxForm[i].Controls.Add(_lableIssue[i]);
                tableLayoutPanel1.Controls.Add(GroupBoxForm[i]);
            }




        }

        Timer MyTimer = new Timer();
        int j = 0;


        private void MyTimer_Tick(object sender, EventArgs e)
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

            for (int i = 0; i < 30; i++)
            {
                Control.plc.GetDevice(_machineStates[i].CounterIssue, out ValueIssue[i]);
                Control.plc.GetDevice(_machineStates[i].TimeRun, out ValueTimeRun[i]);
            }
            if (AppState.StatusConnect)
            {

                if (j == 5)
                {
                    j = 0;
                }
                if (j == 4)
                {
                    _button[1].IdleFillColor = Color.Transparent;
                    _button[1].IdleForecolor = Color.Transparent;
                    _button[1].ActiveFillColor = Color.Transparent;
                    _button[1].ActiveForecolor = Color.Transparent;
                    _lableIssue[1].Visible = false;
                    _lableTime[1].Visible = false;
                    _button[2].IdleFillColor = Color.Transparent;
                    _button[2].IdleForecolor = Color.Transparent;
                    _button[2].ActiveFillColor = Color.Transparent;
                    _button[2].ActiveForecolor = Color.Transparent;
                    _lableIssue[2].Visible = false;
                    _lableTime[2].Visible = false;
                    _button[3].IdleFillColor = Color.Transparent;
                    _button[3].IdleForecolor = Color.Transparent;
                    _button[3].ActiveFillColor = Color.Transparent;
                    _button[3].ActiveForecolor = Color.Transparent;
                    _lableIssue[3].Visible = false;
                    _lableTime[3].Visible = false;
                    _button[4].IdleFillColor = Color.Transparent;
                    _button[4].IdleForecolor = Color.Transparent;
                    _button[4].ActiveFillColor = Color.Transparent;
                    _button[4].ActiveForecolor = Color.Transparent;
                    _lableIssue[4].Visible = false;
                    _lableTime[4].Visible = false;
                    _button[5].IdleFillColor = Color.Transparent;
                    _button[5].IdleForecolor = Color.Transparent;
                    _button[5].ActiveFillColor = Color.Transparent;
                    _button[5].ActiveForecolor = Color.Transparent;
                    _lableIssue[5].Visible = false;
                    _lableTime[5].Visible = false;

                }
                else
                {
                    _button[1].IdleFillColor = Color.Blue;
                    _button[1].IdleForecolor = Color.White;
                    _button[1].ActiveFillColor = Color.Blue;
                    _button[1].ActiveForecolor = Color.White;
                    _lableIssue[1].Visible = true;
                    _lableTime[1].Visible = true;
                    _button[2].IdleFillColor = Color.Blue;
                    _button[2].IdleForecolor = Color.White;
                    _button[2].ActiveFillColor = Color.Blue;
                    _button[2].ActiveForecolor = Color.White;
                    _lableIssue[2].Visible = true;
                    _lableTime[2].Visible = true;
                    _button[3].IdleFillColor = Color.Blue;
                    _button[3].IdleForecolor = Color.White;
                    _button[3].ActiveFillColor = Color.Blue;
                    _button[3].ActiveForecolor = Color.White;
                    _lableIssue[3].Visible = true;
                    _lableTime[3].Visible = true;
                    _button[4].IdleFillColor = Color.Blue;
                    _button[4].IdleForecolor = Color.White;
                    _button[4].ActiveFillColor = Color.Blue;
                    _button[4].ActiveForecolor = Color.White;
                    _lableIssue[4].Visible = true;
                    _lableTime[4].Visible = true;
                    _button[5].IdleFillColor = Color.Blue;
                    _button[5].IdleForecolor = Color.White;
                    _button[5].ActiveFillColor = Color.Blue;
                    _button[5].ActiveForecolor = Color.White;
                    _lableIssue[5].Visible = true;
                    _lableTime[5].Visible = true;

                }
                for (int i = 0; i < 6; i++)
                {
                    _button[i].ButtonText = _machineStates[6 * j + i].Name;
                    _lableIssue[i].Text = ValueIssue[6 * j + i].ToString();
                    _lableTime[i].Text = ValueTimeRun[6 * j + i].ToString();
                }
                j++;

            }
        }


        private void HomeSlide_Load_1(object sender, EventArgs e)
        {
            MyTimer.Interval = 10000;
            MyTimer.Start();
            MyTimer.Tick += new EventHandler(MyTimer_Tick);
        }
    }
}
