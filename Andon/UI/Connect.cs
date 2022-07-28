using System;
using System.Drawing;
using System.Windows.Forms;
using Andon.ControlApp;

namespace Andon.UI
{
    public partial class Connect : Form
    {
       
        //private AppState Status = new AppState();
        public Connect()
        {
            InitializeComponent();
            //Control.plc.ActLogicalStationNumber = 2;

            Control.plc.SetDevice("M7", 0);
            Control.plc.SetDevice("M6", 0);
            Control.plc.SetDevice("M4", 0);
            Control.plc.SetDevice("M5", 0);
            LableTypeCPU.Visible = false;
            LableCPUname.Visible = false;
            //ButtonControlTest.Visible = false;
            //ButtonHorn.Visible = false;
            //AppState.StatusConnect = false;
            //Status.PageConnect = false;
            //Status.PageHome = true;
            
          
           
           
        }


        private void SendDataClock()
        {

            //int readdata;
            short hour;
            short minute;
            short second;
            short year;
            short month;
            short day;
            short DW;

            string DayofWeek;
            string syear = DateTime.Now.Year.ToString();
            //int index = syear.Length;
            string Year = syear.Substring(2, 2);
            year = Convert.ToInt16(Year);
            month = Convert.ToInt16(DateTime.Now.Month.ToString());
            day = Convert.ToInt16(DateTime.Now.Day.ToString());

            hour = Convert.ToInt16(DateTime.Now.Hour.ToString());
            minute = Convert.ToInt16(DateTime.Now.Minute.ToString());
            second = Convert.ToInt16(DateTime.Now.Second.ToString());
            DayofWeek = DateTime.Now.DayOfWeek.ToString();

            if (DayofWeek == "Sunday")
            {
                DW = 0;
                //Control.plc.SetClockData(year, month, day, DW, hour, minute, second);
                Control.plc.SetClockData(year, month, day, DW, hour, minute, second);
            }

            if (DayofWeek == "Monday")
            {
                DW = 1;
                //Control.plc.SetClockData(year, month, day, DW, hour, minute, second);
                Control.plc.SetClockData(year, month, day, DW, hour, minute, second);
            }
            if (DayofWeek == "Tuesday")
            {
                DW = 2;
                //Control.plc.SetClockData(year, month, day, DW, hour, minute, second);
                Control.plc.SetClockData(year, month, day, DW, hour, minute, second);
            }
            if (DayofWeek == "Wednesday")
            {
                DW = 3;
                //Control.plc.SetClockData(year, month, day, DW, hour, minute, second);
                Control.plc.SetClockData(year, month, day, DW, hour, minute, second);
            }
            if (DayofWeek == "Thursday")
            {
                DW = 4;
                //Control.plc.SetClockData(year, month, day, DW, hour, minute, second);
                Control.plc.SetClockData(year, month, day, DW, hour, minute, second);
            }
            if (DayofWeek == "Friday")
            {
                DW = 5;
                //Control.plc.SetClockData(year, month, day, DW, hour, minute, second);
                Control.plc.SetClockData(year, month, day, DW, hour, minute, second);
            }
            if (DayofWeek == "Saturday")
            {
                DW = 6;
                //Control.plc.SetClockData(year, month, day, DW, hour, minute, second);
                Control.plc.SetClockData(year, month, day, DW, hour, minute, second);
            }

        }




        private void Connect_Load(object sender, EventArgs e)
        {
            
            ButtonHorn.Visible = false;
            //ButtonControlTest.Visible = false;
            ButtonRecord.Visible = false;
            if (AppState.StatusConnect == true)
            {
                lable_status_connect.Text = "Connect Success!";
                lable_status_connect.ForeColor = Color.Lime;
            }
            else
            {
                lable_status_connect.Text = "Please Connect PLC!";
                lable_status_connect.ForeColor = Color.Red;
            }
        }

        private void ButtonConnect_Click_1(object sender, EventArgs e)
        {
            Control.plc.SetDevice("M4", 1);
            Control.plc.SetDevice("M4", 0);
            Control.plc.SetDevice("M8", 1);
            Control.plc.SetDevice("M8", 0);
            //if (Status.StatusConnect == true)
            //{
            //    LableTypeCPU.Visible = true;
            //    LableCPUname.Visible = true;
            //    lable_status_connect.Text = "Connect Success!";
            //    lable_status_connect.ForeColor = Color.Lime;
            //    SendDataClock();
            //    Control.plc.GetCpuType(out string TypeCPU, out int TypeCpu);
            //    LableTypeCPU.Text = TypeCPU;
            //    ButtonHorn.Visible = true;
            //    Status.PageConnect = true;
            //}
            //else
            //{
            //    LableTypeCPU.Visible = false;
            //    LableCPUname.Visible = false;
            //    //ButtonControlTest.Visible = false;
            //    ButtonHorn.Visible = false;
            //    lable_status_connect.Text = "Please Connect PLC!";
            //    lable_status_connect.ForeColor = Color.Red;

            //}
        }

