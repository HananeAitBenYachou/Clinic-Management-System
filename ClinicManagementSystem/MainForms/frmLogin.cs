using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClinicBusinessLayer;
using ClinicManagementSystem.Properties;
using Guna.UI2.WinForms;

namespace ClinicManagementSystem
{
    public partial class frmLogin : Form
    {
        public bool IsLoginSucceeded = false;

        private bool _ShowPassword = false;

        private byte _LoginTrails = 3;

        private byte _LockTimeSeconds = 5;

        public frmLogin()
        {
            InitializeComponent();       
        }

        private void pbShowPassword_Click(object sender, EventArgs e)
        {
            if (!_ShowPassword)
            {
                tbPassword.PasswordChar = '\0';
                pbShowPassword.Image = Properties.Resources.view;
                _ShowPassword = true;
            }

            else
            {
                tbPassword.PasswordChar = '*';
                pbShowPassword.Image = Properties.Resources.hide;
                _ShowPassword = false;
            }
        }

        private void TextBox_Validating(object sender, CancelEventArgs e)
        {
            Guna2TextBox textBox = (Guna2TextBox)sender;

            if (string.IsNullOrEmpty(textBox.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(textBox, "This field is required !");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(textBox, "");
            }
        }

        private bool _ValidateTextBox(Guna2TextBox textBox)
        {
            CancelEventArgs cancelEventArgs = new CancelEventArgs();
            TextBox_Validating(textBox, cancelEventArgs);
            return (!cancelEventArgs.Cancel);
        }

        private void _RefreshSignInPage()
        {
            pbIcon.Visible = false;
            lbInvalidLoginMsg.Visible = false;
            tbUserName.ResetText();
            tbPassword.ResetText();
            _LoginTrails = 3;
        }
   
        private void _SignIn()
        {
            clsGlobal.CurrentUser = clsUser.Find(tbUserName.Text, tbPassword.Text);
               
            if(clsGlobal.CurrentUser == null)
            {
                if (--_LoginTrails == 0)
                {
                    MessageBox.Show("Your are Locked after 3 failed trails. \n Please wait a few seconds before trying again !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    _RefreshSignInPage();
                    this.Enabled = false;
                    pbShowPassword.BackColor = Color.FromArgb(232, 228, 228);
                    timer1.Start();
                    return;
                }

                lbInvalidLoginMsg.Text = $"Invalid login credentials ,{_LoginTrails} Trail(s) are left !\n";
                
                pbIcon.Visible = true;
                lbInvalidLoginMsg.Visible = true;
            }

            else
            {             
                IsLoginSucceeded = true;
                this.Close();
            }
            
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            if (_ValidateTextBox(tbUserName) && _ValidateTextBox(tbPassword))
            _SignIn();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(_LockTimeSeconds > 0)
            {
                _LockTimeSeconds--;
            }

            else
            {
                timer1.Stop();
                this.Enabled = true;
                pbShowPassword.BackColor = Color.White;
                _LockTimeSeconds = 5;
            }
        }

        private void pbClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
