namespace ClinicManagementSystem.ManageAppointments
{
    partial class frmAddEditAppointmentInfo
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
            this.tpAppointmentInfo = new System.Windows.Forms.TabPage();
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.lbPaymentID = new System.Windows.Forms.Label();
            this.cbAppointmentStatus = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lbMedicalRecordID = new System.Windows.Forms.Label();
            this.btnPay = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnAddMedicalRecord = new Guna.UI2.WinForms.Guna2GradientButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbDoctorID = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbPatientID = new Guna.UI2.WinForms.Guna2TextBox();
            this.dtpAppointmentDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.guna2VSeparator1 = new Guna.UI2.WinForms.Guna2VSeparator();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbAppointmentID = new System.Windows.Forms.Label();
            this.tc = new Guna.UI2.WinForms.Guna2TabControl();
            this.btnClose = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btnSave = new Guna.UI2.WinForms.Guna2ImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.tpAppointmentInfo.SuspendLayout();
            this.guna2GradientPanel1.SuspendLayout();
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
            this.lbTitle.Size = new System.Drawing.Size(440, 45);
            this.lbTitle.TabIndex = 49;
            this.lbTitle.Text = "Add New Appointment";
            // 
            // tpAppointmentInfo
            // 
            this.tpAppointmentInfo.Controls.Add(this.guna2GradientPanel1);
            this.tpAppointmentInfo.Location = new System.Drawing.Point(4, 54);
            this.tpAppointmentInfo.Name = "tpAppointmentInfo";
            this.tpAppointmentInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tpAppointmentInfo.Size = new System.Drawing.Size(1326, 556);
            this.tpAppointmentInfo.TabIndex = 0;
            this.tpAppointmentInfo.Text = "Appointment Info";
            this.tpAppointmentInfo.UseVisualStyleBackColor = true;
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.BorderRadius = 22;
            this.guna2GradientPanel1.Controls.Add(this.lbPaymentID);
            this.guna2GradientPanel1.Controls.Add(this.cbAppointmentStatus);
            this.guna2GradientPanel1.Controls.Add(this.lbMedicalRecordID);
            this.guna2GradientPanel1.Controls.Add(this.btnPay);
            this.guna2GradientPanel1.Controls.Add(this.btnAddMedicalRecord);
            this.guna2GradientPanel1.Controls.Add(this.label1);
            this.guna2GradientPanel1.Controls.Add(this.label3);
            this.guna2GradientPanel1.Controls.Add(this.label5);
            this.guna2GradientPanel1.Controls.Add(this.tbDoctorID);
            this.guna2GradientPanel1.Controls.Add(this.tbPatientID);
            this.guna2GradientPanel1.Controls.Add(this.dtpAppointmentDate);
            this.guna2GradientPanel1.Controls.Add(this.label8);
            this.guna2GradientPanel1.Controls.Add(this.label4);
            this.guna2GradientPanel1.Controls.Add(this.guna2VSeparator1);
            this.guna2GradientPanel1.Controls.Add(this.label2);
            this.guna2GradientPanel1.Controls.Add(this.label7);
            this.guna2GradientPanel1.Controls.Add(this.lbAppointmentID);
            this.guna2GradientPanel1.FillColor = System.Drawing.Color.LightSkyBlue;
            this.guna2GradientPanel1.FillColor2 = System.Drawing.Color.SlateBlue;
            this.guna2GradientPanel1.Location = new System.Drawing.Point(87, 25);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.Size = new System.Drawing.Size(1152, 507);
            this.guna2GradientPanel1.TabIndex = 73;
            // 
            // lbPaymentID
            // 
            this.lbPaymentID.AutoSize = true;
            this.lbPaymentID.BackColor = System.Drawing.Color.Transparent;
            this.lbPaymentID.Font = new System.Drawing.Font("Berlin Sans FB", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPaymentID.ForeColor = System.Drawing.Color.White;
            this.lbPaymentID.Location = new System.Drawing.Point(804, 362);
            this.lbPaymentID.Name = "lbPaymentID";
            this.lbPaymentID.Size = new System.Drawing.Size(60, 31);
            this.lbPaymentID.TabIndex = 154;
            this.lbPaymentID.Text = "N/A";
            // 
            // cbAppointmentStatus
            // 
            this.cbAppointmentStatus.BackColor = System.Drawing.Color.Transparent;
            this.cbAppointmentStatus.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbAppointmentStatus.BorderRadius = 23;
            this.cbAppointmentStatus.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(140)))), ((int)(((byte)(204)))));
            this.cbAppointmentStatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbAppointmentStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAppointmentStatus.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(140)))), ((int)(((byte)(204)))));
            this.cbAppointmentStatus.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbAppointmentStatus.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbAppointmentStatus.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 12F);
            this.cbAppointmentStatus.ForeColor = System.Drawing.Color.White;
            this.cbAppointmentStatus.ItemHeight = 40;
            this.cbAppointmentStatus.Items.AddRange(new object[] {
            "Cancelled",
            "Completed",
            "Confirmed",
            "Pending",
            "Rescheduled",
            "Unattended"});
            this.cbAppointmentStatus.Location = new System.Drawing.Point(805, 81);
            this.cbAppointmentStatus.Name = "cbAppointmentStatus";
            this.cbAppointmentStatus.Size = new System.Drawing.Size(283, 46);
            this.cbAppointmentStatus.TabIndex = 153;
            // 
            // lbMedicalRecordID
            // 
            this.lbMedicalRecordID.AutoSize = true;
            this.lbMedicalRecordID.BackColor = System.Drawing.Color.Transparent;
            this.lbMedicalRecordID.Font = new System.Drawing.Font("Berlin Sans FB", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMedicalRecordID.ForeColor = System.Drawing.Color.White;
            this.lbMedicalRecordID.Location = new System.Drawing.Point(808, 226);
            this.lbMedicalRecordID.Name = "lbMedicalRecordID";
            this.lbMedicalRecordID.Size = new System.Drawing.Size(60, 31);
            this.lbMedicalRecordID.TabIndex = 152;
            this.lbMedicalRecordID.Text = "N/A";
            // 
            // btnPay
            // 
            this.btnPay.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnPay.BorderRadius = 22;
            this.btnPay.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPay.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPay.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPay.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPay.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPay.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(160)))), ((int)(((byte)(238)))));
            this.btnPay.FillColor2 = System.Drawing.Color.LightSkyBlue;
            this.btnPay.Font = new System.Drawing.Font("Berlin Sans FB", 12F);
            this.btnPay.ForeColor = System.Drawing.Color.White;
            this.btnPay.Image = global::ClinicManagementSystem.Properties.Resources.transaction_history;
            this.btnPay.ImageSize = new System.Drawing.Size(30, 30);
            this.btnPay.Location = new System.Drawing.Point(892, 345);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(214, 57);
            this.btnPay.TabIndex = 151;
            this.btnPay.Text = "Pay";
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // btnAddMedicalRecord
            // 
            this.btnAddMedicalRecord.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnAddMedicalRecord.BorderRadius = 22;
            this.btnAddMedicalRecord.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddMedicalRecord.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddMedicalRecord.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddMedicalRecord.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddMedicalRecord.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddMedicalRecord.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(160)))), ((int)(((byte)(238)))));
            this.btnAddMedicalRecord.FillColor2 = System.Drawing.Color.LightSkyBlue;
            this.btnAddMedicalRecord.Font = new System.Drawing.Font("Berlin Sans FB", 11F);
            this.btnAddMedicalRecord.ForeColor = System.Drawing.Color.White;
            this.btnAddMedicalRecord.Image = global::ClinicManagementSystem.Properties.Resources.report1;
            this.btnAddMedicalRecord.ImageSize = new System.Drawing.Size(30, 30);
            this.btnAddMedicalRecord.Location = new System.Drawing.Point(892, 212);
            this.btnAddMedicalRecord.Name = "btnAddMedicalRecord";
            this.btnAddMedicalRecord.Size = new System.Drawing.Size(214, 57);
            this.btnAddMedicalRecord.TabIndex = 53;
            this.btnAddMedicalRecord.Text = "Add Medical Record";
            this.btnAddMedicalRecord.Click += new System.EventHandler(this.btnAddMedicalRecord_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(650, 366);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 23);
            this.label1.TabIndex = 150;
            this.label1.Text = "Payment ID :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(600, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 23);
            this.label3.TabIndex = 149;
            this.label3.Text = "Medical Record ID :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(579, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(190, 23);
            this.label5.TabIndex = 148;
            this.label5.Text = "Appointment Status  :";
            // 
            // tbDoctorID
            // 
            this.tbDoctorID.BackColor = System.Drawing.Color.Transparent;
            this.tbDoctorID.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tbDoctorID.BorderRadius = 23;
            this.tbDoctorID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbDoctorID.DefaultText = "";
            this.tbDoctorID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbDoctorID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbDoctorID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbDoctorID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbDoctorID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbDoctorID.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDoctorID.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tbDoctorID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbDoctorID.Location = new System.Drawing.Point(211, 360);
            this.tbDoctorID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbDoctorID.Multiline = true;
            this.tbDoctorID.Name = "tbDoctorID";
            this.tbDoctorID.PasswordChar = '\0';
            this.tbDoctorID.PlaceholderText = "????";
            this.tbDoctorID.SelectedText = "";
            this.tbDoctorID.Size = new System.Drawing.Size(283, 46);
            this.tbDoctorID.TabIndex = 147;
            this.tbDoctorID.Validating += new System.ComponentModel.CancelEventHandler(this.tbDoctorID_Validating);
            // 
            // tbPatientID
            // 
            this.tbPatientID.BackColor = System.Drawing.Color.Transparent;
            this.tbPatientID.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tbPatientID.BorderRadius = 23;
            this.tbPatientID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbPatientID.DefaultText = "";
            this.tbPatientID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbPatientID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbPatientID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbPatientID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbPatientID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbPatientID.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPatientID.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tbPatientID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbPatientID.Location = new System.Drawing.Point(211, 259);
            this.tbPatientID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbPatientID.Multiline = true;
            this.tbPatientID.Name = "tbPatientID";
            this.tbPatientID.PasswordChar = '\0';
            this.tbPatientID.PlaceholderText = "????";
            this.tbPatientID.SelectedText = "";
            this.tbPatientID.Size = new System.Drawing.Size(283, 46);
            this.tbPatientID.TabIndex = 97;
            this.tbPatientID.Validating += new System.ComponentModel.CancelEventHandler(this.tbPatientID_Validating);
            // 
            // dtpAppointmentDate
            // 
            this.dtpAppointmentDate.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dtpAppointmentDate.BorderRadius = 22;
            this.dtpAppointmentDate.BorderThickness = 1;
            this.dtpAppointmentDate.Checked = true;
            this.dtpAppointmentDate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(160)))), ((int)(((byte)(238)))));
            this.dtpAppointmentDate.Font = new System.Drawing.Font("Berlin Sans FB", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpAppointmentDate.ForeColor = System.Drawing.Color.AliceBlue;
            this.dtpAppointmentDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpAppointmentDate.Location = new System.Drawing.Point(211, 170);
            this.dtpAppointmentDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpAppointmentDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpAppointmentDate.Name = "dtpAppointmentDate";
            this.dtpAppointmentDate.Size = new System.Drawing.Size(283, 46);
            this.dtpAppointmentDate.TabIndex = 146;
            this.dtpAppointmentDate.Value = new System.DateTime(2023, 9, 24, 0, 0, 0, 0);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(14, 179);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(176, 23);
            this.label8.TabIndex = 145;
            this.label8.Text = "Appointment Date :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(91, 366);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 23);
            this.label4.TabIndex = 144;
            this.label4.Text = "Doctor ID :";
            // 
            // guna2VSeparator1
            // 
            this.guna2VSeparator1.FillThickness = 4;
            this.guna2VSeparator1.Location = new System.Drawing.Point(541, 35);
            this.guna2VSeparator1.Name = "guna2VSeparator1";
            this.guna2VSeparator1.Size = new System.Drawing.Size(10, 409);
            this.guna2VSeparator1.TabIndex = 143;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(86, 267);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 23);
            this.label2.TabIndex = 126;
            this.label2.Text = "Patient ID :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(38, 89);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(152, 23);
            this.label7.TabIndex = 111;
            this.label7.Text = "Appointment ID :";
            // 
            // lbAppointmentID
            // 
            this.lbAppointmentID.AutoSize = true;
            this.lbAppointmentID.BackColor = System.Drawing.Color.Transparent;
            this.lbAppointmentID.Font = new System.Drawing.Font("Berlin Sans FB", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAppointmentID.ForeColor = System.Drawing.Color.White;
            this.lbAppointmentID.Location = new System.Drawing.Point(337, 82);
            this.lbAppointmentID.Name = "lbAppointmentID";
            this.lbAppointmentID.Size = new System.Drawing.Size(60, 31);
            this.lbAppointmentID.TabIndex = 112;
            this.lbAppointmentID.Text = "N/A";
            // 
            // tc
            // 
            this.tc.Controls.Add(this.tpAppointmentInfo);
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
            // frmAddEditAppointmentInfo
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
            this.Name = "frmAddEditAppointmentInfo";
            this.Text = "Add / Edit Appointment Info";
            this.Load += new System.EventHandler(this.frmAddEditAppointmentInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.tpAppointmentInfo.ResumeLayout(false);
            this.guna2GradientPanel1.ResumeLayout(false);
            this.guna2GradientPanel1.PerformLayout();
            this.tc.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label lbTitle;
        private Guna.UI2.WinForms.Guna2ImageButton btnClose;
        private Guna.UI2.WinForms.Guna2TabControl tc;
        private System.Windows.Forms.TabPage tpAppointmentInfo;
        private Guna.UI2.WinForms.Guna2ImageButton btnSave;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private Guna.UI2.WinForms.Guna2VSeparator guna2VSeparator1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbAppointmentID;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpAppointmentDate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox tbDoctorID;
        private Guna.UI2.WinForms.Guna2TextBox tbPatientID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2GradientButton btnPay;
        private Guna.UI2.WinForms.Guna2GradientButton btnAddMedicalRecord;
        private System.Windows.Forms.Label lbMedicalRecordID;
        private Guna.UI2.WinForms.Guna2ComboBox cbAppointmentStatus;
        private System.Windows.Forms.Label lbPaymentID;
    }
}