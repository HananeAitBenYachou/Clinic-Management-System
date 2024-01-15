namespace ClinicManagementSystem
{
    partial class frmAddEditPersonInfo
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

        /// <summary
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbPersonID = new System.Windows.Forms.Label();
            this.guna2ImageButton8 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.label7 = new System.Windows.Forms.Label();
            this.lbTitle = new System.Windows.Forms.Label();
            this.ucAddEditPersonInfo1 = new ClinicManagementSystem.ucAddEditPersonInfo();
            this.SuspendLayout();
            // 
            // lbPersonID
            // 
            this.lbPersonID.AutoSize = true;
            this.lbPersonID.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 16F);
            this.lbPersonID.ForeColor = System.Drawing.Color.Red;
            this.lbPersonID.Location = new System.Drawing.Point(270, 85);
            this.lbPersonID.Name = "lbPersonID";
            this.lbPersonID.Size = new System.Drawing.Size(58, 34);
            this.lbPersonID.TabIndex = 30;
            this.lbPersonID.Text = "N/A";
            // 
            // guna2ImageButton8
            // 
            this.guna2ImageButton8.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton8.HoverState.ImageSize = new System.Drawing.Size(19, 19);
            this.guna2ImageButton8.Image = global::ClinicManagementSystem.Properties.Resources.pass;
            this.guna2ImageButton8.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageButton8.ImageRotate = 0F;
            this.guna2ImageButton8.ImageSize = new System.Drawing.Size(25, 25);
            this.guna2ImageButton8.Location = new System.Drawing.Point(192, 89);
            this.guna2ImageButton8.Name = "guna2ImageButton8";
            this.guna2ImageButton8.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton8.Size = new System.Drawing.Size(30, 30);
            this.guna2ImageButton8.TabIndex = 29;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(79, 94);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 25);
            this.label7.TabIndex = 28;
            this.label7.Text = "Person ID :";
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Berlin Sans FB Demi", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.Color.Red;
            this.lbTitle.Location = new System.Drawing.Point(430, 8);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(320, 45);
            this.lbTitle.TabIndex = 34;
            this.lbTitle.Text = "Add New Person";
            // 
            // ucAddEditPersonInfo1
            // 
            this.ucAddEditPersonInfo1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(236)))), ((int)(((byte)(252)))));
            this.ucAddEditPersonInfo1.Location = new System.Drawing.Point(54, 127);
            this.ucAddEditPersonInfo1.Name = "ucAddEditPersonInfo1";
            this.ucAddEditPersonInfo1.Size = new System.Drawing.Size(1089, 420);
            this.ucAddEditPersonInfo1.TabIndex = 31;
            // 
            // frmAddEditPersonInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(236)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(1201, 576);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.ucAddEditPersonInfo1);
            this.Controls.Add(this.lbPersonID);
            this.Controls.Add(this.guna2ImageButton8);
            this.Controls.Add(this.label7);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmAddEditPersonInfo";
            this.Text = "Add/Edit Person Info";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbPersonID;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton8;
        private System.Windows.Forms.Label label7;
        private ucAddEditPersonInfo ucAddEditPersonInfo1;
        private System.Windows.Forms.Label lbTitle;
    }
}