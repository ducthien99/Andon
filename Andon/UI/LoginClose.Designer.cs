namespace Andon.UI
{
    partial class LoginClose
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginClose));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.CheckBoxShowPass = new Bunifu.Framework.UI.BunifuCheckbox();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.TextboxPass = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.TextboxUser = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.ButtonLogin = new Bunifu.Framework.UI.BunifuThinButton2();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel10);
            this.panel1.Controls.Add(this.panel9);
            this.panel1.Controls.Add(this.panel8);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(584, 362);
            this.panel1.TabIndex = 11;
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.CheckBoxShowPass);
            this.panel10.Controls.Add(this.bunifuCustomLabel3);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel10.Location = new System.Drawing.Point(50, 248);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(484, 48);
            this.panel10.TabIndex = 29;
            // 
            // CheckBoxShowPass
            // 
            this.CheckBoxShowPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.CheckBoxShowPass.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.CheckBoxShowPass.Checked = false;
            this.CheckBoxShowPass.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.CheckBoxShowPass.ForeColor = System.Drawing.Color.White;
            this.CheckBoxShowPass.Location = new System.Drawing.Point(39, 16);
            this.CheckBoxShowPass.Name = "CheckBoxShowPass";
            this.CheckBoxShowPass.Size = new System.Drawing.Size(20, 20);
            this.CheckBoxShowPass.TabIndex = 13;
            this.CheckBoxShowPass.OnChange += new System.EventHandler(this.CheckBoxShowPass_OnChange);
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(65, 16);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(83, 16);
            this.bunifuCustomLabel3.TabIndex = 14;
            this.bunifuCustomLabel3.Text = "Show/Hide ";
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.TextboxPass);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel9.Location = new System.Drawing.Point(50, 210);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(484, 38);
            this.panel9.TabIndex = 28;
            // 
            // TextboxPass
            // 
            this.TextboxPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextboxPass.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TextboxPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TextboxPass.HintForeColor = System.Drawing.Color.Empty;
            this.TextboxPass.HintText = "Password";
            this.TextboxPass.isPassword = true;
            this.TextboxPass.LineFocusedColor = System.Drawing.Color.Blue;
            this.TextboxPass.LineIdleColor = System.Drawing.Color.Gray;
            this.TextboxPass.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.TextboxPass.LineThickness = 3;
            this.TextboxPass.Location = new System.Drawing.Point(19, 4);
            this.TextboxPass.Margin = new System.Windows.Forms.Padding(4);
            this.TextboxPass.Name = "TextboxPass";
            this.TextboxPass.Size = new System.Drawing.Size(437, 30);
            this.TextboxPass.TabIndex = 16;
            this.TextboxPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TextboxPass.OnValueChanged += new System.EventHandler(this.OnValueChanged);
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.TextboxUser);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(50, 156);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(484, 54);
            this.panel8.TabIndex = 24;
            // 
            // TextboxUser
            // 
            this.TextboxUser.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextboxUser.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TextboxUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TextboxUser.HintForeColor = System.Drawing.Color.Empty;
            this.TextboxUser.HintText = "Username";
            this.TextboxUser.isPassword = false;
            this.TextboxUser.LineFocusedColor = System.Drawing.Color.Blue;
            this.TextboxUser.LineIdleColor = System.Drawing.Color.Gray;
            this.TextboxUser.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.TextboxUser.LineThickness = 3;
            this.TextboxUser.Location = new System.Drawing.Point(19, 6);
            this.TextboxUser.Margin = new System.Windows.Forms.Padding(4);
            this.TextboxUser.Name = "TextboxUser";
            this.TextboxUser.Size = new System.Drawing.Size(437, 30);
            this.TextboxUser.TabIndex = 22;
            this.TextboxUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.pictureBox1);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(50, 11);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(484, 145);
            this.panel6.TabIndex = 27;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Andon.Properties.Resources.login_user_icon;
            this.pictureBox1.Location = new System.Drawing.Point(149, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(168, 133);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.ButtonLogin);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(50, 300);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(484, 62);
            this.panel5.TabIndex = 21;
            // 
            // ButtonLogin
            // 
            this.ButtonLogin.ActiveBorderThickness = 1;
            this.ButtonLogin.ActiveCornerRadius = 20;
            this.ButtonLogin.ActiveFillColor = System.Drawing.Color.Blue;
            this.ButtonLogin.ActiveForecolor = System.Drawing.Color.White;
            this.ButtonLogin.ActiveLineColor = System.Drawing.Color.Blue;
            this.ButtonLogin.BackColor = System.Drawing.Color.LightBlue;
            this.ButtonLogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ButtonLogin.BackgroundImage")));
            this.ButtonLogin.ButtonText = "LOGIN";
            this.ButtonLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonLogin.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonLogin.ForeColor = System.Drawing.Color.White;
            this.ButtonLogin.IdleBorderThickness = 1;
            this.ButtonLogin.IdleCornerRadius = 20;
            this.ButtonLogin.IdleFillColor = System.Drawing.Color.Blue;
            this.ButtonLogin.IdleForecolor = System.Drawing.Color.White;
            this.ButtonLogin.IdleLineColor = System.Drawing.Color.Blue;
            this.ButtonLogin.Location = new System.Drawing.Point(82, 5);
            this.ButtonLogin.Margin = new System.Windows.Forms.Padding(5);
            this.ButtonLogin.Name = "ButtonLogin";
            this.ButtonLogin.Size = new System.Drawing.Size(306, 52);
            this.ButtonLogin.TabIndex = 10;
            this.ButtonLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ButtonLogin.Click += new System.EventHandler(this.ButtonLogin_Click);
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(534, 11);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(50, 351);
            this.panel4.TabIndex = 20;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 11);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(50, 351);
            this.panel3.TabIndex = 19;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(584, 11);
            this.panel2.TabIndex = 0;
            // 
            // LoginClose
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(584, 362);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginClose";
            this.Text = "LoginClose";
            this.panel1.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel10;
        private Bunifu.Framework.UI.BunifuCheckbox CheckBoxShowPass;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private System.Windows.Forms.Panel panel9;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TextboxPass;
        private System.Windows.Forms.Panel panel8;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TextboxUser;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel5;
        private Bunifu.Framework.UI.BunifuThinButton2 ButtonLogin;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
    }
}