namespace Andon.UI
{
    partial class MAIN
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
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MAIN));
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.ButtonMenu = new Bunifu.Framework.UI.BunifuImageButton();
            this.ButtonHideForm = new System.Windows.Forms.Button();
            this.ButtonMaximumForm = new System.Windows.Forms.Button();
            this.ButtonCloseForm = new System.Windows.Forms.Button();
            this.Transition1 = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.ButtonHome = new Bunifu.Framework.UI.BunifuFlatButton();
            this.ButtonConnect = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.Timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.Timer3 = new System.Windows.Forms.Timer(this.components);
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonMenu)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.bunifuCustomLabel2);
            this.panel1.Controls.Add(this.ButtonMenu);
            this.panel1.Controls.Add(this.ButtonHideForm);
            this.panel1.Controls.Add(this.ButtonMaximumForm);
            this.panel1.Controls.Add(this.ButtonCloseForm);
            this.Transition1.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1302, 39);
            this.panel1.TabIndex = 6;
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Panel1_MouseMove);
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.Transition1.SetDecoration(this.bunifuCustomLabel2, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Centaur", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(45, 7);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(264, 27);
            this.bunifuCustomLabel2.TabIndex = 7;
            this.bunifuCustomLabel2.Text = "ANDON SYSTEM V2.0";
            // 
            // ButtonMenu
            // 
            this.ButtonMenu.BackColor = System.Drawing.Color.Transparent;
            this.Transition1.SetDecoration(this.ButtonMenu, BunifuAnimatorNS.DecorationType.None);
            this.ButtonMenu.Image = global::Andon.Properties.Resources.menu_icon_icons_com_69502;
            this.ButtonMenu.ImageActive = null;
            this.ButtonMenu.Location = new System.Drawing.Point(5, 4);
            this.ButtonMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButtonMenu.Name = "ButtonMenu";
            this.ButtonMenu.Size = new System.Drawing.Size(33, 31);
            this.ButtonMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ButtonMenu.TabIndex = 1;
            this.ButtonMenu.TabStop = false;
            this.ButtonMenu.Zoom = 10;
            this.ButtonMenu.Click += new System.EventHandler(this.ButtonMenu_Click_1);
            // 
            // ButtonHideForm
            // 
            this.ButtonHideForm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Transition1.SetDecoration(this.ButtonHideForm, BunifuAnimatorNS.DecorationType.None);
            this.ButtonHideForm.Font = new System.Drawing.Font(".VnArial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonHideForm.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ButtonHideForm.Location = new System.Drawing.Point(1193, 5);
            this.ButtonHideForm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButtonHideForm.Name = "ButtonHideForm";
            this.ButtonHideForm.Size = new System.Drawing.Size(32, 32);
            this.ButtonHideForm.TabIndex = 4;
            this.ButtonHideForm.Text = "_";
            this.ButtonHideForm.UseVisualStyleBackColor = true;
            this.ButtonHideForm.Visible = false;
            this.ButtonHideForm.Click += new System.EventHandler(this.ButtonHideForm_Click);
            // 
            // ButtonMaximumForm
            // 
            this.ButtonMaximumForm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Transition1.SetDecoration(this.ButtonMaximumForm, BunifuAnimatorNS.DecorationType.None);
            this.ButtonMaximumForm.Font = new System.Drawing.Font("Webdings", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.ButtonMaximumForm.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ButtonMaximumForm.Location = new System.Drawing.Point(1226, 5);
            this.ButtonMaximumForm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButtonMaximumForm.Name = "ButtonMaximumForm";
            this.ButtonMaximumForm.Size = new System.Drawing.Size(32, 32);
            this.ButtonMaximumForm.TabIndex = 2;
            this.ButtonMaximumForm.Text = "1";
            this.ButtonMaximumForm.UseVisualStyleBackColor = true;
            this.ButtonMaximumForm.Click += new System.EventHandler(this.ButtonMaximumForm_Click);
            // 
            // ButtonCloseForm
            // 
            this.ButtonCloseForm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Transition1.SetDecoration(this.ButtonCloseForm, BunifuAnimatorNS.DecorationType.None);
            this.ButtonCloseForm.Font = new System.Drawing.Font(".VnArial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonCloseForm.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ButtonCloseForm.Location = new System.Drawing.Point(1260, 5);
            this.ButtonCloseForm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButtonCloseForm.Name = "ButtonCloseForm";
            this.ButtonCloseForm.Size = new System.Drawing.Size(32, 32);
            this.ButtonCloseForm.TabIndex = 0;
            this.ButtonCloseForm.Text = "X";
            this.ButtonCloseForm.UseVisualStyleBackColor = true;
            this.ButtonCloseForm.Click += new System.EventHandler(this.ButtonCloseForm_Click);
            // 
            // Transition1
            // 
            this.Transition1.AnimationType = BunifuAnimatorNS.AnimationType.Mosaic;
            this.Transition1.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicSize = 20;
            animation1.Padding = new System.Windows.Forms.Padding(30);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.Transition1.DefaultAnimation = animation1;
            this.Transition1.Interval = 100;
            // 
            // ButtonHome
            // 
            this.ButtonHome.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(97)))), ((int)(((byte)(216)))));
            this.ButtonHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(32)))), ((int)(((byte)(41)))));
            this.ButtonHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ButtonHome.BorderRadius = 0;
            this.ButtonHome.ButtonText = "HOME";
            this.ButtonHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Transition1.SetDecoration(this.ButtonHome, BunifuAnimatorNS.DecorationType.None);
            this.ButtonHome.DisabledColor = System.Drawing.Color.Gray;
            this.ButtonHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.ButtonHome.Iconcolor = System.Drawing.Color.Transparent;
            this.ButtonHome.Iconimage = global::Andon.Properties.Resources.home;
            this.ButtonHome.Iconimage_right = null;
            this.ButtonHome.Iconimage_right_Selected = null;
            this.ButtonHome.Iconimage_Selected = null;
            this.ButtonHome.IconMarginLeft = 0;
            this.ButtonHome.IconMarginRight = 0;
            this.ButtonHome.IconRightVisible = true;
            this.ButtonHome.IconRightZoom = 0D;
            this.ButtonHome.IconVisible = true;
            this.ButtonHome.IconZoom = 50D;
            this.ButtonHome.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ButtonHome.IsTab = true;
            this.ButtonHome.Location = new System.Drawing.Point(0, 0);
            this.ButtonHome.Margin = new System.Windows.Forms.Padding(5);
            this.ButtonHome.Name = "ButtonHome";
            this.ButtonHome.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(32)))), ((int)(((byte)(41)))));
            this.ButtonHome.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(97)))), ((int)(((byte)(216)))));
            this.ButtonHome.OnHoverTextColor = System.Drawing.Color.White;
            this.ButtonHome.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ButtonHome.selected = false;
            this.ButtonHome.Size = new System.Drawing.Size(197, 39);
            this.ButtonHome.TabIndex = 9;
            this.ButtonHome.Text = "HOME";
            this.ButtonHome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ButtonHome.Textcolor = System.Drawing.Color.White;
            this.ButtonHome.TextFont = new System.Drawing.Font("Century Schoolbook", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonHome.Click += new System.EventHandler(this.ButtonHome_Click_1);
            // 
            // ButtonConnect
            // 
            this.ButtonConnect.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(97)))), ((int)(((byte)(216)))));
            this.ButtonConnect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(32)))), ((int)(((byte)(41)))));
            this.ButtonConnect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ButtonConnect.BorderRadius = 0;
            this.ButtonConnect.ButtonText = "CONNECT";
            this.ButtonConnect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Transition1.SetDecoration(this.ButtonConnect, BunifuAnimatorNS.DecorationType.None);
            this.ButtonConnect.DisabledColor = System.Drawing.Color.Gray;
            this.ButtonConnect.Dock = System.Windows.Forms.DockStyle.Top;
            this.ButtonConnect.Iconcolor = System.Drawing.Color.Transparent;
            this.ButtonConnect.Iconimage = global::Andon.Properties.Resources.chain;
            this.ButtonConnect.Iconimage_right = null;
            this.ButtonConnect.Iconimage_right_Selected = null;
            this.ButtonConnect.Iconimage_Selected = null;
            this.ButtonConnect.IconMarginLeft = 0;
            this.ButtonConnect.IconMarginRight = 0;
            this.ButtonConnect.IconRightVisible = true;
            this.ButtonConnect.IconRightZoom = 0D;
            this.ButtonConnect.IconVisible = true;
            this.ButtonConnect.IconZoom = 50D;
            this.ButtonConnect.IsTab = true;
            this.ButtonConnect.Location = new System.Drawing.Point(0, 39);
            this.ButtonConnect.Margin = new System.Windows.Forms.Padding(5);
            this.ButtonConnect.Name = "ButtonConnect";
            this.ButtonConnect.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(32)))), ((int)(((byte)(41)))));
            this.ButtonConnect.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(97)))), ((int)(((byte)(216)))));
            this.ButtonConnect.OnHoverTextColor = System.Drawing.Color.White;
            this.ButtonConnect.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ButtonConnect.selected = false;
            this.ButtonConnect.Size = new System.Drawing.Size(197, 39);
            this.ButtonConnect.TabIndex = 10;
            this.ButtonConnect.Text = "CONNECT";
            this.ButtonConnect.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ButtonConnect.Textcolor = System.Drawing.Color.White;
            this.ButtonConnect.TextFont = new System.Drawing.Font("Century Schoolbook", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonConnect.Click += new System.EventHandler(this.ButtonConnect_Click_2);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(32)))), ((int)(((byte)(41)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.ButtonConnect);
            this.panel2.Controls.Add(this.ButtonHome);
            this.Transition1.SetDecoration(this.panel2, BunifuAnimatorNS.DecorationType.None);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 39);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(199, 729);
            this.panel2.TabIndex = 12;
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            this.Transition1.SetDecoration(this.panelDesktop, BunifuAnimatorNS.DecorationType.None);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(199, 39);
            this.panelDesktop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(1103, 729);
            this.panelDesktop.TabIndex = 13;
            // 
            // Timer1
            // 
            this.Timer1.Enabled = true;
            this.Timer1.Interval = 1000;
            this.Timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // MAIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1302, 768);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Transition1.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MAIN";
            this.Text = "MAIN";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MaintClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonMenu)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ButtonHideForm;
        private System.Windows.Forms.Button ButtonMaximumForm;
        private System.Windows.Forms.Button ButtonCloseForm;
        private BunifuAnimatorNS.BunifuTransition Transition1;
        private System.Windows.Forms.Timer Timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer Timer3;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuImageButton ButtonMenu;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuFlatButton ButtonConnect;
        private Bunifu.Framework.UI.BunifuFlatButton ButtonHome;
        private System.Windows.Forms.Panel panelDesktop;
    }
}