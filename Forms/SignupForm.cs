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
using PosoManagementSystem.Data_Access;
using PosoManagementSystem.Model;
using PosoManagementSystem.Designer;


namespace PosoManagementSystem.Controller_Design
{
    public partial class SignupForm : Form
    {
        private AuthenticationDBContext db;
        public SignupForm()
        {
            InitializeComponent();
            db = new AuthenticationDBContext();
        }
        private void Signup_BTN_Click(object sender, EventArgs e)
        {
            string Username = tb_username.Text.Trim();
            if (db.CheckUsernameTaken(Username))
            {
                MessageBox.Show("Username is already Taken", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            AccountModels accountModels = new AccountModels
            {
                firstname = tb_firstname.Text,
                lastname = tb_lastname.Text,
                username = tb_username.Text,
                password = tb_password.Text,
            };

            if (db.ResgisterAcount(accountModels))
            {
                MessageBox.Show("Sign Up Successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                tb_firstname.Text = "";
                tb_lastname.Text = "";
                tb_username.Text = "";
                tb_password.Text = "";
            }
            else
            {
                MessageBox.Show("Error Registration", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Signup_ShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            tb_password.PasswordChar = Signup_ShowPassword.Checked ? '\0' : '*';
        }

        private void Login_BTN2_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }

        private void lbl_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
