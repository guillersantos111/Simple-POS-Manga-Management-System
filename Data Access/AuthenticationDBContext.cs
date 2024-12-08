using PosoManagementSystem.Model;
using System;
using System.Data;
using System.Data.SqlClient;

namespace PosoManagementSystem.Data_Access
{
    public class AuthenticationDBContext
    {
        private string ConnectionString = @"Data Source=;Initial Catalog=;Integrated Security=True;";

        public bool Authentication(string username, string password)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(ConnectionString))
                {
                    conn.Open();

                    String query = "SELECT COUNT(1) FROM Account WHERE username = @username AND password = @password";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("Password", password);

                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    return count > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public bool CheckUsernameTaken(string Username)
        {
            string query = "SELECT COUNT (account_id) FROM Account WHERE username = @username";
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@username", Username);

                    int count = (int)cmd.ExecuteScalar();
                    return count > 1;
                }
            }
        }
        public bool ResgisterAcount(AccountModels accountModels)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(ConnectionString))
                {
                    conn.Open();

                    string query = "INSERT INTO Account(firstname, lastname, username, password) VALUES (@firstname, @lastname, @username, @password)";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@firstname", accountModels.firstname);
                    cmd.Parameters.AddWithValue("@lastname", accountModels.lastname);
                    cmd.Parameters.AddWithValue("@username", accountModels.username);
                    cmd.Parameters.AddWithValue("@password", accountModels.password);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public string GetResetToken(string username)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(ConnectionString))
                {
                    conn.Open();

                    string query = "SELECT ResetToken FROM Account WHERE username = @Username";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Username", username);

                    object result = cmd.ExecuteScalar();
                    return result != null ? result.ToString() : null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }


        public bool RequestPasswordReset(string username)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(ConnectionString))
                {
                    conn.Open();

                    string resetToken = Guid.NewGuid().ToString();
                    DateTime resetExpiry = DateTime.Now.AddHours(1);

                    string query = "UPDATE Account SET ResetToken = @ResetToken, ResetTokenExpiry = @ResetExpiry WHERE username = @Username";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@ResetToken", resetToken);
                    cmd.Parameters.AddWithValue("@ResetExpiry", resetExpiry);
                    cmd.Parameters.AddWithValue("@Username", username);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }


        public bool ResetPassword(string username, string newPassword, string resetToken)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(ConnectionString))
                {
                    conn.Open();

                    string queryCheckToken = "SELECT COUNT(1) FROM Account WHERE username = @Username AND ResetToken = @ResetToken AND ResetTokenExpiry > @CurrentDate";
                    SqlCommand cmdCheckToken = new SqlCommand(queryCheckToken, conn);
                    cmdCheckToken.Parameters.AddWithValue("@Username", username);
                    cmdCheckToken.Parameters.AddWithValue("@ResetToken", resetToken);
                    cmdCheckToken.Parameters.AddWithValue("@CurrentDate", DateTime.Now);

                    int tokenValid = Convert.ToInt32(cmdCheckToken.ExecuteScalar());

                    if (tokenValid > 0)
                    {
                        string queryResetPassword = "UPDATE Account SET password = @NewPassword, ResetToken = NULL, ResetTokenExpiry = NULL WHERE username = @Username";
                        SqlCommand cmdResetPassword = new SqlCommand(queryResetPassword, conn);
                        cmdResetPassword.Parameters.AddWithValue("@NewPassword", newPassword);
                        cmdResetPassword.Parameters.AddWithValue("@Username", username);

                        int rowsAffected = cmdResetPassword.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                    else
                    {
                        MessageBox.Show("Invalid or expired reset token. Please request a new password reset.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

    }
}
