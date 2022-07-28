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
        private static string[] listmay ={"BM1" ,"BM2" ,"BM3", "BM4" ,"BM5",
                                         "BM6" ,"BM7" ,"BM8", "BM9" ,"BM10",
                                         "GRI" ,"2F1" ,"2F2", "2F3" ,"2F4",
                                         "2F5" ,"2F6" ,"2F7", "2F8" ,"2F9",
                                         "2F10","2F11","2F12","2F13","KAB"};// 25 MACHINE
        private string[] AddressMaint = {"Y0" ,"Y1" , "Y2" , "Y3", "Y11",
                                         "Y7" ,"Y10", "Y6" , "Y5", "Y4" , 
                                         "Y12","Y13", "Y14", "Y15","Y16",
                                         "Y17","Y20", "Y21", "Y22","Y23",
                                         "Y24","Y62", "Y63", "Y64","Y25"}; // 25 dia chi
        private string[] AddressPro = {"Y26","Y27", "Y30", "Y31", "Y37",
                                          "Y35","Y36", "Y34", "Y33", "Y32", 
                                          "Y40","Y41", "Y42", "Y43", "Y44",
                                          "Y45","Y46", "Y47", "Y50", "Y51",
                                          "Y52","Y70", "Y71", "Y72","Y53 "};
        
        int[] valuepro = new int[25];
        int[] valuemaint = new int[25];

       
        
        public DisplayScreen()
        {
            InitializeComponent();
            tableLayoutPanel1.Controls.Clear();
            //Control.AddFormBM();
            //Status.PageConnect = false;
            //Status.PageHome = true;

            //Status.StatusConnect = false;
            
        }
        //private static GroupBox[] G_Mybutton = new GroupBox[25];
        private static GroupBox[] GroupBox = new GroupBox[25];
        private static BunifuThinButton2[] Button = new BunifuThinButton2[25];
        //private static BunifuThinButton2[] Button1 = new BunifuThinButton2[25];
        public static void AddFormBM()
        {
            for (int i = 0; i < 25; i++)
            {

                GroupBox[i] = new GroupBox();
                GroupBox[i].Name = "Flow" + i;
                //_flowLayoutPanel[i].Size = new Size(405, 364);
                GroupBox[i].Size = new Size(405, 364);
                GroupBox[i].Dock = DockStyle.Fill;
                //_flowLayoutPanel[i].BorderStyle = BorderStyle.None;


                Button[i] = new BunifuThinButton2();
                Button[i].ButtonText = listmay[i];
                Button[i].AutoSize = true;
                Button[i].Name = "Button" + i.ToString();
                Button[i].Dock = DockStyle.Fill;
                Button[i].Font = new Font("Century", 75, FontStyle.Bold);
                Button[i].Size = new Size(400, 600);
                Button[i].AutoSize = true;
                Button[i].IdleFillColor = Color.Red;
                Button[i].IdleForecolor = Color.White;
                Button[i].ActiveFillColor = Color.Red;
                Button[i].ActiveForecolor = Color.White;
                Button[i].TextAlign = ContentAlignment.MiddleCenter;

                //_flowLayoutPanel[i].Controls.Add(_button[i]);
                // _GroupBox[i].Controls.Add(_button[i]);
                GroupBox[i].Controls.Add(Button[i]);

                //tableLayoutPanel1.Controls.Add(_flowLayoutPanel[i]);
                //tableLayoutPanel1.Controls.Add(_button[i]);


            }
           //G_Mybutton = GroupBox;
           AppState.GroupBox1 = GroupBox;
           //Button1 = Button;
           AppState.Button = Button;
            Console.WriteLine(AppState.GroupBox1.Count());
            Console.WriteLine(AppState.Button.Count());
        }
        private void UpdateLable()
        {

            for (int i = 0; i < listmay.Length; i++)
            {
                Control.plc.GetDevice(AddressMaint[i], out valuemaint[i]);
                Control.plc.GetDevice(AddressPro[i], out valuepro[i]);
                if (valuemaint[i] == 1 || valuepro[i] == 1)
                {

                    if (list[i] == false && this.Controls.Count < 6)
                    {
                        tableLayoutPanel1.Controls.Add(AppState.GroupBox1[i]);

                        list[i] = true;
                    }
                }
                if ((valuemaint[i] == 0) && (list[i] == true) && (valuepro[i]) == 0)
                {
                    tableLayoutPanel1.Controls.Remove(AppState.GroupBox1[i]);
                    list[i] = false;
                }



                //foreach (var b in _button1.ToList())

                foreach (BunifuThinButton2 b in AppState.Button.OfType<BunifuThinButton2>().ToList())
                    {

                    if (b.Name == "Button" + i.ToString())
                    {

                        if (valuemaint[i] == 1 && valuepro[i] == 0)
                        {
                            b.IdleFillColor = Color.Red;
                            b.ActiveFillColor = Color.Red;
                        }
                        else if (valuepro[i] == 1 && valuemaint[i] == 0)
                        {
                            b.IdleFillColor = Color.Lime;
                            b.ActiveFillColor = Color.Lime;
                        }
                        else if (valuemaint[i] == 1 && valuepro[i] == 1)
                        {
                            b.IdleFillColor = Color.RoyalBlue;
                            b.ActiveFillColor = Color.RoyalBlue;
                        }

                     }

                }
            
          
             }
            AppState.Count = tableLayoutPanel1.Controls.Count;
            Console.WriteLine(AppState.Count);
        }

        private static bool[] list = {false, false, false, false, false,
                                      false, false, false, false, false, 
                                      false, false, false, false, false,
                                      false, false, false, false, false,
                                      false, false, false, false, false};

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
                    UpdateLable();
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

