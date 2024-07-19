using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Windows.Forms;
using PosoManagementSystem.Data_Access;
using PosoManagementSystem.Designer;
using PosoManagementSystem.EventHandler;
using PosoManagementSystem.Model;
using PosoManagementSystem.User_Control;

namespace PosoManagementSystem.Forms
{
    public partial class MainForm : CustomDesigner
    {
        private SearchHandler searchHandler;
        private bool sidebarExpand;
        private CartModels cartModels = new CartModels();
        private CartHandler cartHandler;
        public PurchaseHistoryHandler purchaseHistoryHandler;

        public MainForm()
        {
            InitializeComponent();
            InitializeCartConponents();
        }

        private void InitializeCartConponents()
        {
            cartModels = new CartModels();
            cartHandler = new CartHandler(cartModels, dgv_Cart, lbl_TotalTax, lbl_TotalAmount);
            purchaseHistoryHandler = new PurchaseHistoryHandler(lv_PurchaseHistory);
            searchHandler = new SearchHandler(tb_Search, flp_Manga, cartHandler);
            dgv_Cart.CellContentClick += dgv_Cart_CellContentClick_2;
            tb_Search.TextChanged += tb_Search_TextChanged;
            LoadGenreLabels();
            LoadManga();
        }

        private void SidebarTimer_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sidebar.Width -= 20;
                if (sidebar.Width <= sidebar.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    SideBar_Timer.Stop();
                }
            }
            else
            {
                sidebar.Width += 20;
                if (sidebar.Width >= sidebar.MaximumSize.Width)
                {
                    sidebarExpand = true;
                    SideBar_Timer.Stop();
                }
            }
        }

        private void LoadGenreLabels()
        {
            List<string> Genres = new List<string> { "Action", "Horror", "Drama", "Shonen", "Adventure", "Comedy","Mystery", 
                "Psychological", "Thriller", "Superhero", "Supernatural", "Dark Fantasy", "Fantasy", "FairyTail" };

            foreach (var Genre in Genres)
            {
                Label GenreLabel = new Label();
                GenreLabel.Text = Genre;
                flp_Genre.Controls.Add(GenreLabel);

                GenreDisplayHandler.HandleGenreLabelClick(GenreLabel, flp_Manga, FilterMangaByGenre);
            }
        }

        private void LoadManga()
        {
            var mangaModels = CartPurchaseDBContext.GetAllManga();
            flp_Manga.Controls.Clear();

            foreach (var manga in mangaModels)
            {
                DisplayMangaToUI(manga);
            }
        }

        private void FilterMangaByGenre(string genre)
        {
            var allManga = CartPurchaseDBContext.GetAllManga();
            var filteredManga = allManga.Where(manga => manga.Genre.Split(',').Select(g => g.Trim()
            ).Any(g => g.Equals(genre, StringComparison.OrdinalIgnoreCase))).ToList();
            GenreDisplayHandler.DisplayManga(filteredManga, flp_Manga, cartHandler);
        }

        private void DisplayMangaToUI(MangaModels mangaModels)
        {
            MangaControl mangaCard = new MangaControl(mangaModels);
            mangaCard.OnAddToCart += MangaCart_OnAddToCart;
            flp_Manga.Controls.Add(mangaCard);
        }

        private void dgv_Cart_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dgv_Cart.Columns["Remove"].Index)
            {
                if (e.RowIndex < dgv_Cart.Rows.Count && dgv_Cart.Rows[e.RowIndex].Cells["MangaID"].Value != null)
                {
                    int mangaID = Convert.ToInt32(dgv_Cart.Rows[e.RowIndex].Cells["MangaID"].Value);
                    cartHandler.RemoveItemFromCart(mangaID);
                }
            }
        }

        private void btn_AddToCart_Click_2(object sender, EventArgs e)
        {
            if (int.TryParse(txt_MangaID.Text, out int mangaID) && int.TryParse(txt_Quantity.Text, out int quantity))
            {
                var mangaModels = CartPurchaseDBContext.GetAllManga().FirstOrDefault(m => m.MangaID == mangaID);
                if (mangaModels != null)
                {
                    cartHandler.AddToCart(mangaModels, quantity);
                }
                else
                {
                    MessageBox.Show("Manga Not Found", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Invalid Input", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Checkout_Click(object sender, EventArgs e)
        {
            cartHandler.Checkout();
            purchaseHistoryHandler.LoadPurchaseHistory();
        }

        private void MangaCart_OnAddToCart(MangaModels mangaModels)
        {
            cartHandler.AddToCart(mangaModels, 1);
        }

        private void btn_SideBarPurchaseHistory_Click(object sender, EventArgs e)
        {
            SideBar_Timer.Start();
            purchaseHistoryHandler.LoadPurchaseHistory();
        }

        private void lv_PurchaseHistory_SelectedIndexChanged(object sender, EventArgs e)
        {
            purchaseHistoryHandler.LoadPurchaseHistory();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            searchHandler.PerformSearch(tb_Search.Text.Trim());
        }

        private void tb_Search_TextChanged(object sender, EventArgs e)
        {
            searchHandler.PerformSearch(tb_Search.Text.Trim());
        }

        private void btn_SideBarHome_Click(object sender, EventArgs e)
        {
            searchHandler.PerformSearch(tb_Search.Text.Trim());
        }

        private void pb_ClearCart_Click(object sender, EventArgs e)
        {
            cartHandler.ClearCart();
        }

        private void btn_AddProduct_Click_1(object sender, EventArgs e)
        {
            AddMangaForm addMangaForm = new AddMangaForm();
            addMangaForm.Show();
        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }
    }
}
