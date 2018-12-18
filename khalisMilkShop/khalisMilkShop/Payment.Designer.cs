namespace khalisMilkShop
{
    partial class Payment
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.AmountNowPayingTextbox1 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuCustomLabel6 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.PaidAmount2MilkmanTextbox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.MilkmanTotalAmountTextbox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.CheckPaymentRecordfromDBButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.PaymentMemberNameTextbox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuCustomLabel7 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.UpdatePaymentRecordButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.SuspendLayout();
            // 
            // AmountNowPayingTextbox1
            // 
            this.AmountNowPayingTextbox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.AmountNowPayingTextbox1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.AmountNowPayingTextbox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.AmountNowPayingTextbox1.HintForeColor = System.Drawing.Color.Empty;
            this.AmountNowPayingTextbox1.HintText = "Pay Now";
            this.AmountNowPayingTextbox1.isPassword = false;
            this.AmountNowPayingTextbox1.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(34)))), ((int)(((byte)(55)))));
            this.AmountNowPayingTextbox1.LineIdleColor = System.Drawing.Color.Empty;
            this.AmountNowPayingTextbox1.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(34)))), ((int)(((byte)(55)))));
            this.AmountNowPayingTextbox1.LineThickness = 3;
            this.AmountNowPayingTextbox1.Location = new System.Drawing.Point(81, 154);
            this.AmountNowPayingTextbox1.Margin = new System.Windows.Forms.Padding(4);
            this.AmountNowPayingTextbox1.Name = "AmountNowPayingTextbox1";
            this.AmountNowPayingTextbox1.Size = new System.Drawing.Size(139, 29);
            this.AmountNowPayingTextbox1.TabIndex = 46;
            this.AmountNowPayingTextbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.AmountNowPayingTextbox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MilkmanTotalAmountTextbox_KeyPress);
            // 
            // bunifuCustomLabel6
            // 
            this.bunifuCustomLabel6.AutoSize = true;
            this.bunifuCustomLabel6.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel6.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.bunifuCustomLabel6.ForeColor = System.Drawing.Color.Black;
            this.bunifuCustomLabel6.Location = new System.Drawing.Point(12, 164);
            this.bunifuCustomLabel6.Name = "bunifuCustomLabel6";
            this.bunifuCustomLabel6.Size = new System.Drawing.Size(68, 19);
            this.bunifuCustomLabel6.TabIndex = 47;
            this.bunifuCustomLabel6.Text = "Payment :";
            // 
            // PaidAmount2MilkmanTextbox
            // 
            this.PaidAmount2MilkmanTextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PaidAmount2MilkmanTextbox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.PaidAmount2MilkmanTextbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PaidAmount2MilkmanTextbox.HintForeColor = System.Drawing.Color.Empty;
            this.PaidAmount2MilkmanTextbox.HintText = "";
            this.PaidAmount2MilkmanTextbox.isPassword = false;
            this.PaidAmount2MilkmanTextbox.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(34)))), ((int)(((byte)(55)))));
            this.PaidAmount2MilkmanTextbox.LineIdleColor = System.Drawing.Color.Empty;
            this.PaidAmount2MilkmanTextbox.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(34)))), ((int)(((byte)(55)))));
            this.PaidAmount2MilkmanTextbox.LineThickness = 3;
            this.PaidAmount2MilkmanTextbox.Location = new System.Drawing.Point(447, 154);
            this.PaidAmount2MilkmanTextbox.Margin = new System.Windows.Forms.Padding(4);
            this.PaidAmount2MilkmanTextbox.Name = "PaidAmount2MilkmanTextbox";
            this.PaidAmount2MilkmanTextbox.Size = new System.Drawing.Size(139, 29);
            this.PaidAmount2MilkmanTextbox.TabIndex = 44;
            this.PaidAmount2MilkmanTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.PaidAmount2MilkmanTextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MilkmanTotalAmountTextbox_KeyPress);
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.Black;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(343, 164);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(43, 19);
            this.bunifuCustomLabel3.TabIndex = 45;
            this.bunifuCustomLabel3.Text = "Paid :";
            // 
            // MilkmanTotalAmountTextbox
            // 
            this.MilkmanTotalAmountTextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.MilkmanTotalAmountTextbox.Enabled = false;
            this.MilkmanTotalAmountTextbox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.MilkmanTotalAmountTextbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.MilkmanTotalAmountTextbox.HintForeColor = System.Drawing.Color.Empty;
            this.MilkmanTotalAmountTextbox.HintText = "";
            this.MilkmanTotalAmountTextbox.isPassword = false;
            this.MilkmanTotalAmountTextbox.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(34)))), ((int)(((byte)(55)))));
            this.MilkmanTotalAmountTextbox.LineIdleColor = System.Drawing.Color.Empty;
            this.MilkmanTotalAmountTextbox.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(34)))), ((int)(((byte)(55)))));
            this.MilkmanTotalAmountTextbox.LineThickness = 3;
            this.MilkmanTotalAmountTextbox.Location = new System.Drawing.Point(447, 85);
            this.MilkmanTotalAmountTextbox.Margin = new System.Windows.Forms.Padding(4);
            this.MilkmanTotalAmountTextbox.Name = "MilkmanTotalAmountTextbox";
            this.MilkmanTotalAmountTextbox.Size = new System.Drawing.Size(139, 29);
            this.MilkmanTotalAmountTextbox.TabIndex = 42;
            this.MilkmanTotalAmountTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.MilkmanTotalAmountTextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MilkmanTotalAmountTextbox_KeyPress);
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.Black;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(343, 95);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(97, 19);
            this.bunifuCustomLabel2.TabIndex = 43;
            this.bunifuCustomLabel2.Text = "Total Amount :";
            // 
            // CheckPaymentRecordfromDBButton
            // 
            this.CheckPaymentRecordfromDBButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(34)))), ((int)(((byte)(55)))));
            this.CheckPaymentRecordfromDBButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(34)))), ((int)(((byte)(55)))));
            this.CheckPaymentRecordfromDBButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CheckPaymentRecordfromDBButton.BorderRadius = 7;
            this.CheckPaymentRecordfromDBButton.ButtonText = "       Check Record";
            this.CheckPaymentRecordfromDBButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CheckPaymentRecordfromDBButton.DisabledColor = System.Drawing.Color.Gray;
            this.CheckPaymentRecordfromDBButton.ForeColor = System.Drawing.Color.Transparent;
            this.CheckPaymentRecordfromDBButton.Iconcolor = System.Drawing.Color.Transparent;
            this.CheckPaymentRecordfromDBButton.Iconimage = null;
            this.CheckPaymentRecordfromDBButton.Iconimage_right = null;
            this.CheckPaymentRecordfromDBButton.Iconimage_right_Selected = null;
            this.CheckPaymentRecordfromDBButton.Iconimage_Selected = null;
            this.CheckPaymentRecordfromDBButton.IconMarginLeft = 0;
            this.CheckPaymentRecordfromDBButton.IconMarginRight = 0;
            this.CheckPaymentRecordfromDBButton.IconRightVisible = true;
            this.CheckPaymentRecordfromDBButton.IconRightZoom = 0D;
            this.CheckPaymentRecordfromDBButton.IconVisible = true;
            this.CheckPaymentRecordfromDBButton.IconZoom = 90D;
            this.CheckPaymentRecordfromDBButton.IsTab = false;
            this.CheckPaymentRecordfromDBButton.Location = new System.Drawing.Point(455, 231);
            this.CheckPaymentRecordfromDBButton.Name = "CheckPaymentRecordfromDBButton";
            this.CheckPaymentRecordfromDBButton.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(34)))), ((int)(((byte)(55)))));
            this.CheckPaymentRecordfromDBButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(34)))), ((int)(((byte)(55)))));
            this.CheckPaymentRecordfromDBButton.OnHoverTextColor = System.Drawing.Color.White;
            this.CheckPaymentRecordfromDBButton.selected = false;
            this.CheckPaymentRecordfromDBButton.Size = new System.Drawing.Size(131, 33);
            this.CheckPaymentRecordfromDBButton.TabIndex = 49;
            this.CheckPaymentRecordfromDBButton.Text = "       Check Record";
            this.CheckPaymentRecordfromDBButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CheckPaymentRecordfromDBButton.Textcolor = System.Drawing.Color.White;
            this.CheckPaymentRecordfromDBButton.TextFont = new System.Drawing.Font("Times New Roman", 11F);
            this.CheckPaymentRecordfromDBButton.Click += new System.EventHandler(this.CheckPaymentRecordfromDBButton_Click);
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Times New Roman", 22F);
            this.bunifuCustomLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(34)))), ((int)(((byte)(55)))));
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(281, 21);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(182, 34);
            this.bunifuCustomLabel5.TabIndex = 48;
            this.bunifuCustomLabel5.Text = "Payment Data";
            // 
            // PaymentMemberNameTextbox
            // 
            this.PaymentMemberNameTextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PaymentMemberNameTextbox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.PaymentMemberNameTextbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PaymentMemberNameTextbox.HintForeColor = System.Drawing.Color.Empty;
            this.PaymentMemberNameTextbox.HintText = "";
            this.PaymentMemberNameTextbox.isPassword = false;
            this.PaymentMemberNameTextbox.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(34)))), ((int)(((byte)(55)))));
            this.PaymentMemberNameTextbox.LineIdleColor = System.Drawing.Color.Empty;
            this.PaymentMemberNameTextbox.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(34)))), ((int)(((byte)(55)))));
            this.PaymentMemberNameTextbox.LineThickness = 3;
            this.PaymentMemberNameTextbox.Location = new System.Drawing.Point(81, 85);
            this.PaymentMemberNameTextbox.Margin = new System.Windows.Forms.Padding(4);
            this.PaymentMemberNameTextbox.Name = "PaymentMemberNameTextbox";
            this.PaymentMemberNameTextbox.Size = new System.Drawing.Size(139, 29);
            this.PaymentMemberNameTextbox.TabIndex = 50;
            this.PaymentMemberNameTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.PaymentMemberNameTextbox.OnValueChanged += new System.EventHandler(this.MemberNameTextbox_OnValueChanged);
            this.PaymentMemberNameTextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PaymentMemberNameTextbox_KeyPress);
            // 
            // bunifuCustomLabel7
            // 
            this.bunifuCustomLabel7.AutoSize = true;
            this.bunifuCustomLabel7.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel7.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.bunifuCustomLabel7.ForeColor = System.Drawing.Color.Black;
            this.bunifuCustomLabel7.Location = new System.Drawing.Point(13, 93);
            this.bunifuCustomLabel7.Name = "bunifuCustomLabel7";
            this.bunifuCustomLabel7.Size = new System.Drawing.Size(53, 19);
            this.bunifuCustomLabel7.TabIndex = 51;
            this.bunifuCustomLabel7.Text = "Name :";
            // 
            // UpdatePaymentRecordButton1
            // 
            this.UpdatePaymentRecordButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(34)))), ((int)(((byte)(55)))));
            this.UpdatePaymentRecordButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(34)))), ((int)(((byte)(55)))));
            this.UpdatePaymentRecordButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.UpdatePaymentRecordButton1.BorderRadius = 7;
            this.UpdatePaymentRecordButton1.ButtonText = "     Update Record ";
            this.UpdatePaymentRecordButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UpdatePaymentRecordButton1.DisabledColor = System.Drawing.Color.Gray;
            this.UpdatePaymentRecordButton1.ForeColor = System.Drawing.Color.Transparent;
            this.UpdatePaymentRecordButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.UpdatePaymentRecordButton1.Iconimage = null;
            this.UpdatePaymentRecordButton1.Iconimage_right = null;
            this.UpdatePaymentRecordButton1.Iconimage_right_Selected = null;
            this.UpdatePaymentRecordButton1.Iconimage_Selected = null;
            this.UpdatePaymentRecordButton1.IconMarginLeft = 0;
            this.UpdatePaymentRecordButton1.IconMarginRight = 0;
            this.UpdatePaymentRecordButton1.IconRightVisible = true;
            this.UpdatePaymentRecordButton1.IconRightZoom = 0D;
            this.UpdatePaymentRecordButton1.IconVisible = true;
            this.UpdatePaymentRecordButton1.IconZoom = 90D;
            this.UpdatePaymentRecordButton1.IsTab = false;
            this.UpdatePaymentRecordButton1.Location = new System.Drawing.Point(287, 231);
            this.UpdatePaymentRecordButton1.Name = "UpdatePaymentRecordButton1";
            this.UpdatePaymentRecordButton1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(34)))), ((int)(((byte)(55)))));
            this.UpdatePaymentRecordButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(34)))), ((int)(((byte)(55)))));
            this.UpdatePaymentRecordButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.UpdatePaymentRecordButton1.selected = false;
            this.UpdatePaymentRecordButton1.Size = new System.Drawing.Size(131, 33);
            this.UpdatePaymentRecordButton1.TabIndex = 52;
            this.UpdatePaymentRecordButton1.Text = "     Update Record ";
            this.UpdatePaymentRecordButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.UpdatePaymentRecordButton1.Textcolor = System.Drawing.Color.White;
            this.UpdatePaymentRecordButton1.TextFont = new System.Drawing.Font("Times New Roman", 11F);
            this.UpdatePaymentRecordButton1.Click += new System.EventHandler(this.UpdatePaymentRecordButton1_Click);
            // 
            // Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.UpdatePaymentRecordButton1);
            this.Controls.Add(this.PaymentMemberNameTextbox);
            this.Controls.Add(this.bunifuCustomLabel7);
            this.Controls.Add(this.CheckPaymentRecordfromDBButton);
            this.Controls.Add(this.bunifuCustomLabel5);
            this.Controls.Add(this.AmountNowPayingTextbox1);
            this.Controls.Add(this.bunifuCustomLabel6);
            this.Controls.Add(this.PaidAmount2MilkmanTextbox);
            this.Controls.Add(this.bunifuCustomLabel3);
            this.Controls.Add(this.MilkmanTotalAmountTextbox);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Name = "Payment";
            this.Size = new System.Drawing.Size(864, 493);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuMaterialTextbox AmountNowPayingTextbox1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel6;
        private Bunifu.Framework.UI.BunifuMaterialTextbox PaidAmount2MilkmanTextbox;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuMaterialTextbox MilkmanTotalAmountTextbox;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuFlatButton CheckPaymentRecordfromDBButton;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private Bunifu.Framework.UI.BunifuMaterialTextbox PaymentMemberNameTextbox;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel7;
        private Bunifu.Framework.UI.BunifuFlatButton UpdatePaymentRecordButton1;
    }
}
