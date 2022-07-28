using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bunifu.Framework.UI;

namespace AddOn.UI
{
    public partial class Home : Form
    {
        List<BunifuThinButton2> ButtonMaintCreated = new List<BunifuThinButton2>();
        List<BunifuThinButton2> ButtonProCreated = new List<BunifuThinButton2>();
        List<BunifuCustomLabel> LabelTimeCreated = new List<BunifuCustomLabel>();
        List<BunifuCustomLabel> LabelIssueCreated = new List<BunifuCustomLabel>();
        BunifuThinButton2[] ButtonMaint = new BunifuThinButton2[22];
        BunifuThinButton2[] ButtonPro = new BunifuThinButton2[22];
        BunifuCustomLabel[] LabelTime = new BunifuCustomLabel[22];
        BunifuCustomLabel[] LabelIssue = new BunifuCustomLabel[22];
        //private string[] Listtimer = { "D0","D1", "D2", "D3", "D4", "D5", "D6","D7", "D8", "D9", "D10",
        //                             "D11","D12","D13","D14","D15","D16","D17","D18","D19","D20","D21"};
        private string[] ListCounter = { "D128","D130", "D132", "D134", "D136", "D138", "D140","D142", "D144", "D146", "D148",
                                     "D150","D152","D154","D156","D158","D160","D162","D164","D168","D170","D172"};

        //private string[] AddressMaint = {"Y0","Y1", "Y2", "Y3", "Y4", "Y5", "Y6", "Y7", "Y10", "Y11", "Y12", "Y13", "Y14","Y15",
        //                                       "Y16","Y17","Y20","Y21","Y22","Y23","Y24","Y25"};
        private string[] AddressPro = {"Y26","Y27", "Y30", "Y31", "Y32", "Y33", "Y34", "Y35", "Y36", "Y37", "Y40", "Y41", "Y42","Y43",
                                               "Y44","Y45","Y46","Y47","Y50","Y51","Y52","Y53"};
        //int[] StatusMaint = new int[22];
        int[] StatusPro = new int[22];
        //Int32[] ValueTimer = new Int32[22];
        Int32[] ValueIssue = new Int32[22];
        
