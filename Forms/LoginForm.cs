using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using PosoManagementSystem.Controller_Design;
using PosoManagementSystem.Data_Access;
using PosoManagementSystem.Forms;
using PosoManagementSystem.Designer;

namespace PosoManagementSystem
{
    public partial class LoginForm : Form
    {
        private AuthenticationDBContext db;

        public LoginForm()
        {
            InitializeComponent();
            db = new AuthenticationDBContext();
        }
        private void Login_BTN_Click(object sender, EventArgs e)
        {
            string username = tb_username.Text;
            string password = tb_password.Text;

            if (db.Authentication(username, password))
            {
                MainForm mainForm = new MainForm();
                mainForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Username or Password", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            tb_password.PasswordChar = Login_ShowPassword.Checked ? '\0' : '*';
        }
        private void SignUp_BTN_Click(object sender, EventArgs e)
        {
            SignupForm signupForm = new SignupForm();
            signupForm.Show();
            this.Hide();
        }
        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void lbl_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lbl_ForgotPassword_Click(object sender, EventArgs e)
        {
            ForgotPasswordForm forgotPasswordForm = new ForgotPasswordForm();
            forgotPasswordForm.Show();
        }
    }
}
