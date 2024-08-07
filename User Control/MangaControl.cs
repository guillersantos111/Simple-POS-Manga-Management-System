using PosoManagementSystem.Model;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace PosoManagementSystem.User_Control
{
    public partial class MangaControl : UserControl
    {
        private MangaModels mangaModels;

        public MangaControl(MangaModels mangaModels)
        {
            InitializeComponent();
            this.mangaModels = mangaModels;
            LoadMangaDetails();
        }

        private void LoadMangaDetails()
        {
            lbl_ID.Text = $"#{mangaModels.MangaID}";
            lbl_Price.Text = $" {mangaModels.Price:C}";

            if (mangaModels.CoverImage != null)
            {
                using (MemoryStream ms = new MemoryStream(mangaModels.CoverImage))
                {
                    pb_CoverImage.Image = Image.FromStream(ms);
                }
            }
        }

        private void pb_CoverImage_Click_1(object sender, EventArgs e)
        {
            OnMangaClicked?.Invoke(mangaModels);
            OnAddToCart?.Invoke(mangaModels);
        }

        private void lbl_Price_Click(object sender, EventArgs e)
        {
            OnMangaClicked?.Invoke(mangaModels);
            OnAddToCart?.Invoke(mangaModels);
        }

        private void btn_Update(object sender, EventArgs e)
        {
            OnUpdateClicked?.Invoke(mangaModels);
        }

        private void btn_Delete(object sender, EventArgs e)
        {
            OnDeleteClicked?.Invoke(mangaModels);
        }

        public event Action<MangaModels> OnMangaClicked;
        public event Action<MangaModels> OnUpdateClicked;
        public event Action<MangaModels> OnDeleteClicked;
        public event Action<MangaModels> OnAddToCart;
    }
}