        public Home()
        {
            InitializeComponent();
            CreateDisplayControl();
           
            
        }
        //private BunifuThinButton2 bm = new BunifuThinButton2();
        //private BunifuThinButton2 bp = new BunifuThinButton2();
        //private BunifuCustomLabel lt = new BunifuCustomLabel();
        //private BunifuCustomLabel lc = new BunifuCustomLabel();
        private void CreateDisplayControl()
        {
            for (int i = 0; i < 22; i++)
            {
                ///////////////////////////////////BUTTON MAINT////////////////////////////////////////////////
                //////Edit
                int WidthM = 160;
                int HeightM = 127;
                ButtonMaint[i] = new BunifuThinButton2();
                ButtonMaint[i].Name = "ButtonMaint" + i.ToString();
                ButtonMaint[i].ButtonText = "MAINT";
                ButtonMaint[i].Font = new Font("Century", 22, FontStyle.Bold);
                ButtonMaint[i].Dock = DockStyle.Fill;
                ButtonMaint[i].Width = WidthM;
                ButtonMaint[i].Height = HeightM;
                ButtonMaint[i].TextAlign = ContentAlignment.MiddleCenter;
                ButtonMaint[i].Margin = new Padding();
                ButtonMaint[i].IdleFillColor = Color.White;
                ButtonMaint[i].IdleForecolor = Color.Red;
                ButtonMaint[i].IdleLineColor = Color.Red;
                //bm.ActiveForecolor = Color.Red;
                //bm.ActiveForecolor = Color.White;
                ButtonMaint[i].ActiveFillColor = Color.Orange;
                ////////////////////////////////////////////////////////////////////////////////////////////////
                ///////////////////////////////BUTTON PRO//////////////////////////////////////////////////////
                int WidthP = 160;
                int HeightP = 127;
                ButtonPro[i] = new BunifuThinButton2();
                ButtonPro[i].Name = "ButtonPro" + i.ToString();
                ButtonPro[i].ButtonText = "PRO";
                ButtonPro[i].Font = new Font("Century", 22, FontStyle.Bold);
                //b.Click += new EventHandler(this.ButtonProClick);
                ButtonPro[i].Dock = DockStyle.Fill;
                ButtonPro[i].Width = WidthP;
                ButtonPro[i].Height = HeightP;
                ButtonPro[i].TextAlign = ContentAlignment.MiddleCenter;
                ButtonPro[i].Margin = new Padding();
                ButtonPro[i].IdleFillColor = Color.White;
                ButtonPro[i].IdleForecolor = Color.LimeGreen;
                ButtonPro[i].IdleLineColor = Color.LimeGreen;
                ButtonPro[i].ActiveFillColor = Color.Lime;
                /////////////////////////////////////////////////////////////////////////////////////////////////////
                ///////////////////////////////LABLE TIMER///////////////////////////////////////////////////
                int WidthT = 160;
                int HeightT = 46;
                LabelTime[i] = new BunifuCustomLabel();
                LabelTime[i].Name = "LableTime" + i.ToString();
                LabelTime[i].Text = "0";
                LabelTime[i].Font = new Font("Century", 20, FontStyle.Bold);

                LabelTime[i].Width = WidthT;
                LabelTime[i].Height = HeightT;
                LabelTime[i].TextAlign = ContentAlignment.MiddleRight;
                LabelTime[i].Margin = new Padding();
                LabelTime[i].BorderStyle = BorderStyle.None;


                ///////////////////////////////////////////////////////////////////////////////////////////////////////////
                ////////////////////////////////////LABLE ISSUE//////////////////////////////////////////////////////////
                int WidthLC = 160;
                int HeightLC = 46;
                LabelIssue[i] = new BunifuCustomLabel();
                LabelIssue[i].Name = "LableIssue" + i.ToString();
                LabelIssue[i].Text = "0";
                LabelIssue[i].Font = new Font("Century", 20, FontStyle.Bold);

                LabelIssue[i].Width = WidthLC;
                LabelIssue[i].Height = HeightLC;
                LabelIssue[i].TextAlign = ContentAlignment.MiddleRight;
                LabelIssue[i].Margin = new Padding();
                LabelIssue[i].BorderStyle = BorderStyle.None;

                ButtonMaintCreated.Add(ButtonMaint[i]);
                ButtonProCreated.Add(ButtonPro[i]);
                LabelTimeCreated.Add(LabelTime[i]);
                LabelIssueCreated.Add(LabelIssue[i]);
                if (i < 11)
                {
                    tableLayoutPanel2.Controls.Add(ButtonMaintCreated[i]);
                    tableLayoutPanel3.Controls.Add(ButtonProCreated[i]);
                    tableLayoutPanel4.Controls.Add(LabelTimeCreated[i]);
                    tableLayoutPanel5.Controls.Add(LabelIssue[i]);
                }
                else
                {
                    tableLayoutPanel7.Controls.Add(ButtonMaintCreated[i]);
                    tableLayoutPanel8.Controls.Add(ButtonProCreated[i]);
                    tableLayoutPanel9.Controls.Add(LabelTimeCreated[i]);
                    tableLayoutPanel10.Controls.Add(LabelIssue[i]);
                }
            }
        }
       
        /// ///insert
  
        private bool[] Status = {false, false, false, false, false, false, false, false, false, false, false, false, false, false,
                               false,false,false,false,false,false,false,false};
        private void UpdateStatusButton()
        {
            for (int i = 0; i < 22; i++)
            {
                //Control.plc.GetDevice(Listtimer[i], out ValueTimer[i]);
                Control.plc.GetDevice(AddressPro[i], out StatusPro[i]);
                //Control.plc.GetDevice(AddressMaint[i], out StatusMaint[i]);
                Control.plc.GetDevice(ListCounter[i], out ValueIssue[i]);
                
                
                foreach (var item in ButtonProCreated.ToList())
                {
                    //if (ButtonPro.Count > 0)
                    //{
                        if (StatusPro[i] == 1 && Status[i]==false)
                        {
                            if (item.Name == "ButtonPro" + i.ToString())
                            {
                                item.IdleFillColor = Color.Lime;
                                Status[i] = true;
                            }
                        }
                        else if(StatusPro[i] == 0 && Status[i] == true)
                        {
                            if (item.Name == "ButtonPro" + i.ToString())
                            {
                                item.IdleFillColor = Color.White;
                            Status[i] = false;
                        }
                        }
                    //}

                }

                foreach (var item in LabelIssueCreated.ToList())
                {

                    if (item.Name == "LableIssue" + i.ToString())
                    {
                        item.Text = ValueIssue[i].ToString();
                    }


                }

            }

        }

        private void Home_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 22; i++)
            {
                Control.plc.GetDevice(ListCounter[i], out ValueIssue[i]);

            }
        }
       
        private void timer1_Tick(object sender, EventArgs e)
        {
            //Console.WriteLine(ButtonProCreated.ToList().Count);
            if (Control.IsConnect && !Control.IsMode && Control.IsHome)
            {
                UpdateStatusButton();
            }
        }
    }
}
