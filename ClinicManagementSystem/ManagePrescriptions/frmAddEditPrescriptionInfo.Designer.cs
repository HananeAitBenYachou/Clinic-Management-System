namespace ClinicManagementSystem.ManagePrescriptions
{
    partial class frmAddEditPrescriptionInfo
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
            this.tc = new Guna.UI2.WinForms.Guna2TabControl();
            this.tpPrescriptionInfo = new System.Windows.Forms.TabPage();
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.guna2VSeparator1 = new Guna.UI2.WinForms.Guna2VSeparator();
            this.dtpEndDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpStartDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.tbSpecialInstructions = new Guna.UI2.WinForms.Guna2TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbFrequency = new Guna.UI2.WinForms.Guna2TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbDosage = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbMedicationName = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbMedicalRecordID = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbPrescriptionID = new System.Windows.Forms.Label();
            this.btnSave = new Guna.UI2.WinForms.Guna2ImageButton();
            this.lbTitle = new System.Windows.Forms.Label();
            this.btnClose = new Guna.UI2.WinForms.Guna2ImageButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tc.SuspendLayout();
            this.tpPrescriptionInfo.SuspendLayout();
            this.guna2GradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // tc
            // 
            this.tc.Controls.Add(this.tpPrescriptionInfo);
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
            this.tc.TabIndex = 54;
            this.tc.TabMenuBackColor = System.Drawing.Color.SlateBlue;
            this.tc.TabMenuOrientation = Guna.UI2.WinForms.TabMenuOrientation.HorizontalTop;
            // 
            // tpPrescriptionInfo
            // 
            this.tpPrescriptionInfo.Controls.Add(this.guna2GradientPanel1);
            this.tpPrescriptionInfo.Location = new System.Drawing.Point(4, 54);
            this.tpPrescriptionInfo.Name = "tpPrescriptionInfo";
            this.tpPrescriptionInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tpPrescriptionInfo.Size = new System.Drawing.Size(1326, 556);
            this.tpPrescriptionInfo.TabIndex = 0;
            this.tpPrescriptionInfo.Text = "Prescription Info";
            this.tpPrescriptionInfo.UseVisualStyleBackColor = true;
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.BorderRadius = 22;
            this.guna2GradientPanel1.Controls.Add(this.guna2VSeparator1);
            this.guna2GradientPanel1.Controls.Add(this.dtpEndDate);
            this.guna2GradientPanel1.Controls.Add(this.label1);
            this.guna2GradientPanel1.Controls.Add(this.dtpStartDate);
            this.guna2GradientPanel1.Controls.Add(this.label4);
            this.guna2GradientPanel1.Controls.Add(this.tbSpecialInstructions);
            this.guna2GradientPanel1.Controls.Add(this.label6);
            this.guna2GradientPanel1.Controls.Add(this.tbFrequency);
            this.guna2GradientPanel1.Controls.Add(this.label8);
            this.guna2GradientPanel1.Controls.Add(this.tbDosage);
            this.guna2GradientPanel1.Controls.Add(this.label3);
            this.guna2GradientPanel1.Controls.Add(this.tbMedicationName);
            this.guna2GradientPanel1.Controls.Add(this.label2);
            this.guna2GradientPanel1.Controls.Add(this.lbMedicalRecordID);
            this.guna2GradientPanel1.Controls.Add(this.label7);
            this.guna2GradientPanel1.Controls.Add(this.label5);
            this.guna2GradientPanel1.Controls.Add(this.lbPrescriptionID);
            this.guna2GradientPanel1.FillColor = System.Drawing.Color.LightSkyBlue;
            this.guna2GradientPanel1.FillColor2 = System.Drawing.Color.SlateBlue;
            this.guna2GradientPanel1.Location = new System.Drawing.Point(87, 23);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.Size = new System.Drawing.Size(1152, 507);
            this.guna2GradientPanel1.TabIndex = 72;
            // 
            // guna2VSeparator1
            // 
            this.guna2VSeparator1.FillThickness = 4;
            this.guna2VSeparator1.Location = new System.Drawing.Point(565, 35);
            this.guna2VSeparator1.Name = "guna2VSeparator1";
            this.guna2VSeparator1.Size = new System.Drawing.Size(10, 409);
            this.guna2VSeparator1.TabIndex = 143;
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.BorderRadius = 22;
            this.dtpEndDate.Checked = true;
            this.dtpEndDate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(160)))), ((int)(((byte)(238)))));
            this.dtpEndDate.Font = new System.Drawing.Font("Berlin Sans FB", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEndDate.ForeColor = System.Drawing.Color.AliceBlue;
            this.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpEndDate.Location = new System.Drawing.Point(774, 212);
            this.dtpEndDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpEndDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(351, 55);
            this.dtpEndDate.TabIndex = 141;
            this.dtpEndDate.Value = new System.DateTime(2023, 9, 24, 0, 0, 0, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(663, 224);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 23);
            this.label1.TabIndex = 140;
            this.label1.Text = "End Date :";
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.BorderRadius = 22;
            this.dtpStartDate.Checked = true;
            this.dtpStartDate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(160)))), ((int)(((byte)(238)))));
            this.dtpStartDate.Font = new System.Drawing.Font("Berlin Sans FB", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpStartDate.ForeColor = System.Drawing.Color.AliceBlue;
            this.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpStartDate.Location = new System.Drawing.Point(190, 212);
            this.dtpStartDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpStartDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(351, 55);
            this.dtpStartDate.TabIndex = 139;
            this.dtpStartDate.Value = new System.DateTime(2023, 9, 24, 0, 0, 0, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(66, 225);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 23);
            this.label4.TabIndex = 138;
            this.label4.Text = "Start Date :";
            // 
            // tbSpecialInstructions
            // 
            this.tbSpecialInstructions.BackColor = System.Drawing.Color.Transparent;
            this.tbSpecialInstructions.BorderRadius = 23;
            this.tbSpecialInstructions.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbSpecialInstructions.DefaultText = "";
            this.tbSpecialInstructions.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbSpecialInstructions.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbSpecialInstructions.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbSpecialInstructions.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbSpecialInstructions.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbSpecialInstructions.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSpecialInstructions.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tbSpecialInstructions.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbSpecialInstructions.Location = new System.Drawing.Point(774, 325);
            this.tbSpecialInstructions.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbSpecialInstructions.Multiline = true;
            this.tbSpecialInstructions.Name = "tbSpecialInstructions";
            this.tbSpecialInstructions.PasswordChar = '\0';
            this.tbSpecialInstructions.PlaceholderText = "????";
            this.tbSpecialInstructions.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbSpecialInstructions.SelectedText = "";
            this.tbSpecialInstructions.Size = new System.Drawing.Size(351, 116);
            this.tbSpecialInstructions.TabIndex = 133;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(590, 346);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(172, 23);
            this.label6.TabIndex = 132;
            this.label6.Text = "Special Instructions :";
            // 
            // tbFrequency
            // 
            this.tbFrequency.BackColor = System.Drawing.Color.Transparent;
            this.tbFrequency.BorderRadius = 23;
            this.tbFrequency.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbFrequency.DefaultText = "";
            this.tbFrequency.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbFrequency.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbFrequency.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbFrequency.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbFrequency.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbFrequency.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFrequency.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tbFrequency.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbFrequency.Location = new System.Drawing.Point(190, 325);
            this.tbFrequency.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbFrequency.Multiline = true;
            this.tbFrequency.Name = "tbFrequency";
            this.tbFrequency.PasswordChar = '\0';
            this.tbFrequency.PlaceholderText = "????";
            this.tbFrequency.SelectedText = "";
            this.tbFrequency.Size = new System.Drawing.Size(351, 116);
            this.tbFrequency.TabIndex = 131;
            this.tbFrequency.Validating += new System.ComponentModel.CancelEventHandler(this.TextBox_Validating);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(66, 347);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 23);
            this.label8.TabIndex = 130;
            this.label8.Text = "Frequency :";
            // 
            // tbDosage
            // 
            this.tbDosage.BackColor = System.Drawing.Color.Transparent;
            this.tbDosage.BorderRadius = 23;
            this.tbDosage.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbDosage.DefaultText = "";
            this.tbDosage.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbDosage.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbDosage.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbDosage.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbDosage.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbDosage.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDosage.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tbDosage.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbDosage.Location = new System.Drawing.Point(774, 109);
            this.tbDosage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbDosage.Multiline = true;
            this.tbDosage.Name = "tbDosage";
            this.tbDosage.PasswordChar = '\0';
            this.tbDosage.PlaceholderText = "????";
            this.tbDosage.SelectedText = "";
            this.tbDosage.Size = new System.Drawing.Size(351, 57);
            this.tbDosage.TabIndex = 129;
            this.tbDosage.Validating += new System.ComponentModel.CancelEventHandler(this.TextBox_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(681, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 23);
            this.label3.TabIndex = 128;
            this.label3.Text = "Dosage :";
            // 
            // tbMedicationName
            // 
            this.tbMedicationName.BackColor = System.Drawing.Color.Transparent;
            this.tbMedicationName.BorderRadius = 23;
            this.tbMedicationName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbMedicationName.DefaultText = "";
            this.tbMedicationName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbMedicationName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbMedicationName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbMedicationName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbMedicationName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbMedicationName.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMedicationName.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tbMedicationName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbMedicationName.Location = new System.Drawing.Point(190, 109);
            this.tbMedicationName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbMedicationName.Multiline = true;
            this.tbMedicationName.Name = "tbMedicationName";
            this.tbMedicationName.PasswordChar = '\0';
            this.tbMedicationName.PlaceholderText = "????";
            this.tbMedicationName.SelectedText = "";
            this.tbMedicationName.Size = new System.Drawing.Size(351, 57);
            this.tbMedicationName.TabIndex = 127;
            this.tbMedicationName.Validating += new System.ComponentModel.CancelEventHandler(this.TextBox_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(8, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 23);
            this.label2.TabIndex = 126;
            this.label2.Text = "Medication Name :";
            // 
            // lbMedicalRecordID
            // 
            this.lbMedicalRecordID.AutoSize = true;
            this.lbMedicalRecordID.BackColor = System.Drawing.Color.Transparent;
            this.lbMedicalRecordID.Font = new System.Drawing.Font("Berlin Sans FB", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMedicalRecordID.ForeColor = System.Drawing.Color.White;
            this.lbMedicalRecordID.Location = new System.Drawing.Point(902, 33);
            this.lbMedicalRecordID.Name = "lbMedicalRecordID";
            this.lbMedicalRecordID.Size = new System.Drawing.Size(60, 31);
            this.lbMedicalRecordID.TabIndex = 114;
            this.lbMedicalRecordID.Text = "N/A";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(35, 41);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(139, 23);
            this.label7.TabIndex = 111;
            this.label7.Text = "Prescription ID :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(593, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(169, 23);
            this.label5.TabIndex = 113;
            this.label5.Text = "Medical Record ID :";
            // 
            // lbPrescriptionID
            // 
            this.lbPrescriptionID.AutoSize = true;
            this.lbPrescriptionID.BackColor = System.Drawing.Color.Transparent;
            this.lbPrescriptionID.Font = new System.Drawing.Font("Berlin Sans FB", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrescriptionID.ForeColor = System.Drawing.Color.White;
            this.lbPrescriptionID.Location = new System.Drawing.Point(319, 34);
            this.lbPrescriptionID.Name = "lbPrescriptionID";
            this.lbPrescriptionID.Size = new System.Drawing.Size(60, 31);
            this.lbPrescriptionID.TabIndex = 112;
            this.lbPrescriptionID.Text = "N/A";
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
            this.btnSave.TabIndex = 56;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Berlin Sans FB Demi", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.Color.Red;
            this.lbTitle.Location = new System.Drawing.Point(493, 2);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(413, 45);
            this.lbTitle.TabIndex = 53;
            this.lbTitle.Text = "Add New Prescription";
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
            this.btnClose.TabIndex = 55;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmAddEditPrescriptionInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(236)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(1407, 737);
            this.Controls.Add(this.tc);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmAddEditPrescriptionInfo";
            this.Text = "Add / Edit Prescription Info";
            this.Load += new System.EventHandler(this.frmAddEditPrescriptionInfo_Load);
            this.tc.ResumeLayout(false);
            this.tpPrescriptionInfo.ResumeLayout(false);
            this.guna2GradientPanel1.ResumeLayout(false);
            this.guna2GradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TabControl tc;
        private System.Windows.Forms.TabPage tpPrescriptionInfo;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private Guna.UI2.WinForms.Guna2ImageButton btnSave;
        private System.Windows.Forms.Label lbTitle;
        private Guna.UI2.WinForms.Guna2ImageButton btnClose;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label lbMedicalRecordID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbPrescriptionID;
        private Guna.UI2.WinForms.Guna2TextBox tbFrequency;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2TextBox tbDosage;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox tbMedicationName;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox tbSpecialInstructions;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpEndDate;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpStartDate;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2VSeparator guna2VSeparator1;
    }
}