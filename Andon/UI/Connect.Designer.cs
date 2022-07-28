namespace Andon.UI
{
    partial class Connect
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Connect));
            this.Timer1 = new System.Windows.Forms.Timer(this.components);
            this.LableTypeCPU = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ButtonRecord = new Bunifu.Framework.UI.BunifuThinButton2();
            this.ButtonHorn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.LableCPUname = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lable_status_connect = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.ButtonDisconnect = new Bunifu.Framework.UI.BunifuThinButton2();
            this.panel10 = new System.Windows.Forms.Panel();
            this.ButtonConnect = new Bunifu.Framework.UI.BunifuThinButton2();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Timer1
            // 
            this.Timer1.Enabled = true;
            this.Timer1.Interval = 500;
            this.Timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // LableTypeCPU
            // 
            this.LableTypeCPU.BackColor = System.Drawing.Color.Transparent;
            this.LableTypeCPU.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LableTypeCPU.ForeColor = System.Drawing.Color.Blue;
            this.LableTypeCPU.Location = new System.Drawing.Point(125, 94);
            this.LableTypeCPU.Name = "LableTypeCPU";
            this.LableTypeCPU.Size = new System.Drawing.Size(159, 37);
            this.LableTypeCPU.TabIndex = 4;
            this.LableTypeCPU.Text = "bunifuCustomLabel2";
            this.LableTypeCPU.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel6
            // 
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(295, 547);
            this.panel6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1211, 302);
            this.panel6.TabIndex = 5;
            // 
            // panel5
            // 
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(295, 0);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1211, 89);
            this.panel5.TabIndex = 4;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(1506, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(93, 849);
            this.panel4.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.ButtonRecord);
            this.panel3.Controls.Add(this.ButtonHorn);
            this.panel3.Controls.Add(this.LableTypeCPU);
            this.panel3.Controls.Add(this.LableCPUname);
            this.panel3.Controls.Add(this.lable_status_connect);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(295, 849);
            this.panel3.TabIndex = 2;
            // 
            // ButtonRecord
            // 
            this.ButtonRecord.ActiveBorderThickness = 1;
            this.ButtonRecord.ActiveCornerRadius = 20;
            this.ButtonRecord.ActiveFillColor = System.Drawing.Color.White;
            this.ButtonRecord.ActiveForecolor = System.Drawing.Color.Lime;
            this.ButtonRecord.ActiveLineColor = System.Drawing.Color.Lime;
            this.ButtonRecord.AutoSize = true;
            this.ButtonRecord.BackColor = System.Drawing.SystemColors.Control;
            this.ButtonRecord.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ButtonRecord.BackgroundImage")));
            this.ButtonRecord.ButtonText = "RECORD";
            this.ButtonRecord.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonRecord.Font = new System.Drawing.Font("Century Schoolbook", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonRecord.ForeColor = System.Drawing.Color.White;
            this.ButtonRecord.IdleBorderThickness = 1;
            this.ButtonRecord.IdleCornerRadius = 20;
            this.ButtonRecord.IdleFillColor = System.Drawing.Color.Red;
            this.ButtonRecord.IdleForecolor = System.Drawing.Color.White;
            this.ButtonRecord.IdleLineColor = System.Drawing.Color.White;
            this.ButtonRecord.Location = new System.Drawing.Point(13, 348);
            this.ButtonRecord.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ButtonRecord.Name = "ButtonRecord";
            this.ButtonRecord.Size = new System.Drawing.Size(259, 60);
            this.ButtonRecord.TabIndex = 11;
            this.ButtonRecord.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ButtonRecord.Click += new System.EventHandler(this.ButtonRecord_Click);
            // 
            // ButtonHorn
            // 
            this.ButtonHorn.ActiveBorderThickness = 1;
            this.ButtonHorn.ActiveCornerRadius = 20;
            this.ButtonHorn.ActiveFillColor = System.Drawing.Color.White;
            this.ButtonHorn.ActiveForecolor = System.Drawing.Color.Lime;
            this.ButtonHorn.ActiveLineColor = System.Drawing.Color.Lime;
            this.ButtonHorn.AutoSize = true;
            this.ButtonHorn.BackColor = System.Drawing.SystemColors.Control;
            this.ButtonHorn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ButtonHorn.BackgroundImage")));
            this.ButtonHorn.ButtonText = "HORN";
            this.ButtonHorn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonHorn.Font = new System.Drawing.Font("Century Schoolbook", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonHorn.ForeColor = System.Drawing.Color.White;
            this.ButtonHorn.IdleBorderThickness = 1;
            this.ButtonHorn.IdleCornerRadius = 20;
            this.ButtonHorn.IdleFillColor = System.Drawing.Color.Red;
            this.ButtonHorn.IdleForecolor = System.Drawing.Color.White;
            this.ButtonHorn.IdleLineColor = System.Drawing.Color.White;
            this.ButtonHorn.Location = new System.Drawing.Point(13, 233);
            this.ButtonHorn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ButtonHorn.Name = "ButtonHorn";
            this.ButtonHorn.Size = new System.Drawing.Size(259, 60);
            this.ButtonHorn.TabIndex = 10;
            this.ButtonHorn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ButtonHorn.Click += new System.EventHandler(this.ButtonHorn_Click);
            // 
            // LableCPUname
            // 
            this.LableCPUname.Dock = System.Windows.Forms.DockStyle.Top;
            this.LableCPUname.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LableCPUname.ForeColor = System.Drawing.Color.Blue;
            this.LableCPUname.Location = new System.Drawing.Point(0, 85);
            this.LableCPUname.Name = "LableCPUname";
            this.LableCPUname.Size = new System.Drawing.Size(293, 46);
            this.LableCPUname.TabIndex = 2;
            this.LableCPUname.Text = "CPU NAME:";
            this.LableCPUname.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lable_status_connect
            // 
            this.lable_status_connect.Dock = System.Windows.Forms.DockStyle.Top;
            this.lable_status_connect.Font = new System.Drawing.Font("Century Schoolbook", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lable_status_connect.ForeColor = System.Drawing.Color.Lime;
            this.lable_status_connect.Location = new System.Drawing.Point(0, 0);
            this.lable_status_connect.Name = "lable_status_connect";
            this.lable_status_connect.Size = new System.Drawing.Size(293, 85);
            this.lable_status_connect.TabIndex = 0;
            this.lable_status_connect.Text = "Connected Success!";
            this.lable_status_connect.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Palatino Linotype", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(0, 0);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(1211, 86);
            this.bunifuCustomLabel3.TabIndex = 5;
            this.bunifuCustomLabel3.Text = "Connection PLC ";
            this.bunifuCustomLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.bunifuCustomLabel3);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1211, 86);
            this.panel7.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel8);
            this.panel2.Controls.Add(this.panel7);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(295, 89);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1211, 458);
            this.panel2.TabIndex = 6;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.panel11);
            this.panel8.Controls.Add(this.panel10);
            this.panel8.Controls.Add(this.panel9);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(0, 86);
            this.panel8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(1211, 372);
            this.panel8.TabIndex = 5;
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.ButtonDisconnect);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel11.Location = new System.Drawing.Point(808, 119);
            this.panel11.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(403, 253);
            this.panel11.TabIndex = 2;
            // 
            // ButtonDisconnect
            // 
            this.ButtonDisconnect.ActiveBorderThickness = 1;
            this.ButtonDisconnect.ActiveCornerRadius = 20;
            this.ButtonDisconnect.ActiveFillColor = System.Drawing.Color.White;
            this.ButtonDisconnect.ActiveForecolor = System.Drawing.Color.Red;
            this.ButtonDisconnect.ActiveLineColor = System.Drawing.Color.Red;
            this.ButtonDisconnect.AutoSize = true;
            this.ButtonDisconnect.BackColor = System.Drawing.SystemColors.Control;
            this.ButtonDisconnect.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ButtonDisconnect.BackgroundImage")));
            this.ButtonDisconnect.ButtonText = "DISCONNECT";
            this.ButtonDisconnect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonDisconnect.Font = new System.Drawing.Font("Century Schoolbook", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonDisconnect.ForeColor = System.Drawing.Color.White;
            this.ButtonDisconnect.IdleBorderThickness = 1;
            this.ButtonDisconnect.IdleCornerRadius = 20;
            this.ButtonDisconnect.IdleFillColor = System.Drawing.Color.Red;
            this.ButtonDisconnect.IdleForecolor = System.Drawing.Color.White;
            this.ButtonDisconnect.IdleLineColor = System.Drawing.Color.White;
            this.ButtonDisconnect.Location = new System.Drawing.Point(140, 36);
            this.ButtonDisconnect.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ButtonDisconnect.Name = "ButtonDisconnect";
            this.ButtonDisconnect.Size = new System.Drawing.Size(259, 80);
            this.ButtonDisconnect.TabIndex = 11;
            this.ButtonDisconnect.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ButtonDisconnect.Click += new System.EventHandler(this.ButtonDisconnect_Click_1);
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.ButtonConnect);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel10.Location = new System.Drawing.Point(0, 119);
            this.panel10.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(419, 253);
            this.panel10.TabIndex = 1;
            // 
            // ButtonConnect
            // 
            this.ButtonConnect.ActiveBorderThickness = 1;
            this.ButtonConnect.ActiveCornerRadius = 20;
            this.ButtonConnect.ActiveFillColor = System.Drawing.Color.White;
            this.ButtonConnect.ActiveForecolor = System.Drawing.Color.Lime;
            this.ButtonConnect.ActiveLineColor = System.Drawing.Color.Lime;
            this.ButtonConnect.AutoSize = true;
            this.ButtonConnect.BackColor = System.Drawing.SystemColors.Control;
            this.ButtonConnect.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ButtonConnect.BackgroundImage")));
            this.ButtonConnect.ButtonText = "CONNECTION";
            this.ButtonConnect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonConnect.Font = new System.Drawing.Font("Century Schoolbook", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonConnect.ForeColor = System.Drawing.Color.White;
            this.ButtonConnect.IdleBorderThickness = 1;
            this.ButtonConnect.IdleCornerRadius = 20;
            this.ButtonConnect.IdleFillColor = System.Drawing.Color.Lime;
            this.ButtonConnect.IdleForecolor = System.Drawing.Color.White;
            this.ButtonConnect.IdleLineColor = System.Drawing.Color.White;
            this.ButtonConnect.Location = new System.Drawing.Point(115, 36);
            this.ButtonConnect.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ButtonConnect.Name = "ButtonConnect";
            this.ButtonConnect.Size = new System.Drawing.Size(259, 80);
            this.ButtonConnect.TabIndex = 12;
            this.ButtonConnect.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ButtonConnect.Click += new System.EventHandler(this.ButtonConnect_Click_1);
            // 
            // panel9
            // 
            this.panel9.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel9.Location = new System.Drawing.Point(0, 0);
            this.panel9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(1211, 119);
            this.panel9.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1599, 849);
            this.panel1.TabIndex = 1;
            // 
            // Connect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1599, 849);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Connect";
            this.Text = "Connect";
            this.Load += new System.EventHandler(this.Connect_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer Timer1;
        private Bunifu.Framework.UI.BunifuCustomLabel LableTypeCPU;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private Bunifu.Framework.UI.BunifuCustomLabel LableCPUname;
        private Bunifu.Framework.UI.BunifuCustomLabel lable_status_connect;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuThinButton2 ButtonHorn;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel11;
        private Bunifu.Framework.UI.BunifuThinButton2 ButtonDisconnect;
        private System.Windows.Forms.Panel panel10;
        private Bunifu.Framework.UI.BunifuThinButton2 ButtonConnect;
        private Bunifu.Framework.UI.BunifuThinButton2 ButtonRecord;
    }
}