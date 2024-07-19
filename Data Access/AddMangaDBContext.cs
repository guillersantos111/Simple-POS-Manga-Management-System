using PosoManagementSystem.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PosoManagementSystem.Data_Access
{
    public static class AddMangaDBContext
    {
        private static string ConnectionString = @"Data Source=DESKTOP-PKBR8TR;Initial Catalog=MyFirstProjectDB;Integrated Security=True;";

        public static void AddManga(MangaModels mangaModels)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(ConnectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand
                        ("INSERT INTO Manga (Title, Author, Genre, Price, Tax, CoverImage) " +
                        "VALUES (@Title, @Author, @Genre, @Price, @Tax, @CoverImage)", conn))
                    {
                        cmd.Parameters.AddWithValue("@Title", mangaModels.Title);
                        cmd.Parameters.AddWithValue("@Author", mangaModels.Author);
                        cmd.Parameters.AddWithValue("@Genre", mangaModels.Genre);
                        cmd.Parameters.AddWithValue("@Price", mangaModels.Price);
                        cmd.Parameters.AddWithValue("@Tax", mangaModels.Tax);

                        SqlParameter CoverImageParam = new SqlParameter("@CoverImage", SqlDbType.VarBinary);
                        CoverImageParam.Value = mangaModels.CoverImage ?? (object)DBNull.Value;
                        cmd.Parameters.Add(CoverImageParam);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error Adding Manga {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void UpdateManga(MangaModels mangaModels)
        {

            try
            {
                using (SqlConnection conn = new SqlConnection(ConnectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand
                        ("UPDATE Manga SET Title = @Title, Author = @Author, Genre = @Genre, " +
                        "Price = @Price, Tax = @Tax, CoverImage = @CoverImage WHERE MangaID = @MangaID", conn))
                    {
                        cmd.Parameters.AddWithValue("@MangaID", mangaModels.MangaID);
                        cmd.Parameters.AddWithValue("@Title", mangaModels.Title);
                        cmd.Parameters.AddWithValue("@Author", mangaModels.Author);
                        cmd.Parameters.AddWithValue("@Genre", mangaModels.Genre);
                        cmd.Parameters.AddWithValue("@Price", mangaModels.Price);
                        cmd.Parameters.AddWithValue("@Tax", mangaModels.Tax);

                        SqlParameter CoverImageParam = new SqlParameter("@CoverImage", SqlDbType.VarBinary);
                        CoverImageParam.Value = mangaModels.CoverImage ?? (object)DBNull.Value;
                        cmd.Parameters.Add(CoverImageParam);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating manga: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public static void DeleteManga(int mangaID)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(ConnectionString))
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand("DELETE FROM Cart WHERE MangaID = @MangaID", conn))
                    {
                        cmd.Parameters.AddWithValue("@MangaID", mangaID);
                        cmd.ExecuteNonQuery();
                    }

                    using (SqlCommand cmd = new SqlCommand("DELETE FROM Purchase WHERE MangaID = @MangaID", conn))
                    {
                        cmd.Parameters.AddWithValue("@MangaID", mangaID);
                        cmd.ExecuteNonQuery();
                    }

                    using (SqlCommand cmd = new SqlCommand("DELETE FROM Manga WHERE MangaID = @MangaID", conn))
                    {
                        cmd.Parameters.AddWithValue("@MangaID", mangaID);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting manga: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static List<MangaModels> GetMangaList()
        {
            List<MangaModels> mangaList = new List<MangaModels>();

            try
            {
                using (SqlConnection conn = new SqlConnection(ConnectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand
                        ("SELECT MangaID, Title, Author, Genre, Price, Tax, CoverImage FROM Manga", conn))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                MangaModels mangaModels = new MangaModels
                                {
                                    MangaID = reader.GetInt32(0),
                                    Title = reader.GetString(1),
                                    Author = reader.GetString(2),
                                    Genre = reader.GetString(3),
                                    Price = reader.GetDecimal(4),
                                    Tax = reader.GetDecimal(5),
                                    CoverImage = reader.IsDBNull(6) ? null : (byte[])reader[6]
                                };
                                mangaList.Add(mangaModels);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error fetching manga list: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return mangaList;
        }
    }
}
