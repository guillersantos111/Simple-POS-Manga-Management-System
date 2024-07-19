using Microsoft.IdentityModel.Tokens;
using PosoManagementSystem.Data_Access;
using PosoManagementSystem.Designer;
using PosoManagementSystem.EventHandler;
using PosoManagementSystem.Model;
using PosoManagementSystem.User_Control;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PosoManagementSystem.Forms
{
    public partial class AddMangaForm : CustomDesigner
    {
        private MangaModels selectedManga;
        private byte[] CoverImage;
        public AddMangaForm()
        {
            InitializeComponent();
            LoadManga();
        }

        private void HandleMangaClick(MangaModels mangaModels)
        {
            selectedManga = mangaModels;
            DisplaySelectedManga();
        }

        private void btn_AddManga_Click_1(object sender, EventArgs e)
        {

            if (ValidateForm())
            {
                MangaModels _mangaModels = new MangaModels
                {
                    Title = txt_Title.Text,
                    Author = txt_Author.Text,
                    Genre = txt_Genre.Text,
                    Price = decimal.Parse(txt_Price.Text),
                    Tax = decimal.Parse(txt_Tax.Text),
                    CoverImage = CoverImage
                };

                AddMangaDBContext.AddManga(_mangaModels);
                ClearForm();
                LoadManga();
            }
        }

        private void btn_Update_Click_1(object sender, EventArgs e)
        {
            if (selectedManga != null && ValidateForm())
            {
                selectedManga.Title = txt_Title.Text;
                selectedManga.Author = txt_Author.Text;
                selectedManga.Genre = txt_Genre.Text;
                selectedManga.Price = decimal.Parse(txt_Price.Text);
                selectedManga.Tax = decimal.Parse(txt_Tax.Text);
                selectedManga.CoverImage = CoverImage;

                AddMangaDBContext.UpdateManga(selectedManga);
                ClearForm();
                LoadManga();
            }
        }

        private void btn_Delete_Click_1(object sender, EventArgs e)
        {
            if (selectedManga != null)
            {
                if (MessageBox.Show("Are Sure You Want To Delete This Manga?", "Warning",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    AddMangaDBContext.DeleteManga(selectedManga.MangaID);
                    ClearForm();
                    LoadManga();
                }
            }
        }

        private void btn_Browse_Click_1(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jp;*.jpeg;*.png;*.bmp";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    CoverImage = File.ReadAllBytes(openFileDialog.FileName);
                    pb_CoverImage.Image = Image.FromStream(new MemoryStream(CoverImage));
                }
            }
        }

        private void HandleDeleteClick(MangaModels mangaModels)
        {
            selectedManga = mangaModels;

            if (MessageBox.Show("Are you sure you want to delete this manga?", "Confirm Delete",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                AddMangaDBContext.DeleteManga(selectedManga.MangaID);
                ClearForm();
                LoadManga();
            }
        }
        private void HandleUpdateClick(MangaModels mangaModels)
        {
            selectedManga = mangaModels;
            DisplaySelectedManga();
        }

        private void LoadManga()
        {
            var mangaList = AddMangaDBContext.GetMangaList();
            flp_AddManga.Controls.Clear();

            foreach (var mangaModel in mangaList)
            {
                DisplayMangaToUI(mangaModel);
            }
        }

        private void DisplayMangaToUI(MangaModels mangaModels)
        {
            MangaControl mangaDisplay = new MangaControl(mangaModels);
            mangaDisplay.OnMangaClicked += HandleMangaClick;
            mangaDisplay.OnUpdateClicked += HandleUpdateClick;
            mangaDisplay.OnDeleteClicked += HandleDeleteClick;
            flp_AddManga.Controls.Add(mangaDisplay);
        }

        private bool ValidateForm()
        {
            if (string.IsNullOrEmpty(txt_Title.Text) ||
                string.IsNullOrEmpty(txt_Author.Text) ||
                string.IsNullOrEmpty(txt_Genre.Text) ||
                string.IsNullOrEmpty(txt_Price.Text) ||
                string.IsNullOrEmpty(txt_Tax.Text))
            {
                MessageBox.Show("All Fields Must Be Filled Out Before Adding A Manga.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!decimal.TryParse(txt_Price.Text, out _))
            {
                MessageBox.Show("Please enter a valid price.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!decimal.TryParse(txt_Tax.Text, out _))
            {
                MessageBox.Show("Please enter a valid tax.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void DisplaySelectedManga()
        {
            if (selectedManga != null)
            {
                txt_Title.Text = selectedManga.Title;
                txt_Author.Text = selectedManga.Author;
                txt_Genre.Text = selectedManga.Genre;
                txt_Price.Text = selectedManga.Price.ToString();
                txt_Tax.Text = selectedManga.Tax.ToString();

                if (selectedManga.CoverImage != null)
                {
                    using (MemoryStream ms = new MemoryStream(selectedManga.CoverImage))
                    {
                        pb_CoverImage.Image = Image.FromStream(ms);
                    }
                }
                else
                {
                    pb_CoverImage.Image = null;
                }
            }
            else
            {
                ClearForm();
            }
        }

        private void ClearForm()
        {
            txt_Title.Text = string.Empty;
            txt_Author.Text = string.Empty;
            txt_Genre.Text = string.Empty;
            txt_Price.Text = string.Empty;
            txt_Tax.Text = string.Empty;
            pb_CoverImage.Image = null;
            CoverImage = null;
            selectedManga = null;
        }

        private void pb_Clear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void btn_Home_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Hide();
        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }
    }
}
