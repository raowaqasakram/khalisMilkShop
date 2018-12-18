namespace khalisMilkShop
{
    partial class AdminForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.PasswordButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.LogOutButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.AboutUSButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.CheckRecordButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.UpdateRateButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.AddRecordButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.MainMenuWelcomepanel = new System.Windows.Forms.Panel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(34)))), ((int)(((byte)(55)))));
            this.panel1.Controls.Add(this.PasswordButton);
            this.panel1.Controls.Add(this.LogOutButton);
            this.panel1.Controls.Add(this.AboutUSButton);
            this.panel1.Controls.Add(this.CheckRecordButton);
            this.panel1.Controls.Add(this.UpdateRateButton);
            this.panel1.Controls.Add(this.AddRecordButton);
            this.panel1.Location = new System.Drawing.Point(-2, -9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(199, 502);
            this.panel1.TabIndex = 0;
            // 
            // PasswordButton
            // 
            this.PasswordButton.Activecolor = System.Drawing.Color.White;
            this.PasswordButton.BackColor = System.Drawing.Color.Transparent;
            this.PasswordButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PasswordButton.BorderRadius = 3;
            this.PasswordButton.ButtonText = "  Reset Password";
            this.PasswordButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PasswordButton.DisabledColor = System.Drawing.Color.Gray;
            this.PasswordButton.ForeColor = System.Drawing.Color.Transparent;
            this.PasswordButton.Iconcolor = System.Drawing.Color.Transparent;
            this.PasswordButton.Iconimage = ((System.Drawing.Image)(resources.GetObject("PasswordButton.Iconimage")));
            this.PasswordButton.Iconimage_right = null;
            this.PasswordButton.Iconimage_right_Selected = null;
            this.PasswordButton.Iconimage_Selected = null;
            this.PasswordButton.IconMarginLeft = 0;
            this.PasswordButton.IconMarginRight = 0;
            this.PasswordButton.IconRightVisible = true;
            this.PasswordButton.IconRightZoom = 0D;
            this.PasswordButton.IconVisible = true;
            this.PasswordButton.IconZoom = 90D;
            this.PasswordButton.IsTab = false;
            this.PasswordButton.Location = new System.Drawing.Point(6, 269);
            this.PasswordButton.Name = "PasswordButton";
            this.PasswordButton.Normalcolor = System.Drawing.Color.Transparent;
            this.PasswordButton.OnHovercolor = System.Drawing.Color.White;
            this.PasswordButton.OnHoverTextColor = System.Drawing.Color.Black;
            this.PasswordButton.selected = false;
            this.PasswordButton.Size = new System.Drawing.Size(193, 48);
            this.PasswordButton.TabIndex = 5;
            this.PasswordButton.Text = "  Reset Password";
            this.PasswordButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PasswordButton.Textcolor = System.Drawing.Color.White;
            this.PasswordButton.TextFont = new System.Drawing.Font("Times New Roman", 11F);
            this.PasswordButton.Click += new System.EventHandler(this.PasswordButton_Click);
            // 
            // LogOutButton
            // 
            this.LogOutButton.Activecolor = System.Drawing.Color.White;
            this.LogOutButton.BackColor = System.Drawing.Color.Transparent;
            this.LogOutButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LogOutButton.BorderRadius = 3;
            this.LogOutButton.ButtonText = "        Log Out";
            this.LogOutButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogOutButton.DisabledColor = System.Drawing.Color.Gray;
            this.LogOutButton.ForeColor = System.Drawing.Color.Transparent;
            this.LogOutButton.Iconcolor = System.Drawing.Color.Transparent;
            this.LogOutButton.Iconimage = ((System.Drawing.Image)(resources.GetObject("LogOutButton.Iconimage")));
            this.LogOutButton.Iconimage_right = null;
            this.LogOutButton.Iconimage_right_Selected = null;
            this.LogOutButton.Iconimage_Selected = null;
            this.LogOutButton.IconMarginLeft = 0;
            this.LogOutButton.IconMarginRight = 0;
            this.LogOutButton.IconRightVisible = true;
            this.LogOutButton.IconRightZoom = 0D;
            this.LogOutButton.IconVisible = true;
            this.LogOutButton.IconZoom = 90D;
            this.LogOutButton.IsTab = false;
            this.LogOutButton.Location = new System.Drawing.Point(3, 421);
            this.LogOutButton.Name = "LogOutButton";
            this.LogOutButton.Normalcolor = System.Drawing.Color.Transparent;
            this.LogOutButton.OnHovercolor = System.Drawing.Color.White;
            this.LogOutButton.OnHoverTextColor = System.Drawing.Color.Black;
            this.LogOutButton.selected = false;
            this.LogOutButton.Size = new System.Drawing.Size(193, 48);
            this.LogOutButton.TabIndex = 6;
            this.LogOutButton.Text = "        Log Out";
            this.LogOutButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LogOutButton.Textcolor = System.Drawing.Color.White;
            this.LogOutButton.TextFont = new System.Drawing.Font("Times New Roman", 11F);
            this.LogOutButton.Click += new System.EventHandler(this.LogOutButton_Click);
            // 
            // AboutUSButton
            // 
            this.AboutUSButton.Activecolor = System.Drawing.Color.White;
            this.AboutUSButton.BackColor = System.Drawing.Color.Transparent;
            this.AboutUSButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AboutUSButton.BorderRadius = 3;
            this.AboutUSButton.ButtonText = "      Developer";
            this.AboutUSButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AboutUSButton.DisabledColor = System.Drawing.Color.Gray;
            this.AboutUSButton.ForeColor = System.Drawing.Color.Transparent;
            this.AboutUSButton.Iconcolor = System.Drawing.Color.Transparent;
            this.AboutUSButton.Iconimage = ((System.Drawing.Image)(resources.GetObject("AboutUSButton.Iconimage")));
            this.AboutUSButton.Iconimage_right = null;
            this.AboutUSButton.Iconimage_right_Selected = null;
            this.AboutUSButton.Iconimage_Selected = null;
            this.AboutUSButton.IconMarginLeft = 0;
            this.AboutUSButton.IconMarginRight = 0;
            this.AboutUSButton.IconRightVisible = true;
            this.AboutUSButton.IconRightZoom = 0D;
            this.AboutUSButton.IconVisible = true;
            this.AboutUSButton.IconZoom = 90D;
            this.AboutUSButton.IsTab = false;
            this.AboutUSButton.Location = new System.Drawing.Point(6, 352);
            this.AboutUSButton.Name = "AboutUSButton";
            this.AboutUSButton.Normalcolor = System.Drawing.Color.Transparent;
            this.AboutUSButton.OnHovercolor = System.Drawing.Color.White;
            this.AboutUSButton.OnHoverTextColor = System.Drawing.Color.Black;
            this.AboutUSButton.selected = false;
            this.AboutUSButton.Size = new System.Drawing.Size(193, 48);
            this.AboutUSButton.TabIndex = 4;
            this.AboutUSButton.Text = "      Developer";
            this.AboutUSButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AboutUSButton.Textcolor = System.Drawing.Color.White;
            this.AboutUSButton.TextFont = new System.Drawing.Font("Times New Roman", 11F);
            this.AboutUSButton.Click += new System.EventHandler(this.AboutUSButton_Click);
            // 
            // CheckRecordButton
            // 
            this.CheckRecordButton.Activecolor = System.Drawing.Color.White;
            this.CheckRecordButton.BackColor = System.Drawing.Color.Transparent;
            this.CheckRecordButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CheckRecordButton.BorderRadius = 3;
            this.CheckRecordButton.ButtonText = "     Members Area";
            this.CheckRecordButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CheckRecordButton.DisabledColor = System.Drawing.Color.Gray;
            this.CheckRecordButton.ForeColor = System.Drawing.Color.Transparent;
            this.CheckRecordButton.Iconcolor = System.Drawing.Color.Transparent;
            this.CheckRecordButton.Iconimage = ((System.Drawing.Image)(resources.GetObject("CheckRecordButton.Iconimage")));
            this.CheckRecordButton.Iconimage_right = null;
            this.CheckRecordButton.Iconimage_right_Selected = null;
            this.CheckRecordButton.Iconimage_Selected = null;
            this.CheckRecordButton.IconMarginLeft = 0;
            this.CheckRecordButton.IconMarginRight = 0;
            this.CheckRecordButton.IconRightVisible = true;
            this.CheckRecordButton.IconRightZoom = 0D;
            this.CheckRecordButton.IconVisible = true;
            this.CheckRecordButton.IconZoom = 90D;
            this.CheckRecordButton.IsTab = false;
            this.CheckRecordButton.Location = new System.Drawing.Point(3, 191);
            this.CheckRecordButton.Name = "CheckRecordButton";
            this.CheckRecordButton.Normalcolor = System.Drawing.Color.Transparent;
            this.CheckRecordButton.OnHovercolor = System.Drawing.Color.White;
            this.CheckRecordButton.OnHoverTextColor = System.Drawing.Color.Black;
            this.CheckRecordButton.selected = false;
            this.CheckRecordButton.Size = new System.Drawing.Size(193, 48);
            this.CheckRecordButton.TabIndex = 3;
            this.CheckRecordButton.Text = "     Members Area";
            this.CheckRecordButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CheckRecordButton.Textcolor = System.Drawing.Color.White;
            this.CheckRecordButton.TextFont = new System.Drawing.Font("Times New Roman", 11F);
            this.CheckRecordButton.Click += new System.EventHandler(this.CheckRecordButton_Click);
            // 
            // UpdateRateButton
            // 
            this.UpdateRateButton.Activecolor = System.Drawing.Color.White;
            this.UpdateRateButton.BackColor = System.Drawing.Color.Transparent;
            this.UpdateRateButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.UpdateRateButton.BorderRadius = 3;
            this.UpdateRateButton.ButtonText = "       Update Rate";
            this.UpdateRateButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UpdateRateButton.DisabledColor = System.Drawing.Color.Gray;
            this.UpdateRateButton.ForeColor = System.Drawing.Color.Transparent;
            this.UpdateRateButton.Iconcolor = System.Drawing.Color.Transparent;
            this.UpdateRateButton.Iconimage = ((System.Drawing.Image)(resources.GetObject("UpdateRateButton.Iconimage")));
            this.UpdateRateButton.Iconimage_right = null;
            this.UpdateRateButton.Iconimage_right_Selected = null;
            this.UpdateRateButton.Iconimage_Selected = null;
            this.UpdateRateButton.IconMarginLeft = 0;
            this.UpdateRateButton.IconMarginRight = 0;
            this.UpdateRateButton.IconRightVisible = true;
            this.UpdateRateButton.IconRightZoom = 0D;
            this.UpdateRateButton.IconVisible = true;
            this.UpdateRateButton.IconZoom = 90D;
            this.UpdateRateButton.IsTab = false;
            this.UpdateRateButton.Location = new System.Drawing.Point(0, 117);
            this.UpdateRateButton.Name = "UpdateRateButton";
            this.UpdateRateButton.Normalcolor = System.Drawing.Color.Transparent;
            this.UpdateRateButton.OnHovercolor = System.Drawing.Color.White;
            this.UpdateRateButton.OnHoverTextColor = System.Drawing.Color.Black;
            this.UpdateRateButton.selected = false;
            this.UpdateRateButton.Size = new System.Drawing.Size(193, 48);
            this.UpdateRateButton.TabIndex = 2;
            this.UpdateRateButton.Text = "       Update Rate";
            this.UpdateRateButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.UpdateRateButton.Textcolor = System.Drawing.Color.White;
            this.UpdateRateButton.TextFont = new System.Drawing.Font("Times New Roman", 11F);
            this.UpdateRateButton.Click += new System.EventHandler(this.UpdateRateButton_Click);
            // 
            // AddRecordButton
            // 
            this.AddRecordButton.Activecolor = System.Drawing.Color.White;
            this.AddRecordButton.BackColor = System.Drawing.Color.Transparent;
            this.AddRecordButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AddRecordButton.BorderRadius = 3;
            this.AddRecordButton.ButtonText = "      Add Record";
            this.AddRecordButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddRecordButton.DisabledColor = System.Drawing.Color.Gray;
            this.AddRecordButton.ForeColor = System.Drawing.Color.Transparent;
            this.AddRecordButton.Iconcolor = System.Drawing.Color.Transparent;
            this.AddRecordButton.Iconimage = ((System.Drawing.Image)(resources.GetObject("AddRecordButton.Iconimage")));
            this.AddRecordButton.Iconimage_right = null;
            this.AddRecordButton.Iconimage_right_Selected = null;
            this.AddRecordButton.Iconimage_Selected = null;
            this.AddRecordButton.IconMarginLeft = 0;
            this.AddRecordButton.IconMarginRight = 0;
            this.AddRecordButton.IconRightVisible = true;
            this.AddRecordButton.IconRightZoom = 0D;
            this.AddRecordButton.IconVisible = true;
            this.AddRecordButton.IconZoom = 90D;
            this.AddRecordButton.IsTab = false;
            this.AddRecordButton.Location = new System.Drawing.Point(3, 48);
            this.AddRecordButton.Name = "AddRecordButton";
            this.AddRecordButton.Normalcolor = System.Drawing.Color.Transparent;
            this.AddRecordButton.OnHovercolor = System.Drawing.Color.White;
            this.AddRecordButton.OnHoverTextColor = System.Drawing.Color.Black;
            this.AddRecordButton.selected = false;
            this.AddRecordButton.Size = new System.Drawing.Size(193, 48);
            this.AddRecordButton.TabIndex = 1;
            this.AddRecordButton.Text = "      Add Record";
            this.AddRecordButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddRecordButton.Textcolor = System.Drawing.Color.White;
            this.AddRecordButton.TextFont = new System.Drawing.Font("Times New Roman", 11F);
            this.AddRecordButton.Click += new System.EventHandler(this.AddRecordButton_Click);
            // 
            // MainMenuWelcomepanel
            // 
            this.MainMenuWelcomepanel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.MainMenuWelcomepanel.BackColor = System.Drawing.Color.White;
            this.MainMenuWelcomepanel.ForeColor = System.Drawing.Color.Transparent;
            this.MainMenuWelcomepanel.Location = new System.Drawing.Point(197, 0);
            this.MainMenuWelcomepanel.Name = "MainMenuWelcomepanel";
            this.MainMenuWelcomepanel.Size = new System.Drawing.Size(858, 493);
            this.MainMenuWelcomepanel.TabIndex = 1;
            // 
            // AdminForm
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.Sound;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1056, 490);
            this.Controls.Add(this.MainMenuWelcomepanel);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminForm";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel MainMenuWelcomepanel;
        private Bunifu.Framework.UI.BunifuFlatButton AddRecordButton;
        private Bunifu.Framework.UI.BunifuFlatButton UpdateRateButton;
        private Bunifu.Framework.UI.BunifuFlatButton CheckRecordButton;
        private Bunifu.Framework.UI.BunifuFlatButton AboutUSButton;
        private Bunifu.Framework.UI.BunifuFlatButton LogOutButton;
        private Bunifu.Framework.UI.BunifuFlatButton PasswordButton;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}