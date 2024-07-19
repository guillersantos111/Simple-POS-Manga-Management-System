using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using PosoManagementSystem.Model;

namespace PosoManagementSystem.Data_Access
{
    public class CartPurchaseDBContext
    {
        private static string ConnectionString = @"Data Source=DESKTOP-PKBR8TR;Initial Catalog=MyFirstProjectDB;Integrated Security=True;";

        public static List<MangaModels> GetAllManga()
        {
            List<MangaModels> mangaModels = new List<MangaModels>();

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                string query = "SELECT MangaID, Title, Author, Genre, Price, Tax, CoverImage FROM Manga";
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    MangaModels mangamodels = new MangaModels
                    {
                        MangaID = reader.GetInt32(0),
                        Title = reader.GetString(1),
                        Author = reader.GetString(2),
                        Genre = reader.GetString(3),
                        Price = reader.GetDecimal(4),
                        Tax = reader.GetDecimal(5),
                        CoverImage = reader["CoverImage"] as byte[]
                    };
                    mangaModels.Add(mangamodels);
                }
            }
            return mangaModels;
        }

        public static List<PurchaseModels> GetPurchaseList()
        {
            List<PurchaseModels> purchaseModels = new List<PurchaseModels>();

            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT MangaID, Title, TotalAmount, Tax, PurchaseDate FROM Purchase ORDER BY PurchaseDate DESC", conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    PurchaseModels _purchaseModels = new PurchaseModels
                    {
                        MangaID = reader["MangaID"] != DBNull.Value ? (int)reader["MangaID"] : 0,
                        Title = reader["Title"] != DBNull.Value ? reader["Title"].ToString() : string.Empty,
                        TotalAmount = reader["TotalAmount"] != DBNull.Value ? (decimal)reader["TotalAmount"] : 0,
                        Tax = reader["Tax"] != DBNull.Value ? (decimal)reader["Tax"] : 0,
                        PurchaseDate = reader["PurchaseDate"] != DBNull.Value ? (DateTime)reader["PurchaseDate"] : DateTime.MinValue
                    };
                    purchaseModels.Add(_purchaseModels);
                }
            }
            return purchaseModels;
        }

        public static List<MangaModels> SearchManga(string searchTerm)
        {
            List<MangaModels> filteredManga = new List<MangaModels>();

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                string query = "SELECT MangaID, Title, Author, Genre, Price, Tax, " +
                    "CoverImage FROM Manga WHERE Title LIKE @searchTerm";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@searchTerm", $"%{searchTerm}%");
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    MangaModels manga = new MangaModels
                    {
                        MangaID = reader.GetInt32(0),
                        Title = reader.GetString(1),
                        Author = reader.GetString(2),
                        Genre = reader.GetString(3),
                        Price = reader.GetDecimal(4),
                        Tax = reader.GetDecimal(5),
                        CoverImage = reader["CoverImage"] as byte[]
                    };
                    filteredManga.Add(manga);
                }
            }
            return filteredManga;
        }

        public static void AddToCart(MangaModels mangaModels, int quantity)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Cart (MangaID, Title, Quantity, Tax, Price)" +
                    " VALUES (@MangaID, @Title, @Quantity, @Tax, @Price)", conn);
                cmd.Parameters.AddWithValue("@MangaID", mangaModels.MangaID);
                cmd.Parameters.AddWithValue("@Title", mangaModels.Title);
                cmd.Parameters.AddWithValue("@Quantity", quantity);
                cmd.Parameters.AddWithValue("@Tax", mangaModels.Tax);
                cmd.Parameters.AddWithValue("@Price", mangaModels.Price);
                cmd.ExecuteNonQuery();
            }
        }

        public static void Checkout(CartModels cartmodels)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                SqlTransaction transaction = conn.BeginTransaction();

                try
                {
                    foreach (var item in cartmodels.Items)
                    {
                        SqlCommand insertcmd = new SqlCommand("INSERT INTO Purchase (MangaID, Title, TotalAmount, Tax, PurchaseDate)" +
                             "VALUES (@MangaID, @Title, @TotalAmount, @Tax, @PurchaseDate); SELECT SCOPE_IDENTITY()", conn, transaction);

                        insertcmd.Parameters.AddWithValue("@MangaID", item.MangaID);
                        insertcmd.Parameters.AddWithValue("@Title", item.Title ?? (object)DBNull.Value);
                        insertcmd.Parameters.AddWithValue("@TotalAmount", cartmodels.TotalAmount);
                        insertcmd.Parameters.AddWithValue("@Tax", cartmodels.Tax);
                        insertcmd.Parameters.AddWithValue("@PurchaseDate", DateTime.Now);

                        int purchaseID = Convert.ToInt32(insertcmd.ExecuteScalar());
                    }

                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    transaction.Rollback();
                    throw;
                }
            }
        }
    }
}
