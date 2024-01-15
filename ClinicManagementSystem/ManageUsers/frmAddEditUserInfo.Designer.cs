namespace ClinicManagementSystem.ManageUsers
{
    partial class frmAddEditUserInfo
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
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tsAll = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tsManageUsers = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.PermissionsPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.tsManagePatients = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.tsManageMedRecords = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.tsManagePayments = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.tsManagePrescriptions = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.tsManageAppointments = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.tsManageSpecialities = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.tsManageDoctors = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.tc = new Guna.UI2.WinForms.Guna2TabControl();
            this.tpUserInfo = new System.Windows.Forms.TabPage();
            this.tpAccountInfo = new System.Windows.Forms.TabPage();
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.guna2VSeparator1 = new Guna.UI2.WinForms.Guna2VSeparator();
            this.tbPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbUserName = new Guna.UI2.WinForms.Guna2TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.gbPermissions = new Guna.UI2.WinForms.Guna2GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbTitle = new System.Windows.Forms.Label();
            this.guna2ImageButton1 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btnSave = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btnUpdatePerson = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnNext = new Guna.UI2.WinForms.Guna2GradientButton();
            this.ucPersonCard1 = new ClinicManagementSystem.UserControls.ucPersonCard();
            this.btnSelectPerson = new Guna.UI2.WinForms.Guna2GradientButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.PermissionsPanel.SuspendLayout();
            this.tc.SuspendLayout();
            this.tpUserInfo.SuspendLayout();
            this.tpAccountInfo.SuspendLayout();
            this.guna2GradientPanel1.SuspendLayout();
            this.gbPermissions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Berlin Sans FB", 11F);
            this.label10.ForeColor = System.Drawing.Color.Gray;
            this.label10.Location = new System.Drawing.Point(82, 403);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(121, 21);
            this.label10.TabIndex = 194;
            this.label10.Text = "Manage Users";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Berlin Sans FB", 11F);
            this.label11.ForeColor = System.Drawing.Color.Gray;
            this.label11.Location = new System.Drawing.Point(120, 50);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(36, 21);
            this.label11.TabIndex = 145;
            this.label11.Text = "All ";
            // 
            // tsAll
            // 
            this.tsAll.CheckedState.BorderColor = System.Drawing.Color.Green;
            this.tsAll.CheckedState.FillColor = System.Drawing.Color.Green;
            this.tsAll.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.tsAll.CheckedState.InnerColor = System.Drawing.Color.White;
            this.tsAll.Location = new System.Drawing.Point(234, 50);
            this.tsAll.Name = "tsAll";
            this.tsAll.Size = new System.Drawing.Size(63, 20);
            this.tsAll.TabIndex = 144;
            this.tsAll.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(6)))), ((int)(((byte)(44)))));
            this.tsAll.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(6)))), ((int)(((byte)(44)))));
            this.tsAll.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.tsAll.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.tsAll.CheckedChanged += new System.EventHandler(this.tsAll_CheckedChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Berlin Sans FB", 11F);
            this.label9.ForeColor = System.Drawing.Color.Gray;
            this.label9.Location = new System.Drawing.Point(19, 360);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(184, 21);
            this.label9.TabIndex = 192;
            this.label9.Text = "Manage Med-Records";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Berlin Sans FB", 11F);
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(62, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 21);
            this.label3.TabIndex = 182;
            this.label3.Text = "Manage Doctors";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Berlin Sans FB", 11F);
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(36, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(167, 21);
            this.label4.TabIndex = 184;
            this.label4.Text = "Manage Specialities";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Berlin Sans FB", 11F);
            this.label5.ForeColor = System.Drawing.Color.Gray;
            this.label5.Location = new System.Drawing.Point(8, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(195, 21);
            this.label5.TabIndex = 186;
            this.label5.Text = "Manage Appointments";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Berlin Sans FB", 11F);
            this.label7.ForeColor = System.Drawing.Color.Gray;
            this.label7.Location = new System.Drawing.Point(42, 317);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(161, 21);
            this.label7.TabIndex = 190;
            this.label7.Text = "Manage Payments";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Berlin Sans FB", 11F);
            this.label6.ForeColor = System.Drawing.Color.Gray;
            this.label6.Location = new System.Drawing.Point(23, 274);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(180, 21);
            this.label6.TabIndex = 188;
            this.label6.Text = "Manage Prescriptions";
            // 
            // tsManageUsers
            // 
            this.tsManageUsers.CheckedState.BorderColor = System.Drawing.Color.Green;
            this.tsManageUsers.CheckedState.FillColor = System.Drawing.Color.Green;
            this.tsManageUsers.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.tsManageUsers.CheckedState.InnerColor = System.Drawing.Color.White;
            this.tsManageUsers.Location = new System.Drawing.Point(23, 317);
            this.tsManageUsers.Name = "tsManageUsers";
            this.tsManageUsers.Size = new System.Drawing.Size(63, 20);
            this.tsManageUsers.TabIndex = 193;
            this.tsManageUsers.Tag = "128";
            this.tsManageUsers.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(6)))), ((int)(((byte)(44)))));
            this.tsManageUsers.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(6)))), ((int)(((byte)(44)))));
            this.tsManageUsers.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.tsManageUsers.UncheckedState.InnerColor = System.Drawing.Color.White;
            // 
            // PermissionsPanel
            // 
            this.PermissionsPanel.BackColor = System.Drawing.Color.Transparent;
            this.PermissionsPanel.Controls.Add(this.tsManageUsers);
            this.PermissionsPanel.Controls.Add(this.tsManagePatients);
            this.PermissionsPanel.Controls.Add(this.tsManageMedRecords);
            this.PermissionsPanel.Controls.Add(this.tsManagePayments);
            this.PermissionsPanel.Controls.Add(this.tsManagePrescriptions);
            this.PermissionsPanel.Controls.Add(this.tsManageAppointments);
            this.PermissionsPanel.Controls.Add(this.tsManageSpecialities);
            this.PermissionsPanel.Controls.Add(this.tsManageDoctors);
            this.PermissionsPanel.Location = new System.Drawing.Point(211, 88);
            this.PermissionsPanel.Name = "PermissionsPanel";
            this.PermissionsPanel.Size = new System.Drawing.Size(108, 355);
            this.PermissionsPanel.TabIndex = 164;
            // 
            // tsManagePatients
            // 
            this.tsManagePatients.CheckedState.BorderColor = System.Drawing.Color.Green;
            this.tsManagePatients.CheckedState.FillColor = System.Drawing.Color.Green;
            this.tsManagePatients.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.tsManagePatients.CheckedState.InnerColor = System.Drawing.Color.White;
            this.tsManagePatients.Location = new System.Drawing.Point(23, 16);
            this.tsManagePatients.Name = "tsManagePatients";
            this.tsManagePatients.Size = new System.Drawing.Size(63, 20);
            this.tsManagePatients.TabIndex = 180;
            this.tsManagePatients.Tag = "1";
            this.tsManagePatients.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(6)))), ((int)(((byte)(44)))));
            this.tsManagePatients.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(6)))), ((int)(((byte)(44)))));
            this.tsManagePatients.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.tsManagePatients.UncheckedState.InnerColor = System.Drawing.Color.White;
            // 
            // tsManageMedRecords
            // 
            this.tsManageMedRecords.CheckedState.BorderColor = System.Drawing.Color.Green;
            this.tsManageMedRecords.CheckedState.FillColor = System.Drawing.Color.Green;
            this.tsManageMedRecords.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.tsManageMedRecords.CheckedState.InnerColor = System.Drawing.Color.White;
            this.tsManageMedRecords.Location = new System.Drawing.Point(23, 274);
            this.tsManageMedRecords.Name = "tsManageMedRecords";
            this.tsManageMedRecords.Size = new System.Drawing.Size(63, 20);
            this.tsManageMedRecords.TabIndex = 191;
            this.tsManageMedRecords.Tag = "64";
            this.tsManageMedRecords.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(6)))), ((int)(((byte)(44)))));
            this.tsManageMedRecords.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(6)))), ((int)(((byte)(44)))));
            this.tsManageMedRecords.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.tsManageMedRecords.UncheckedState.InnerColor = System.Drawing.Color.White;
            // 
            // tsManagePayments
            // 
            this.tsManagePayments.CheckedState.BorderColor = System.Drawing.Color.Green;
            this.tsManagePayments.CheckedState.FillColor = System.Drawing.Color.Green;
            this.tsManagePayments.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.tsManagePayments.CheckedState.InnerColor = System.Drawing.Color.White;
            this.tsManagePayments.Location = new System.Drawing.Point(23, 231);
            this.tsManagePayments.Name = "tsManagePayments";
            this.tsManagePayments.Size = new System.Drawing.Size(63, 20);
            this.tsManagePayments.TabIndex = 189;
            this.tsManagePayments.Tag = "32";
            this.tsManagePayments.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(6)))), ((int)(((byte)(44)))));
            this.tsManagePayments.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(6)))), ((int)(((byte)(44)))));
            this.tsManagePayments.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.tsManagePayments.UncheckedState.InnerColor = System.Drawing.Color.White;
            // 
            // tsManagePrescriptions
            // 
            this.tsManagePrescriptions.CheckedState.BorderColor = System.Drawing.Color.Green;
            this.tsManagePrescriptions.CheckedState.FillColor = System.Drawing.Color.Green;
            this.tsManagePrescriptions.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.tsManagePrescriptions.CheckedState.InnerColor = System.Drawing.Color.White;
            this.tsManagePrescriptions.Location = new System.Drawing.Point(23, 188);
            this.tsManagePrescriptions.Name = "tsManagePrescriptions";
            this.tsManagePrescriptions.Size = new System.Drawing.Size(63, 20);
            this.tsManagePrescriptions.TabIndex = 187;
            this.tsManagePrescriptions.Tag = "16";
            this.tsManagePrescriptions.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(6)))), ((int)(((byte)(44)))));
            this.tsManagePrescriptions.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(6)))), ((int)(((byte)(44)))));
            this.tsManagePrescriptions.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.tsManagePrescriptions.UncheckedState.InnerColor = System.Drawing.Color.White;
            // 
            // tsManageAppointments
            // 
            this.tsManageAppointments.CheckedState.BorderColor = System.Drawing.Color.Green;
            this.tsManageAppointments.CheckedState.FillColor = System.Drawing.Color.Green;
            this.tsManageAppointments.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.tsManageAppointments.CheckedState.InnerColor = System.Drawing.Color.White;
            this.tsManageAppointments.Location = new System.Drawing.Point(23, 145);
            this.tsManageAppointments.Name = "tsManageAppointments";
            this.tsManageAppointments.Size = new System.Drawing.Size(63, 20);
            this.tsManageAppointments.TabIndex = 185;
            this.tsManageAppointments.Tag = "8";
            this.tsManageAppointments.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(6)))), ((int)(((byte)(44)))));
            this.tsManageAppointments.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(6)))), ((int)(((byte)(44)))));
            this.tsManageAppointments.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.tsManageAppointments.UncheckedState.InnerColor = System.Drawing.Color.White;
            // 
            // tsManageSpecialities
            // 
            this.tsManageSpecialities.CheckedState.BorderColor = System.Drawing.Color.Green;
            this.tsManageSpecialities.CheckedState.FillColor = System.Drawing.Color.Green;
            this.tsManageSpecialities.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.tsManageSpecialities.CheckedState.InnerColor = System.Drawing.Color.White;
            this.tsManageSpecialities.Location = new System.Drawing.Point(23, 102);
            this.tsManageSpecialities.Name = "tsManageSpecialities";
            this.tsManageSpecialities.Size = new System.Drawing.Size(63, 20);
            this.tsManageSpecialities.TabIndex = 183;
            this.tsManageSpecialities.Tag = "4";
            this.tsManageSpecialities.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(6)))), ((int)(((byte)(44)))));
            this.tsManageSpecialities.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(6)))), ((int)(((byte)(44)))));
            this.tsManageSpecialities.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.tsManageSpecialities.UncheckedState.InnerColor = System.Drawing.Color.White;
            // 
            // tsManageDoctors
            // 
            this.tsManageDoctors.CheckedState.BorderColor = System.Drawing.Color.Green;
            this.tsManageDoctors.CheckedState.FillColor = System.Drawing.Color.Green;
            this.tsManageDoctors.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.tsManageDoctors.CheckedState.InnerColor = System.Drawing.Color.White;
            this.tsManageDoctors.Location = new System.Drawing.Point(23, 59);
            this.tsManageDoctors.Name = "tsManageDoctors";
            this.tsManageDoctors.Size = new System.Drawing.Size(63, 20);
            this.tsManageDoctors.TabIndex = 181;
            this.tsManageDoctors.Tag = "2";
            this.tsManageDoctors.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(6)))), ((int)(((byte)(44)))));
            this.tsManageDoctors.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(6)))), ((int)(((byte)(44)))));
            this.tsManageDoctors.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.tsManageDoctors.UncheckedState.InnerColor = System.Drawing.Color.White;
            // 
            // tc
            // 
            this.tc.Controls.Add(this.tpUserInfo);
            this.tc.Controls.Add(this.tpAccountInfo);
            this.tc.ItemSize = new System.Drawing.Size(632, 50);
            this.tc.Location = new System.Drawing.Point(28, 65);
            this.tc.Name = "tc";
            this.tc.SelectedIndex = 0;
            this.tc.Size = new System.Drawing.Size(1270, 601);
            this.tc.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty;
            this.tc.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.tc.TabButtonHoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tc.TabButtonHoverState.ForeColor = System.Drawing.Color.White;
            this.tc.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
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
            this.tc.TabButtonSize = new System.Drawing.Size(632, 50);
            this.tc.TabIndex = 96;
            this.tc.TabMenuBackColor = System.Drawing.Color.SlateBlue;
            this.tc.TabMenuOrientation = Guna.UI2.WinForms.TabMenuOrientation.HorizontalTop;
            this.tc.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tc_Selecting);
            // 
            // tpUserInfo
            // 
            this.tpUserInfo.Controls.Add(this.btnUpdatePerson);
            this.tpUserInfo.Controls.Add(this.btnNext);
            this.tpUserInfo.Controls.Add(this.ucPersonCard1);
            this.tpUserInfo.Controls.Add(this.btnSelectPerson);
            this.tpUserInfo.Location = new System.Drawing.Point(4, 54);
            this.tpUserInfo.Name = "tpUserInfo";
            this.tpUserInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tpUserInfo.Size = new System.Drawing.Size(1262, 543);
            this.tpUserInfo.TabIndex = 0;
            this.tpUserInfo.Text = "User Info";
            this.tpUserInfo.UseVisualStyleBackColor = true;
            // 
            // tpAccountInfo
            // 
            this.tpAccountInfo.Controls.Add(this.guna2GradientPanel1);
            this.tpAccountInfo.Location = new System.Drawing.Point(4, 54);
            this.tpAccountInfo.Name = "tpAccountInfo";
            this.tpAccountInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tpAccountInfo.Size = new System.Drawing.Size(1262, 543);
            this.tpAccountInfo.TabIndex = 1;
            this.tpAccountInfo.Text = "Account Info";
            this.tpAccountInfo.UseVisualStyleBackColor = true;
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.BorderRadius = 22;
            this.guna2GradientPanel1.Controls.Add(this.guna2VSeparator1);
            this.guna2GradientPanel1.Controls.Add(this.tbPassword);
            this.guna2GradientPanel1.Controls.Add(this.label1);
            this.guna2GradientPanel1.Controls.Add(this.tbUserName);
            this.guna2GradientPanel1.Controls.Add(this.label8);
            this.guna2GradientPanel1.Controls.Add(this.gbPermissions);
            this.guna2GradientPanel1.FillColor = System.Drawing.Color.LightSkyBlue;
            this.guna2GradientPanel1.FillColor2 = System.Drawing.Color.SlateBlue;
            this.guna2GradientPanel1.Location = new System.Drawing.Point(67, 17);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.Size = new System.Drawing.Size(1123, 503);
            this.guna2GradientPanel1.TabIndex = 73;
            // 
            // guna2VSeparator1
            // 
            this.guna2VSeparator1.FillThickness = 4;
            this.guna2VSeparator1.Location = new System.Drawing.Point(568, 45);
            this.guna2VSeparator1.Name = "guna2VSeparator1";
            this.guna2VSeparator1.Size = new System.Drawing.Size(10, 404);
            this.guna2VSeparator1.TabIndex = 144;
            // 
            // tbPassword
            // 
            this.tbPassword.BackColor = System.Drawing.Color.Transparent;
            this.tbPassword.BorderRadius = 23;
            this.tbPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbPassword.DefaultText = "";
            this.tbPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbPassword.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPassword.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tbPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbPassword.Location = new System.Drawing.Point(166, 287);
            this.tbPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbPassword.Multiline = true;
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '\0';
            this.tbPassword.PlaceholderText = "????";
            this.tbPassword.SelectedText = "";
            this.tbPassword.Size = new System.Drawing.Size(351, 116);
            this.tbPassword.TabIndex = 135;
            this.tbPassword.Validating += new System.ComponentModel.CancelEventHandler(this.TextBox_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(42, 309);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 23);
            this.label1.TabIndex = 134;
            this.label1.Text = "Password :";
            // 
            // tbUserName
            // 
            this.tbUserName.BackColor = System.Drawing.Color.Transparent;
            this.tbUserName.BorderRadius = 23;
            this.tbUserName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbUserName.DefaultText = "";
            this.tbUserName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbUserName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbUserName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbUserName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbUserName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbUserName.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUserName.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tbUserName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbUserName.Location = new System.Drawing.Point(166, 107);
            this.tbUserName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbUserName.Multiline = true;
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.PasswordChar = '\0';
            this.tbUserName.PlaceholderText = "????";
            this.tbUserName.SelectedText = "";
            this.tbUserName.Size = new System.Drawing.Size(351, 116);
            this.tbUserName.TabIndex = 133;
            this.tbUserName.Validating += new System.ComponentModel.CancelEventHandler(this.TextBox_Validating);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(33, 129);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 23);
            this.label8.TabIndex = 132;
            this.label8.Text = "UserName :";
            // 
            // gbPermissions
            // 
            this.gbPermissions.BackColor = System.Drawing.Color.Transparent;
            this.gbPermissions.BorderColor = System.Drawing.Color.SlateBlue;
            this.gbPermissions.BorderRadius = 23;
            this.gbPermissions.Controls.Add(this.label2);
            this.gbPermissions.Controls.Add(this.PermissionsPanel);
            this.gbPermissions.Controls.Add(this.label10);
            this.gbPermissions.Controls.Add(this.label11);
            this.gbPermissions.Controls.Add(this.tsAll);
            this.gbPermissions.Controls.Add(this.label9);
            this.gbPermissions.Controls.Add(this.label3);
            this.gbPermissions.Controls.Add(this.label4);
            this.gbPermissions.Controls.Add(this.label5);
            this.gbPermissions.Controls.Add(this.label7);
            this.gbPermissions.Controls.Add(this.label6);
            this.gbPermissions.CustomBorderColor = System.Drawing.Color.SlateBlue;
            this.gbPermissions.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(236)))), ((int)(((byte)(252)))));
            this.gbPermissions.Font = new System.Drawing.Font("Berlin Sans FB Demi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPermissions.ForeColor = System.Drawing.Color.White;
            this.gbPermissions.Location = new System.Drawing.Point(690, 20);
            this.gbPermissions.Name = "gbPermissions";
            this.gbPermissions.Size = new System.Drawing.Size(331, 453);
            this.gbPermissions.TabIndex = 2;
            this.gbPermissions.Text = "Permissions ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Berlin Sans FB", 11F);
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(51, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 21);
            this.label2.TabIndex = 195;
            this.label2.Text = "Manage Patients ";
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Berlin Sans FB Demi", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.Color.Red;
            this.lbTitle.Location = new System.Drawing.Point(518, 11);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(276, 45);
            this.lbTitle.TabIndex = 97;
            this.lbTitle.Text = "Add New User";
            // 
            // guna2ImageButton1
            // 
            this.guna2ImageButton1.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.HoverState.ImageSize = new System.Drawing.Size(35, 35);
            this.guna2ImageButton1.Image = global::ClinicManagementSystem.Properties.Resources.cancel;
            this.guna2ImageButton1.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageButton1.ImageRotate = 0F;
            this.guna2ImageButton1.ImageSize = new System.Drawing.Size(50, 50);
            this.guna2ImageButton1.Location = new System.Drawing.Point(1137, 672);
            this.guna2ImageButton1.Name = "guna2ImageButton1";
            this.guna2ImageButton1.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.Size = new System.Drawing.Size(88, 64);
            this.guna2ImageButton1.TabIndex = 98;
            this.guna2ImageButton1.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnSave.Enabled = false;
            this.btnSave.HoverState.ImageSize = new System.Drawing.Size(35, 35);
            this.btnSave.Image = global::ClinicManagementSystem.Properties.Resources.save;
            this.btnSave.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnSave.ImageRotate = 0F;
            this.btnSave.ImageSize = new System.Drawing.Size(50, 50);
            this.btnSave.Location = new System.Drawing.Point(1214, 672);
            this.btnSave.Name = "btnSave";
            this.btnSave.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnSave.Size = new System.Drawing.Size(88, 64);
            this.btnSave.TabIndex = 99;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnUpdatePerson
            // 
            this.btnUpdatePerson.BorderRadius = 23;
            this.btnUpdatePerson.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdatePerson.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdatePerson.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUpdatePerson.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUpdatePerson.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUpdatePerson.Enabled = false;
            this.btnUpdatePerson.FillColor = System.Drawing.Color.SlateBlue;
            this.btnUpdatePerson.FillColor2 = System.Drawing.Color.LightSkyBlue;
            this.btnUpdatePerson.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdatePerson.ForeColor = System.Drawing.Color.White;
            this.btnUpdatePerson.Image = global::ClinicManagementSystem.Properties.Resources.edit__1_;
            this.btnUpdatePerson.ImageSize = new System.Drawing.Size(25, 25);
            this.btnUpdatePerson.Location = new System.Drawing.Point(1061, 146);
            this.btnUpdatePerson.Name = "btnUpdatePerson";
            this.btnUpdatePerson.Size = new System.Drawing.Size(181, 57);
            this.btnUpdatePerson.TabIndex = 44;
            this.btnUpdatePerson.Text = "Update Person";
            this.btnUpdatePerson.Click += new System.EventHandler(this.btnUpdatePerson_Click);
            // 
            // btnNext
            // 
            this.btnNext.BorderRadius = 23;
            this.btnNext.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnNext.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnNext.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnNext.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnNext.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnNext.FillColor = System.Drawing.Color.SlateBlue;
            this.btnNext.FillColor2 = System.Drawing.Color.LightSkyBlue;
            this.btnNext.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.Color.White;
            this.btnNext.Image = global::ClinicManagementSystem.Properties.Resources.arrowhead;
            this.btnNext.ImageSize = new System.Drawing.Size(25, 25);
            this.btnNext.Location = new System.Drawing.Point(1061, 306);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(181, 57);
            this.btnNext.TabIndex = 43;
            this.btnNext.Text = "Next";
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // ucPersonCard1
            // 
            this.ucPersonCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(236)))), ((int)(((byte)(252)))));
            this.ucPersonCard1.Location = new System.Drawing.Point(46, 63);
            this.ucPersonCard1.Name = "ucPersonCard1";
            this.ucPersonCard1.Size = new System.Drawing.Size(985, 427);
            this.ucPersonCard1.TabIndex = 42;
            // 
            // btnSelectPerson
            // 
            this.btnSelectPerson.BorderRadius = 23;
            this.btnSelectPerson.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSelectPerson.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSelectPerson.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSelectPerson.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSelectPerson.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSelectPerson.FillColor = System.Drawing.Color.SlateBlue;
            this.btnSelectPerson.FillColor2 = System.Drawing.Color.LightSkyBlue;
            this.btnSelectPerson.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectPerson.ForeColor = System.Drawing.Color.White;
            this.btnSelectPerson.Image = global::ClinicManagementSystem.Properties.Resources.click;
            this.btnSelectPerson.ImageSize = new System.Drawing.Size(25, 25);
            this.btnSelectPerson.Location = new System.Drawing.Point(1061, 226);
            this.btnSelectPerson.Name = "btnSelectPerson";
            this.btnSelectPerson.Size = new System.Drawing.Size(181, 57);
            this.btnSelectPerson.TabIndex = 41;
            this.btnSelectPerson.Text = "Select Person";
            this.btnSelectPerson.Click += new System.EventHandler(this.btnSelectPerson_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmAddEditUserInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(236)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(1333, 739);
            this.Controls.Add(this.guna2ImageButton1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.tc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmAddEditUserInfo";
            this.Text = "Add / Edit User Info";
            this.Load += new System.EventHandler(this.frmAddUser_Load);
            this.PermissionsPanel.ResumeLayout(false);
            this.tc.ResumeLayout(false);
            this.tpUserInfo.ResumeLayout(false);
            this.tpAccountInfo.ResumeLayout(false);
            this.guna2GradientPanel1.ResumeLayout(false);
            this.guna2GradientPanel1.PerformLayout();
            this.gbPermissions.ResumeLayout(false);
            this.gbPermissions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private Guna.UI2.WinForms.Guna2ToggleSwitch tsAll;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2ToggleSwitch tsManageUsers;
        private Guna.UI2.WinForms.Guna2Panel PermissionsPanel;
        private Guna.UI2.WinForms.Guna2ToggleSwitch tsManagePatients;
        private Guna.UI2.WinForms.Guna2ToggleSwitch tsManageMedRecords;
        private Guna.UI2.WinForms.Guna2ToggleSwitch tsManagePayments;
        private Guna.UI2.WinForms.Guna2ToggleSwitch tsManagePrescriptions;
        private Guna.UI2.WinForms.Guna2ToggleSwitch tsManageAppointments;
        private Guna.UI2.WinForms.Guna2ToggleSwitch tsManageSpecialities;
        private Guna.UI2.WinForms.Guna2ToggleSwitch tsManageDoctors;
        private Guna.UI2.WinForms.Guna2TabControl tc;
        private System.Windows.Forms.TabPage tpUserInfo;
        private System.Windows.Forms.TabPage tpAccountInfo;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private Guna.UI2.WinForms.Guna2VSeparator guna2VSeparator1;
        private Guna.UI2.WinForms.Guna2TextBox tbPassword;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox tbUserName;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2GroupBox gbPermissions;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbTitle;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton1;
        private Guna.UI2.WinForms.Guna2ImageButton btnSave;
        private Guna.UI2.WinForms.Guna2GradientButton btnUpdatePerson;
        private Guna.UI2.WinForms.Guna2GradientButton btnNext;
        private UserControls.ucPersonCard ucPersonCard1;
        private Guna.UI2.WinForms.Guna2GradientButton btnSelectPerson;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}