namespace ClinicManagementSystem.ManageSpecialities
{
    partial class frmShowSpecialityInfo
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
            this.ucSpecialityCard1 = new ClinicManagementSystem.UserControls.ucSpecialityCard();
            this.SuspendLayout();
            // 
            // ucSpecialityCard1
            // 
            this.ucSpecialityCard1.BackColor = System.Drawing.Color.Transparent;
            this.ucSpecialityCard1.Location = new System.Drawing.Point(17, 34);
            this.ucSpecialityCard1.Name = "ucSpecialityCard1";
            this.ucSpecialityCard1.Size = new System.Drawing.Size(437, 351);
            this.ucSpecialityCard1.TabIndex = 0;
            // 
            // frmShowSpecialityInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(236)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(473, 432);
            this.Controls.Add(this.ucSpecialityCard1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmShowSpecialityInfo";
            this.Text = "Speciality Info";
            this.Load += new System.EventHandler(this.frmShowSpecialityInfo_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private UserControls.ucSpecialityCard ucSpecialityCard1;
    }
}