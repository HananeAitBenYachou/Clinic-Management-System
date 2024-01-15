namespace ClinicManagementSystem.ManageDoctors
{
    partial class frmAddEditDoctorInfo
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
            this.lbTitle = new System.Windows.Forms.Label();
            this.tc = new Guna.UI2.WinForms.Guna2TabControl();
            this.tpPersonalInfo = new System.Windows.Forms.TabPage();
            this.btnUpdatePerson = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnNext = new Guna.UI2.WinForms.Guna2GradientButton();
            this.ucPersonCard1 = new ClinicManagementSystem.UserControls.ucPersonCard();
            this.btnSelectPerson = new Guna.UI2.WinForms.Guna2GradientButton();
            this.tpSpecialityInfo = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.Nud = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.ucSpecialityCard1 = new ClinicManagementSystem.UserControls.ucSpecialityCard();
            this.btnClose = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btnSave = new Guna.UI2.WinForms.Guna2ImageButton();
            this.tc.SuspendLayout();
            this.tpPersonalInfo.SuspendLayout();
            this.tpSpecialityInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Nud)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Berlin Sans FB Demi", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.Color.Red;
            this.lbTitle.Location = new System.Drawing.Point(562, 8);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(319, 45);
            this.lbTitle.TabIndex = 33;
            this.lbTitle.Text = "Add New Doctor";
            // 
            // tc
            // 
            this.tc.Controls.Add(this.tpPersonalInfo);
            this.tc.Controls.Add(this.tpSpecialityInfo);
            this.tc.ItemSize = new System.Drawing.Size(659, 50);
            this.tc.Location = new System.Drawing.Point(30, 64);
            this.tc.Name = "tc";
            this.tc.SelectedIndex = 0;
            this.tc.Size = new System.Drawing.Size(1323, 609);
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
            this.tc.TabButtonSize = new System.Drawing.Size(659, 50);
            this.tc.TabIndex = 34;
            this.tc.TabMenuBackColor = System.Drawing.Color.SlateBlue;
            this.tc.TabMenuOrientation = Guna.UI2.WinForms.TabMenuOrientation.HorizontalTop;
            this.tc.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tc_Selecting);
            // 
            // tpPersonalInfo
            // 
            this.tpPersonalInfo.Controls.Add(this.btnUpdatePerson);
            this.tpPersonalInfo.Controls.Add(this.btnNext);
            this.tpPersonalInfo.Controls.Add(this.ucPersonCard1);
            this.tpPersonalInfo.Controls.Add(this.btnSelectPerson);
            this.tpPersonalInfo.Location = new System.Drawing.Point(4, 54);
            this.tpPersonalInfo.Name = "tpPersonalInfo";
            this.tpPersonalInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tpPersonalInfo.Size = new System.Drawing.Size(1315, 551);
            this.tpPersonalInfo.TabIndex = 0;
            this.tpPersonalInfo.Text = "Personal Info";
            this.tpPersonalInfo.UseVisualStyleBackColor = true;
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
            this.btnUpdatePerson.Location = new System.Drawing.Point(1097, 161);
            this.btnUpdatePerson.Name = "btnUpdatePerson";
            this.btnUpdatePerson.Size = new System.Drawing.Size(181, 57);
            this.btnUpdatePerson.TabIndex = 40;
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
            this.btnNext.Location = new System.Drawing.Point(1097, 321);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(181, 57);
            this.btnNext.TabIndex = 39;
            this.btnNext.Text = "Next";
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // ucPersonCard1
            // 
            this.ucPersonCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(236)))), ((int)(((byte)(252)))));
            this.ucPersonCard1.Location = new System.Drawing.Point(79, 76);
            this.ucPersonCard1.Name = "ucPersonCard1";
            this.ucPersonCard1.Size = new System.Drawing.Size(985, 427);
            this.ucPersonCard1.TabIndex = 38;
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
            this.btnSelectPerson.Location = new System.Drawing.Point(1097, 241);
            this.btnSelectPerson.Name = "btnSelectPerson";
            this.btnSelectPerson.Size = new System.Drawing.Size(181, 57);
            this.btnSelectPerson.TabIndex = 37;
            this.btnSelectPerson.Text = "Select Person";
            this.btnSelectPerson.Click += new System.EventHandler(this.btnSelectPerson_Click);
            // 
            // tpSpecialityInfo
            // 
            this.tpSpecialityInfo.Controls.Add(this.label1);
            this.tpSpecialityInfo.Controls.Add(this.Nud);
            this.tpSpecialityInfo.Controls.Add(this.ucSpecialityCard1);
            this.tpSpecialityInfo.Location = new System.Drawing.Point(4, 54);
            this.tpSpecialityInfo.Name = "tpSpecialityInfo";
            this.tpSpecialityInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tpSpecialityInfo.Size = new System.Drawing.Size(1315, 551);
            this.tpSpecialityInfo.TabIndex = 1;
            this.tpSpecialityInfo.Text = "Speciality";
            this.tpSpecialityInfo.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 13F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(247, 202);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "Speciality ID :";
            // 
            // Nud
            // 
            this.Nud.BackColor = System.Drawing.Color.Transparent;
            this.Nud.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Nud.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 14F);
            this.Nud.Location = new System.Drawing.Point(390, 191);
            this.Nud.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Nud.Maximum = new decimal(new int[] {
            11,
            0,
            0,
            0});
            this.Nud.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Nud.Name = "Nud";
            this.Nud.Size = new System.Drawing.Size(181, 48);
            this.Nud.TabIndex = 0;
            this.Nud.UpDownButtonFillColor = System.Drawing.Color.SlateBlue;
            this.Nud.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Nud.ValueChanged += new System.EventHandler(this.Nud_ValueChanged);
            // 
            // ucSpecialityCard1
            // 
            this.ucSpecialityCard1.BackColor = System.Drawing.Color.Transparent;
            this.ucSpecialityCard1.Location = new System.Drawing.Point(611, 91);
            this.ucSpecialityCard1.Name = "ucSpecialityCard1";
            this.ucSpecialityCard1.Size = new System.Drawing.Size(381, 330);
            this.ucSpecialityCard1.TabIndex = 1;
            // 
            // btnClose
            // 
            this.btnClose.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnClose.HoverState.ImageSize = new System.Drawing.Size(35, 35);
            this.btnClose.Image = global::ClinicManagementSystem.Properties.Resources.cancel;
            this.btnClose.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnClose.ImageRotate = 0F;
            this.btnClose.ImageSize = new System.Drawing.Size(50, 50);
            this.btnClose.Location = new System.Drawing.Point(1173, 679);
            this.btnClose.Name = "btnClose";
            this.btnClose.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnClose.Size = new System.Drawing.Size(88, 64);
            this.btnClose.TabIndex = 35;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
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
            this.btnSave.Location = new System.Drawing.Point(1250, 679);
            this.btnSave.Name = "btnSave";
            this.btnSave.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnSave.Size = new System.Drawing.Size(88, 64);
            this.btnSave.TabIndex = 36;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmAddEditDoctorInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(236)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(1387, 755);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tc);
            this.Controls.Add(this.lbTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmAddEditDoctorInfo";
            this.Text = "Add / Edit Doctor Info";
            this.Load += new System.EventHandler(this.frmAddDoctor_Load);
            this.tc.ResumeLayout(false);
            this.tpPersonalInfo.ResumeLayout(false);
            this.tpSpecialityInfo.ResumeLayout(false);
            this.tpSpecialityInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Nud)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTitle;
        private Guna.UI2.WinForms.Guna2TabControl tc;
        private System.Windows.Forms.TabPage tpPersonalInfo;
        private System.Windows.Forms.TabPage tpSpecialityInfo;
        private Guna.UI2.WinForms.Guna2ImageButton btnClose;
        private Guna.UI2.WinForms.Guna2ImageButton btnSave;
        private Guna.UI2.WinForms.Guna2GradientButton btnSelectPerson;
        private UserControls.ucPersonCard ucPersonCard1;
        private Guna.UI2.WinForms.Guna2GradientButton btnNext;
        private Guna.UI2.WinForms.Guna2NumericUpDown Nud;
        private UserControls.ucSpecialityCard ucSpecialityCard1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2GradientButton btnUpdatePerson;
    }
}