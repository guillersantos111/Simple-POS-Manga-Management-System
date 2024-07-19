using System;
using System.Windows.Forms;
using PosoManagementSystem.Designer;
using PosoManagementSystem.Data_Access;

namespace PosoManagementSystem.Forms
{
    public partial class ForgotPasswordForm : CustomDesigner
    {
        private AuthenticationDBContext db;
        private string resetToken;

        public ForgotPasswordForm()
        {
            InitializeComponent();
            db = new AuthenticationDBContext();
        }

        private void lbl_Exit__Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btn_ResetPassword_Click(object sender, EventArgs e)
        {
            string username = tb_username.Text;
            string newPassword = tb_NewPassword.Text;
            string confirmPassword = tb_ConfirmPassword.Text;

            if (newPassword != confirmPassword)
            {
                MessageBox.Show("Passwords do not match. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (db.RequestPasswordReset(username))
            {
                resetToken = db.GetResetToken(username);
                if (!string.IsNullOrEmpty(resetToken))
                {
                    if (db.ResetPassword(username, newPassword, resetToken))
                    {
                        MessageBox.Show("Password reset successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Failed to reset password. Please try again later.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Failed to retrieve reset token. Please try again later.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Username not found or unable to initiate password reset.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ForgotPassword_ShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            tb_NewPassword.PasswordChar = ForgotPassword_ShowPassword.Checked ? '\0' : '*';
            tb_ConfirmPassword.PasswordChar = ForgotPassword_ShowPassword.Checked ? '\0' : '*';
        }
    }
}
