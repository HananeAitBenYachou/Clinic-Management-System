namespace ClinicManagementSystem.ManagePeople
{
    partial class frmFindPerson
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
            this.btnSearchPerson = new Guna.UI2.WinForms.Guna2ImageButton();
            this.tbPersonIDToSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnAddPerson = new Guna.UI2.WinForms.Guna2ImageButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnClose = new Guna.UI2.WinForms.Guna2GradientButton();
            this.label1 = new System.Windows.Forms.Label();
            this.ucPersonCard1 = new ClinicManagementSystem.UserControls.ucPersonCard();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSearchPerson
            // 
            this.btnSearchPerson.HoverState.ImageSize = new System.Drawing.Size(30, 30);
            this.btnSearchPerson.Image = global::ClinicManagementSystem.Properties.Resources.search_profile;
            this.btnSearchPerson.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnSearchPerson.ImageRotate = 0F;
            this.btnSearchPerson.ImageSize = new System.Drawing.Size(40, 40);
            this.btnSearchPerson.Location = new System.Drawing.Point(916, 76);
            this.btnSearchPerson.Name = "btnSearchPerson";
            this.btnSearchPerson.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnSearchPerson.ShadowDecoration.Depth = 20;
            this.btnSearchPerson.Size = new System.Drawing.Size(55, 55);
            this.btnSearchPerson.TabIndex = 38;
            this.btnSearchPerson.Click += new System.EventHandler(this.btnSearchPerson_Click);
            // 
            // tbPersonIDToSearch
            // 
            this.tbPersonIDToSearch.BackColor = System.Drawing.Color.Transparent;
            this.tbPersonIDToSearch.BorderRadius = 23;
            this.tbPersonIDToSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbPersonIDToSearch.DefaultText = "";
            this.tbPersonIDToSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbPersonIDToSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbPersonIDToSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbPersonIDToSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbPersonIDToSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbPersonIDToSearch.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 12F);
            this.tbPersonIDToSearch.ForeColor = System.Drawing.Color.Black;
            this.tbPersonIDToSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbPersonIDToSearch.IconLeft = global::ClinicManagementSystem.Properties.Resources.search;
            this.tbPersonIDToSearch.Location = new System.Drawing.Point(149, 81);
            this.tbPersonIDToSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbPersonIDToSearch.Name = "tbPersonIDToSearch";
            this.tbPersonIDToSearch.PasswordChar = '\0';
            this.tbPersonIDToSearch.PlaceholderText = "Search";
            this.tbPersonIDToSearch.SelectedText = "";
            this.tbPersonIDToSearch.Size = new System.Drawing.Size(735, 50);
            this.tbPersonIDToSearch.TabIndex = 80;
            this.tbPersonIDToSearch.Tag = "";
            this.tbPersonIDToSearch.Validating += new System.ComponentModel.CancelEventHandler(this.tbPersonIDToSearch_Validating);
            // 
            // btnAddPerson
            // 
            this.btnAddPerson.HoverState.ImageSize = new System.Drawing.Size(30, 30);
            this.btnAddPerson.Image = global::ClinicManagementSystem.Properties.Resources.addPerson;
            this.btnAddPerson.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnAddPerson.ImageRotate = 0F;
            this.btnAddPerson.ImageSize = new System.Drawing.Size(40, 40);
            this.btnAddPerson.Location = new System.Drawing.Point(976, 76);
            this.btnAddPerson.Name = "btnAddPerson";
            this.btnAddPerson.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnAddPerson.ShadowDecoration.Depth = 20;
            this.btnAddPerson.Size = new System.Drawing.Size(55, 55);
            this.btnAddPerson.TabIndex = 35;
            this.btnAddPerson.Click += new System.EventHandler(this.btnAddPerson_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnClose
            // 
            this.btnClose.BorderRadius = 23;
            this.btnClose.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClose.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClose.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClose.FillColor = System.Drawing.Color.SlateBlue;
            this.btnClose.FillColor2 = System.Drawing.Color.LightSkyBlue;
            this.btnClose.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Image = global::ClinicManagementSystem.Properties.Resources.times_square;
            this.btnClose.ImageSize = new System.Drawing.Size(30, 30);
            this.btnClose.Location = new System.Drawing.Point(887, 577);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(181, 57);
            this.btnClose.TabIndex = 40;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Berlin Sans FB Demi", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(460, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 45);
            this.label1.TabIndex = 41;
            this.label1.Text = "Find Person";
            // 
            // ucPersonCard1
            // 
            this.ucPersonCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(236)))), ((int)(((byte)(252)))));
            this.ucPersonCard1.Location = new System.Drawing.Point(85, 144);
            this.ucPersonCard1.Name = "ucPersonCard1";
            this.ucPersonCard1.Size = new System.Drawing.Size(985, 427);
            this.ucPersonCard1.TabIndex = 39;
            // 
            // frmFindPerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(236)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(1155, 646);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.ucPersonCard1);
            this.Controls.Add(this.btnSearchPerson);
            this.Controls.Add(this.tbPersonIDToSearch);
            this.Controls.Add(this.btnAddPerson);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmFindPerson";
            this.Text = "Find Person";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2TextBox tbPersonIDToSearch;
        private Guna.UI2.WinForms.Guna2ImageButton btnAddPerson;
        private Guna.UI2.WinForms.Guna2ImageButton btnSearchPerson;
        private UserControls.ucPersonCard ucPersonCard1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private Guna.UI2.WinForms.Guna2GradientButton btnClose;
        private System.Windows.Forms.Label label1;
    }
}