        private void ButtonDisconnect_Click_1(object sender, EventArgs e)
        {
            Control.plc.SetDevice("M5", 1);
            Control.plc.SetDevice("M5", 0);
            Control.plc.SetDevice("M9", 1);
            Control.plc.SetDevice("M9", 0);
            //Control.plc.SetDevice("M5", 1);
            //Control.plc.SetDevice("M5", 0);
            //LableTypeCPU.Visible = false;
            //LableCPUname.Visible = false;
           
            //if (Status.StatusConnect == true)
            //{
            //    lable_status_connect.Text = "Connect Success!";
            //    lable_status_connect.ForeColor = Color.Lime;
            //    Status.StatusConnect = true;
            //}
            //else
            //{
            //    lable_status_connect.Text = "Please Connect PLC!";
            //    lable_status_connect.ForeColor = Color.Red;
            //    Status.StatusConnect = false;
            //}
               
          
        }
       
       
        
        int count = 0;
        private void ButtonHorn_Click(object sender, EventArgs e)
        {
            //Console.WriteLine(Status.StatusConnect);
            if (AppState.StatusConnect == true)
            {

                count++;
                if (count == 1)
                {
                    Control.plc.SetDevice("M1", 1);
                    Control.plc.SetDevice("M1", 0);

                }

                if (count == 2)
                {
                    count = 0;
                }
                if (count == 0)
                {
                    Control.plc.SetDevice("M2", 1);

                    Control.plc.SetDevice("M2", 0);

                }

            }
        }
       
        private  void ReadStatusFromPLC()
        {
            int StatusConnect , StatusHorning , StatusRecording;

            Control.plc.GetDevice("M0", out StatusConnect);
            Control.plc.GetDevice("M385", out StatusHorning);
            Control.plc.GetDevice("M386", out StatusRecording);
            if (StatusConnect == 1)
            {
                AppState.StatusConnect = true;

                LableTypeCPU.Visible = true;
                LableCPUname.Visible = true;
                lable_status_connect.Text = "Connect Success!";
                lable_status_connect.ForeColor = Color.Lime;
                SendDataClock();
                Control.plc.GetCpuType(out string TypeCPU, out int TypeCpu);
                LableTypeCPU.Text = TypeCPU;
                ButtonHorn.Visible = true;
                //AppState.PageConnect = true;
            }
            if (StatusConnect == 0)
            {
                AppState.StatusConnect = false;

                LableTypeCPU.Visible = false;
                LableCPUname.Visible = false;
                //ButtonControlTest.Visible = false;
                ButtonHorn.Visible = false;
                lable_status_connect.Text = "Please Connect PLC!";
                lable_status_connect.ForeColor = Color.Red;
                ButtonHorn.Visible = false;
                //AppState.PageConnect = false;
            }
            if (StatusHorning == 0)
            {
                AppState.StatusHorn = false;
            }
            if (StatusHorning == 1)
            {
                AppState.StatusHorn = true;
                //Console.WriteLine(Status.StatusHorn);
            }
          
            if (StatusRecording == 0)
            {
                AppState.StatusRecord = false;
            }
            else
            {
                AppState.StatusRecord = true;
            }    
           


        }
        private void Timer1_Tick(object sender, EventArgs e)
        {
            if(AppState.PageConnect)
            {
                ReadStatusFromPLC();
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
            }
            
            if (AppState.StatusConnect && AppState.PageConnect)
            {
                lable_status_connect.Text = "Connect Success!";
                lable_status_connect.ForeColor = Color.Lime;
                //ButtonControlTest.Visible = true;
                ButtonHorn.Visible = true;
                ButtonRecord.Visible = true;
                LableCPUname.Visible = true;
                LableTypeCPU.Visible = true;
                
                if (AppState.StatusHorn==true)
                {
                    ButtonHorn.IdleFillColor = Color.Lime;
                    ButtonHorn.IdleForecolor = Color.White;
                }
                else
                {
                    ButtonHorn.IdleFillColor = Color.Red;
                    ButtonHorn.IdleForecolor = Color.White;
                }
                if (AppState.StatusRecord)
                {
                    ButtonRecord.IdleFillColor = Color.Lime;
                    ButtonRecord.IdleForecolor = Color.White;
                }
                else
                {
                    ButtonRecord.IdleFillColor = Color.Red;
                    ButtonRecord.IdleForecolor = Color.White;
                }



            }
            else
            {
                lable_status_connect.Text = "Please Connect PLC!";
                lable_status_connect.ForeColor = Color.Red;
                LableCPUname.Visible = false;
                LableTypeCPU.Visible = false;
                //ButtonControlTest.Visible = false;
                ButtonHorn.Visible = false;
                ButtonRecord.Visible = false;
            }
            //Console.WriteLine(Status.StatusConnect);
            //Console.WriteLine(Status.PageConnect);
            
        }
        //int Counter;
        private void ButtonRecord_Click(object sender, EventArgs e)
        {
            //new Login().ShowDialog();
            //if (Control.IsConnect == true)
            //{

            //    Counter++;
            //    if (Counter == 1)
            //    {
            //        Control.plc.SetDevice("M8", 1);
            //        Control.plc.SetDevice("M8", 0);

            //    }

            //    if (Counter == 2)
            //    {
            //        Counter = 0;
            //    }
            //    if (Counter == 0)
            //    {
            //        Control.plc.SetDevice("M9", 1);

            //        Control.plc.SetDevice("M9", 0);

            //    }

            //}
        }
    }
}
