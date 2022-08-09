using Andon.Entity;
using Bunifu.Framework.UI;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Andon.UI
{
    
    public partial class DisplayScreen : Form
    {
        #region field
        private MachineState[] _machineStates = new MachineState[25];
        private GroupBox[] _groupBoxes = new GroupBox[25];
        private List<int> _repoHistoryMachineError;
        private bool _scrollDown = true;
        private const int STEP_SIZE = 30;// 10 pixel
        private Timer _timer;
        #endregion

        #region constructor
        public DisplayScreen()
        {
            InitializeComponent();
            _machineStates = Data.machineStates();
            _repoHistoryMachineError = new List<int>();
            _timer = new Timer();
            _timer.Interval = (200); // 0.2 second
            _timer.Tick += new EventHandler(ScrollTimer_Tick);

        }
        #endregion

        #region private method
        private void ShowListMachineError()
        {
            int countVisible = 0;
            for (int i = 0; i < 25; i++)
            {
                string name = _machineStates[i].Name;
                int valuemaint, valuepro;
                Control.plc.GetDevice(_machineStates[i].AddressMaint, out valuemaint);
                Control.plc.GetDevice(_machineStates[i].AddressPro, out valuepro);
                if (valuemaint == 1 || valuepro == 1)
                {
                    if (_repoHistoryMachineError.Contains(i))
                    {
                        _groupBoxes[i].Visible = true;
                        UpdateColor(i,name,valuemaint,valuepro);
                        countVisible++;
                        continue;
                    }
                    else
                    {
                        _groupBoxes[i] = CreateGroupBox(name, valuemaint, valuepro);
                        tableLayoutPanel1.Controls.Add(_groupBoxes[i]);
                        _repoHistoryMachineError.Add(i);
                        countVisible++;
                    }
                }
                else
                {
                    if (_repoHistoryMachineError.Contains(i))
                    {
                        _groupBoxes[i].Visible = false;
                    }
                }
            }
            if (countVisible > 6)
            {
                tableLayoutPanel1.AutoScroll = true;
                tableLayoutPanel1.RowStyles[0].SizeType = SizeType.Absolute;
                tableLayoutPanel1.RowStyles[1].SizeType = SizeType.Absolute;
                _timer.Start();
            }
            else
            {
                tableLayoutPanel1.AutoScroll=false;
                tableLayoutPanel1.RowStyles[0].SizeType = SizeType.Percent;
                tableLayoutPanel1.RowStyles[1].SizeType = SizeType.Percent;
                _timer.Stop();
            }
        }

        private GroupBox CreateGroupBox(string name,int valuemaint,  int valuepro)
        {
            GroupBox groupBox = new GroupBox();
            groupBox.Name = "Flow" + name;
            groupBox.Size = new Size(400, 364);
            //groupBox.Dock = DockStyle.Fill;

            BunifuThinButton2 button = new BunifuThinButton2();
            button.ButtonText = name;
            button.AutoSize = true;
            button.Name = "Button" + name;
            button.Dock = DockStyle.Fill;
            button.Font = new Font("Century", 75, FontStyle.Bold);
            button.Size = new Size(400, 364);
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
        #endregion

        #region event

        private void Timer2_Tick(object sender,EventArgs e)
        {
            ShowListMachineError();
        }

        private void ScrollTimer_Tick(object sender, EventArgs e)
        {
            var max = tableLayoutPanel1.VerticalScroll.Maximum - tableLayoutPanel1.VerticalScroll.LargeChange;
            var scrollPosition = tableLayoutPanel1.VerticalScroll.Value;
            if (_scrollDown)
            {
                tableLayoutPanel1.VerticalScroll.Value = scrollPosition + STEP_SIZE;
                if (tableLayoutPanel1.VerticalScroll.Value >= max)
                    _scrollDown = false;
            }
            else
            {
                tableLayoutPanel1.VerticalScroll.Value = scrollPosition - STEP_SIZE < 0 ? 0: scrollPosition - STEP_SIZE;
                if (tableLayoutPanel1.VerticalScroll.Value == 0)
                    _scrollDown = true;
            }
        }

        private void DisplayScreen_Load(object sender, EventArgs e)
        {

        }

        private void DisplayScreen_Closing(object sender, FormClosingEventArgs e)
        {
            tableLayoutPanel1.Controls.Clear();
        }
        #endregion


    }
}

