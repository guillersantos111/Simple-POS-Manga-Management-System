using PosoManagementSystem.Data_Access;
using PosoManagementSystem.Forms;
using PosoManagementSystem.Model;
using PosoManagementSystem.User_Control;
using System.Collections.Generic;
using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PosoManagementSystem.EventHandler
{
    public static class GenreDisplayHandler
    {
        public static void DisplayManga(List<MangaModels> mangaModels, FlowLayoutPanel flp_Manga, CartHandler cartEventHandler)
        {
            flp_Manga.Controls.Clear();

            foreach (var manga in mangaModels)
            {
                MangaControl mangaControl = new MangaControl(manga);
                mangaControl.OnAddToCart += (m) => cartEventHandler.AddToCart(m, 1);
                flp_Manga.Controls.Add(mangaControl);
            }
        }

        public static void HandleGenreLabelClick(Label genreLabel, FlowLayoutPanel flpManga, Action<string> filterAction)
        {
            genreLabel.Click += (sender, e) =>
            {
                string selectedGenre = genreLabel.Text;
                filterAction(selectedGenre);
            };
        }
    }
}
