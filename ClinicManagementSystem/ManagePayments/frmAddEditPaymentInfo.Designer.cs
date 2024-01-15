namespace ClinicManagementSystem.ManagePayments
{
    partial class frmAddEditPaymentInfo
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
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.lbTitle = new System.Windows.Forms.Label();
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.lbPatientID = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbPaymentMethod = new Guna.UI2.WinForms.Guna2ComboBox();
            this.dtpPaymentDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.lbPaymentID = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbAdditionalNotes = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbAmountPaid = new Guna.UI2.WinForms.Guna2TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tpPaymentInfo = new System.Windows.Forms.TabPage();
            this.tc = new Guna.UI2.WinForms.Guna2TabControl();
            this.btnClose = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btnSave = new Guna.UI2.WinForms.Guna2ImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.guna2GradientPanel1.SuspendLayout();
            this.tpPaymentInfo.SuspendLayout();
            this.tc.SuspendLayout();
            this.SuspendLayout();
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Berlin Sans FB Demi", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.Color.Red;
            this.lbTitle.Location = new System.Drawing.Point(493, 2);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(365, 45);
            this.lbTitle.TabIndex = 49;
            this.lbTitle.Text = "Add New Payment";
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.BorderRadius = 22;
            this.guna2GradientPanel1.Controls.Add(this.lbPatientID);
            this.guna2GradientPanel1.Controls.Add(this.label5);
            this.guna2GradientPanel1.Controls.Add(this.cbPaymentMethod);
            this.guna2GradientPanel1.Controls.Add(this.dtpPaymentDate);
            this.guna2GradientPanel1.Controls.Add(this.label4);
            this.guna2GradientPanel1.Controls.Add(this.lbPaymentID);
            this.guna2GradientPanel1.Controls.Add(this.label7);
            this.guna2GradientPanel1.Controls.Add(this.tbAdditionalNotes);
            this.guna2GradientPanel1.Controls.Add(this.tbAmountPaid);
            this.guna2GradientPanel1.Controls.Add(this.label6);
            this.guna2GradientPanel1.Controls.Add(this.label2);
            this.guna2GradientPanel1.Controls.Add(this.label1);
            this.guna2GradientPanel1.FillColor = System.Drawing.Color.LightSkyBlue;
            this.guna2GradientPanel1.FillColor2 = System.Drawing.Color.SlateBlue;
            this.guna2GradientPanel1.Location = new System.Drawing.Point(271, 13);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.Size = new System.Drawing.Size(796, 524);
            this.guna2GradientPanel1.TabIndex = 72;
            // 
            // lbPatientID
            // 
            this.lbPatientID.AutoSize = true;
            this.lbPatientID.BackColor = System.Drawing.Color.Transparent;
            this.lbPatientID.Font = new System.Drawing.Font("Berlin Sans FB", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPatientID.ForeColor = System.Drawing.Color.White;
            this.lbPatientID.Location = new System.Drawing.Point(455, 78);
            this.lbPatientID.Name = "lbPatientID";
            this.lbPatientID.Size = new System.Drawing.Size(60, 31);
            this.lbPatientID.TabIndex = 109;
            this.lbPatientID.Text = "N/A";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(161, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 23);
            this.label5.TabIndex = 107;
            this.label5.Text = "Patient ID :";
            // 
            // cbPaymentMethod
            // 
            this.cbPaymentMethod.BackColor = System.Drawing.Color.Transparent;
            this.cbPaymentMethod.BorderRadius = 22;
            this.cbPaymentMethod.BorderThickness = 0;
            this.cbPaymentMethod.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbPaymentMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPaymentMethod.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(140)))), ((int)(((byte)(204)))));
            this.cbPaymentMethod.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbPaymentMethod.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbPaymentMethod.Font = new System.Drawing.Font("Berlin Sans FB", 12F);
            this.cbPaymentMethod.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbPaymentMethod.ItemHeight = 35;
            this.cbPaymentMethod.Items.AddRange(new object[] {
            "Health Insurance",
            "Cash",
            "Credit Card"});
            this.cbPaymentMethod.Location = new System.Drawing.Point(322, 220);
            this.cbPaymentMethod.Name = "cbPaymentMethod";
            this.cbPaymentMethod.Size = new System.Drawing.Size(379, 41);
            this.cbPaymentMethod.TabIndex = 106;
            // 
            // dtpPaymentDate
            // 
            this.dtpPaymentDate.BorderRadius = 22;
            this.dtpPaymentDate.Checked = true;
            this.dtpPaymentDate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(160)))), ((int)(((byte)(238)))));
            this.dtpPaymentDate.Font = new System.Drawing.Font("Berlin Sans FB", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpPaymentDate.ForeColor = System.Drawing.Color.AliceBlue;
            this.dtpPaymentDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpPaymentDate.Location = new System.Drawing.Point(322, 148);
            this.dtpPaymentDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpPaymentDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpPaymentDate.Name = "dtpPaymentDate";
            this.dtpPaymentDate.Size = new System.Drawing.Size(379, 46);
            this.dtpPaymentDate.TabIndex = 105;
            this.dtpPaymentDate.Value = new System.DateTime(2023, 9, 24, 0, 0, 0, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(122, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 23);
            this.label4.TabIndex = 103;
            this.label4.Text = "Payment Date :";
            // 
            // lbPaymentID
            // 
            this.lbPaymentID.AutoSize = true;
            this.lbPaymentID.BackColor = System.Drawing.Color.Transparent;
            this.lbPaymentID.Font = new System.Drawing.Font("Berlin Sans FB", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPaymentID.ForeColor = System.Drawing.Color.White;
            this.lbPaymentID.Location = new System.Drawing.Point(455, 20);
            this.lbPaymentID.Name = "lbPaymentID";
            this.lbPaymentID.Size = new System.Drawing.Size(60, 31);
            this.lbPaymentID.TabIndex = 102;
            this.lbPaymentID.Text = "N/A";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(151, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 23);
            this.label7.TabIndex = 100;
            this.label7.Text = "PaymentID :";
            // 
            // tbAdditionalNotes
            // 
            this.tbAdditionalNotes.BackColor = System.Drawing.Color.Transparent;
            this.tbAdditionalNotes.BorderRadius = 23;
            this.tbAdditionalNotes.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbAdditionalNotes.DefaultText = "";
            this.tbAdditionalNotes.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbAdditionalNotes.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbAdditionalNotes.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbAdditionalNotes.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbAdditionalNotes.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbAdditionalNotes.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAdditionalNotes.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tbAdditionalNotes.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbAdditionalNotes.Location = new System.Drawing.Point(322, 353);
            this.tbAdditionalNotes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbAdditionalNotes.Multiline = true;
            this.tbAdditionalNotes.Name = "tbAdditionalNotes";
            this.tbAdditionalNotes.PasswordChar = '\0';
            this.tbAdditionalNotes.PlaceholderText = "????";
            this.tbAdditionalNotes.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbAdditionalNotes.SelectedText = "";
            this.tbAdditionalNotes.Size = new System.Drawing.Size(379, 159);
            this.tbAdditionalNotes.TabIndex = 99;
            this.tbAdditionalNotes.Validating += new System.ComponentModel.CancelEventHandler(this.TextBox_Validating);
            // 
            // tbAmountPaid
            // 
            this.tbAmountPaid.BackColor = System.Drawing.Color.Transparent;
            this.tbAmountPaid.BorderRadius = 23;
            this.tbAmountPaid.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbAmountPaid.DefaultText = "";
            this.tbAmountPaid.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbAmountPaid.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbAmountPaid.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbAmountPaid.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbAmountPaid.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbAmountPaid.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAmountPaid.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tbAmountPaid.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbAmountPaid.Location = new System.Drawing.Point(322, 285);
            this.tbAmountPaid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbAmountPaid.Multiline = true;
            this.tbAmountPaid.Name = "tbAmountPaid";
            this.tbAmountPaid.PasswordChar = '\0';
            this.tbAmountPaid.PlaceholderText = "????";
            this.tbAmountPaid.SelectedText = "";
            this.tbAmountPaid.Size = new System.Drawing.Size(379, 46);
            this.tbAmountPaid.TabIndex = 96;
            this.tbAmountPaid.Validating += new System.ComponentModel.CancelEventHandler(this.TextBox_Validating);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(108, 371);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(157, 23);
            this.label6.TabIndex = 94;
            this.label6.Text = "Additional Notes :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(135, 292);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 23);
            this.label2.TabIndex = 93;
            this.label2.Text = "Amount Paid :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(101, 224);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 23);
            this.label1.TabIndex = 92;
            this.label1.Text = "Payment Method :";
            // 
            // tpPaymentInfo
            // 
            this.tpPaymentInfo.Controls.Add(this.guna2GradientPanel1);
            this.tpPaymentInfo.Location = new System.Drawing.Point(4, 54);
            this.tpPaymentInfo.Name = "tpPaymentInfo";
            this.tpPaymentInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tpPaymentInfo.Size = new System.Drawing.Size(1326, 556);
            this.tpPaymentInfo.TabIndex = 0;
            this.tpPaymentInfo.Text = "Payment Info";
            this.tpPaymentInfo.UseVisualStyleBackColor = true;
            // 
            // tc
            // 
            this.tc.Controls.Add(this.tpPaymentInfo);
            this.tc.ItemSize = new System.Drawing.Size(1333, 50);
            this.tc.Location = new System.Drawing.Point(36, 50);
            this.tc.Name = "tc";
            this.tc.SelectedIndex = 0;
            this.tc.Size = new System.Drawing.Size(1334, 614);
            this.tc.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty;
            this.tc.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(160)))), ((int)(((byte)(238)))));
            this.tc.TabButtonHoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tc.TabButtonHoverState.ForeColor = System.Drawing.Color.White;
            this.tc.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(160)))), ((int)(((byte)(238)))));
            this.tc.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty;
            this.tc.TabButtonIdleState.FillColor = System.Drawing.Color.SlateBlue;
            this.tc.TabButtonIdleState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tc.TabButtonIdleState.ForeColor = System.Drawing.Color.LightGray;
            this.tc.TabButtonIdleState.InnerColor = System.Drawing.Color.SlateBlue;
            this.tc.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty;
            this.tc.TabButtonSelectedState.FillColor = System.Drawing.Color.DarkSlateBlue;
            this.tc.TabButtonSelectedState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tc.TabButtonSelectedState.ForeColor = System.Drawing.Color.White;
            this.tc.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.tc.TabButtonSize = new System.Drawing.Size(1333, 50);
            this.tc.TabIndex = 50;
            this.tc.TabMenuBackColor = System.Drawing.Color.SlateBlue;
            this.tc.TabMenuOrientation = Guna.UI2.WinForms.TabMenuOrientation.HorizontalTop;
            // 
            // btnClose
            // 
            this.btnClose.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnClose.HoverState.ImageSize = new System.Drawing.Size(35, 35);
            this.btnClose.Image = global::ClinicManagementSystem.Properties.Resources.cancel;
            this.btnClose.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnClose.ImageRotate = 0F;
            this.btnClose.ImageSize = new System.Drawing.Size(50, 50);
            this.btnClose.Location = new System.Drawing.Point(1168, 670);
            this.btnClose.Name = "btnClose";
            this.btnClose.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnClose.Size = new System.Drawing.Size(88, 64);
            this.btnClose.TabIndex = 51;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnSave.HoverState.ImageSize = new System.Drawing.Size(35, 35);
            this.btnSave.Image = global::ClinicManagementSystem.Properties.Resources.save;
            this.btnSave.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnSave.ImageRotate = 0F;
            this.btnSave.ImageSize = new System.Drawing.Size(50, 50);
            this.btnSave.Location = new System.Drawing.Point(1245, 670);
            this.btnSave.Name = "btnSave";
            this.btnSave.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnSave.Size = new System.Drawing.Size(88, 64);
            this.btnSave.TabIndex = 52;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmAddEditPaymentInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(236)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(1407, 737);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.tc);
            this.Controls.Add(this.btnSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmAddEditPaymentInfo";
            this.Text = "Add / Edit Payment Info";
            this.Load += new System.EventHandler(this.frmAddEditPaymentInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.guna2GradientPanel1.ResumeLayout(false);
            this.guna2GradientPanel1.PerformLayout();
            this.tpPaymentInfo.ResumeLayout(false);
            this.tc.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label lbTitle;
        private Guna.UI2.WinForms.Guna2ImageButton btnClose;
        private Guna.UI2.WinForms.Guna2TabControl tc;
        private System.Windows.Forms.TabPage tpPaymentInfo;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private Guna.UI2.WinForms.Guna2ImageButton btnSave;
        private System.Windows.Forms.Label lbPatientID;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2ComboBox cbPaymentMethod;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpPaymentDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbPaymentID;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2TextBox tbAdditionalNotes;
        private Guna.UI2.WinForms.Guna2TextBox tbAmountPaid;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}