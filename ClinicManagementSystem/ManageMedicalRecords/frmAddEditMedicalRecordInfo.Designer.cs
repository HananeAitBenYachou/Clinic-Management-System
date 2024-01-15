namespace ClinicManagementSystem.ManageMedicalRecords
{
    partial class frmAddEditMedicalRecordInfo
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
            this.tpMedicalRecordInfo = new System.Windows.Forms.TabPage();
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.lbPatientID = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbMedicalRecordID = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbAdditionalNotes = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbVisitDescription = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbDiagnosis = new Guna.UI2.WinForms.Guna2TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbTitle = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.guna2VSeparator1 = new Guna.UI2.WinForms.Guna2VSeparator();
            this.btnAddPrescription = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnClose = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btnSave = new Guna.UI2.WinForms.Guna2ImageButton();
            this.tc.SuspendLayout();
            this.tpMedicalRecordInfo.SuspendLayout();
            this.guna2GradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // tc
            // 
            this.tc.Controls.Add(this.tpMedicalRecordInfo);
            this.tc.ItemSize = new System.Drawing.Size(1333, 50);
            this.tc.Location = new System.Drawing.Point(34, 49);
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
            this.tc.TabIndex = 46;
            this.tc.TabMenuBackColor = System.Drawing.Color.SlateBlue;
            this.tc.TabMenuOrientation = Guna.UI2.WinForms.TabMenuOrientation.HorizontalTop;
            // 
            // tpMedicalRecordInfo
            // 
            this.tpMedicalRecordInfo.Controls.Add(this.guna2GradientPanel1);
            this.tpMedicalRecordInfo.Location = new System.Drawing.Point(4, 54);
            this.tpMedicalRecordInfo.Name = "tpMedicalRecordInfo";
            this.tpMedicalRecordInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tpMedicalRecordInfo.Size = new System.Drawing.Size(1326, 556);
            this.tpMedicalRecordInfo.TabIndex = 0;
            this.tpMedicalRecordInfo.Text = "Medical Record Info";
            this.tpMedicalRecordInfo.UseVisualStyleBackColor = true;
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.BorderRadius = 22;
            this.guna2GradientPanel1.Controls.Add(this.btnAddPrescription);
            this.guna2GradientPanel1.Controls.Add(this.guna2VSeparator1);
            this.guna2GradientPanel1.Controls.Add(this.lbPatientID);
            this.guna2GradientPanel1.Controls.Add(this.label4);
            this.guna2GradientPanel1.Controls.Add(this.lbMedicalRecordID);
            this.guna2GradientPanel1.Controls.Add(this.label7);
            this.guna2GradientPanel1.Controls.Add(this.tbAdditionalNotes);
            this.guna2GradientPanel1.Controls.Add(this.tbVisitDescription);
            this.guna2GradientPanel1.Controls.Add(this.tbDiagnosis);
            this.guna2GradientPanel1.Controls.Add(this.label6);
            this.guna2GradientPanel1.Controls.Add(this.label2);
            this.guna2GradientPanel1.Controls.Add(this.label1);
            this.guna2GradientPanel1.FillColor = System.Drawing.Color.LightSkyBlue;
            this.guna2GradientPanel1.FillColor2 = System.Drawing.Color.SlateBlue;
            this.guna2GradientPanel1.Location = new System.Drawing.Point(64, 13);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.Size = new System.Drawing.Size(1197, 524);
            this.guna2GradientPanel1.TabIndex = 72;
            // 
            // lbPatientID
            // 
            this.lbPatientID.AutoSize = true;
            this.lbPatientID.BackColor = System.Drawing.Color.Transparent;
            this.lbPatientID.Font = new System.Drawing.Font("Berlin Sans FB", 14F);
            this.lbPatientID.ForeColor = System.Drawing.Color.White;
            this.lbPatientID.Location = new System.Drawing.Point(346, 162);
            this.lbPatientID.Name = "lbPatientID";
            this.lbPatientID.Size = new System.Drawing.Size(52, 26);
            this.lbPatientID.TabIndex = 86;
            this.lbPatientID.Text = "N/A";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Berlin Sans FB", 12F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(79, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 23);
            this.label4.TabIndex = 84;
            this.label4.Text = "Patient ID :";
            // 
            // lbMedicalRecordID
            // 
            this.lbMedicalRecordID.AutoSize = true;
            this.lbMedicalRecordID.BackColor = System.Drawing.Color.Transparent;
            this.lbMedicalRecordID.Font = new System.Drawing.Font("Berlin Sans FB", 14F);
            this.lbMedicalRecordID.ForeColor = System.Drawing.Color.White;
            this.lbMedicalRecordID.Location = new System.Drawing.Point(346, 93);
            this.lbMedicalRecordID.Name = "lbMedicalRecordID";
            this.lbMedicalRecordID.Size = new System.Drawing.Size(52, 26);
            this.lbMedicalRecordID.TabIndex = 83;
            this.lbMedicalRecordID.Text = "N/A";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Berlin Sans FB", 12F);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(14, 95);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(169, 23);
            this.label7.TabIndex = 81;
            this.label7.Text = "Medical Record ID :";
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
            this.tbAdditionalNotes.Font = new System.Drawing.Font("Berlin Sans FB", 12F);
            this.tbAdditionalNotes.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tbAdditionalNotes.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbAdditionalNotes.Location = new System.Drawing.Point(786, 113);
            this.tbAdditionalNotes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbAdditionalNotes.Multiline = true;
            this.tbAdditionalNotes.Name = "tbAdditionalNotes";
            this.tbAdditionalNotes.PasswordChar = '\0';
            this.tbAdditionalNotes.PlaceholderText = "????";
            this.tbAdditionalNotes.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbAdditionalNotes.SelectedText = "";
            this.tbAdditionalNotes.Size = new System.Drawing.Size(381, 215);
            this.tbAdditionalNotes.TabIndex = 80;
            // 
            // tbVisitDescription
            // 
            this.tbVisitDescription.BackColor = System.Drawing.Color.Transparent;
            this.tbVisitDescription.BorderRadius = 23;
            this.tbVisitDescription.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbVisitDescription.DefaultText = "";
            this.tbVisitDescription.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbVisitDescription.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbVisitDescription.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbVisitDescription.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbVisitDescription.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbVisitDescription.Font = new System.Drawing.Font("Berlin Sans FB", 12F);
            this.tbVisitDescription.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tbVisitDescription.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbVisitDescription.Location = new System.Drawing.Point(197, 324);
            this.tbVisitDescription.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbVisitDescription.Multiline = true;
            this.tbVisitDescription.Name = "tbVisitDescription";
            this.tbVisitDescription.PasswordChar = '\0';
            this.tbVisitDescription.PlaceholderText = "????";
            this.tbVisitDescription.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbVisitDescription.SelectedText = "";
            this.tbVisitDescription.Size = new System.Drawing.Size(379, 112);
            this.tbVisitDescription.TabIndex = 77;
            this.tbVisitDescription.Validating += new System.ComponentModel.CancelEventHandler(this.TextBox_Validating);
            // 
            // tbDiagnosis
            // 
            this.tbDiagnosis.BackColor = System.Drawing.Color.Transparent;
            this.tbDiagnosis.BorderRadius = 23;
            this.tbDiagnosis.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbDiagnosis.DefaultText = "";
            this.tbDiagnosis.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbDiagnosis.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbDiagnosis.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbDiagnosis.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbDiagnosis.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbDiagnosis.Font = new System.Drawing.Font("Berlin Sans FB", 12F);
            this.tbDiagnosis.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tbDiagnosis.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbDiagnosis.Location = new System.Drawing.Point(204, 227);
            this.tbDiagnosis.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbDiagnosis.Multiline = true;
            this.tbDiagnosis.Name = "tbDiagnosis";
            this.tbDiagnosis.PasswordChar = '\0';
            this.tbDiagnosis.PlaceholderText = "????";
            this.tbDiagnosis.SelectedText = "";
            this.tbDiagnosis.Size = new System.Drawing.Size(360, 52);
            this.tbDiagnosis.TabIndex = 75;
            this.tbDiagnosis.Validating += new System.ComponentModel.CancelEventHandler(this.TextBox_Validating);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Berlin Sans FB", 12F);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(608, 159);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(157, 23);
            this.label6.TabIndex = 74;
            this.label6.Text = "Additional Notes :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Berlin Sans FB", 12F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(34, 335);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 23);
            this.label2.TabIndex = 73;
            this.label2.Text = "Visit Description :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Berlin Sans FB", 12F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(88, 238);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 23);
            this.label1.TabIndex = 72;
            this.label1.Text = "Diagnosis :";
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Berlin Sans FB Demi", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.Color.Red;
            this.lbTitle.Location = new System.Drawing.Point(491, 1);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(474, 45);
            this.lbTitle.TabIndex = 45;
            this.lbTitle.Text = "Add New Medical Record";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // guna2VSeparator1
            // 
            this.guna2VSeparator1.FillThickness = 4;
            this.guna2VSeparator1.Location = new System.Drawing.Point(591, 49);
            this.guna2VSeparator1.Name = "guna2VSeparator1";
            this.guna2VSeparator1.Size = new System.Drawing.Size(10, 409);
            this.guna2VSeparator1.TabIndex = 144;
            // 
            // btnAddPrescription
            // 
            this.btnAddPrescription.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnAddPrescription.BorderRadius = 22;
            this.btnAddPrescription.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddPrescription.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddPrescription.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddPrescription.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddPrescription.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddPrescription.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(160)))), ((int)(((byte)(238)))));
            this.btnAddPrescription.FillColor2 = System.Drawing.Color.LightSkyBlue;
            this.btnAddPrescription.Font = new System.Drawing.Font("Berlin Sans FB", 12F);
            this.btnAddPrescription.ForeColor = System.Drawing.Color.White;
            this.btnAddPrescription.Image = global::ClinicManagementSystem.Properties.Resources.prescription__1_;
            this.btnAddPrescription.ImageSize = new System.Drawing.Size(40, 40);
            this.btnAddPrescription.Location = new System.Drawing.Point(786, 381);
            this.btnAddPrescription.Name = "btnAddPrescription";
            this.btnAddPrescription.Size = new System.Drawing.Size(294, 55);
            this.btnAddPrescription.TabIndex = 152;
            this.btnAddPrescription.Text = "Add Prescription";
            this.btnAddPrescription.Visible = false;
            this.btnAddPrescription.Click += new System.EventHandler(this.btnAddPrescription_Click);
            // 
            // btnClose
            // 
            this.btnClose.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnClose.HoverState.ImageSize = new System.Drawing.Size(35, 35);
            this.btnClose.Image = global::ClinicManagementSystem.Properties.Resources.cancel;
            this.btnClose.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnClose.ImageRotate = 0F;
            this.btnClose.ImageSize = new System.Drawing.Size(50, 50);
            this.btnClose.Location = new System.Drawing.Point(1166, 669);
            this.btnClose.Name = "btnClose";
            this.btnClose.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnClose.Size = new System.Drawing.Size(88, 64);
            this.btnClose.TabIndex = 47;
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
            this.btnSave.Location = new System.Drawing.Point(1243, 669);
            this.btnSave.Name = "btnSave";
            this.btnSave.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnSave.Size = new System.Drawing.Size(88, 64);
            this.btnSave.TabIndex = 48;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmAddEditMedicalRecordInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(236)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(1407, 737);
            this.Controls.Add(this.tc);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmAddEditMedicalRecordInfo";
            this.Text = "Add / Edit Medical Record Info";
            this.Load += new System.EventHandler(this.frmAddEditMedicalRecordInfo_Load);
            this.tc.ResumeLayout(false);
            this.tpMedicalRecordInfo.ResumeLayout(false);
            this.guna2GradientPanel1.ResumeLayout(false);
            this.guna2GradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TabControl tc;
        private System.Windows.Forms.TabPage tpMedicalRecordInfo;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private System.Windows.Forms.Label lbTitle;
        private Guna.UI2.WinForms.Guna2ImageButton btnClose;
        private Guna.UI2.WinForms.Guna2ImageButton btnSave;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label lbPatientID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbMedicalRecordID;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2TextBox tbAdditionalNotes;
        private Guna.UI2.WinForms.Guna2TextBox tbVisitDescription;
        private Guna.UI2.WinForms.Guna2TextBox tbDiagnosis;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2VSeparator guna2VSeparator1;
        private Guna.UI2.WinForms.Guna2GradientButton btnAddPrescription;
    }
}