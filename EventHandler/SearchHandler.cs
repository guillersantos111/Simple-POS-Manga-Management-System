using PosoManagementSystem.Data_Access;
using PosoManagementSystem.EventHandler;
using PosoManagementSystem.Model;
using PosoManagementSystem.User_Control;

public class SearchHandler
{
    private TextBox tbSearch;
    private FlowLayoutPanel flpManga;
    private CartHandler cartHandler;

    public SearchHandler(TextBox searchBox, FlowLayoutPanel mangaPanel, CartHandler handler)
    {
        tbSearch = searchBox;
        flpManga = mangaPanel;
        cartHandler = handler;
        tbSearch.TextChanged += tb_Search_TextChanged;
    }

    private void tb_Search_TextChanged(object sender, EventArgs e)
    {
        PerformSearch(tbSearch.Text.Trim());
    }

    public void PerformSearch(string searchTerm)
    {
        if (string.IsNullOrEmpty(searchTerm))
        {
            LoadManga();
        }
        else
        {
            List<MangaModels> filteredManga = CartPurchaseDBContext.SearchManga(searchTerm);
            GenreDisplayHandler.DisplayManga(filteredManga, flpManga, cartHandler);
        }
    }

    private void LoadManga()
    {
        var mangaModels = CartPurchaseDBContext.GetAllManga();
        flpManga.Controls.Clear();

        foreach (var manga in mangaModels)
        {
            AddMangaToUI(manga);
        }
    }

    private void AddMangaToUI(MangaModels mangaModels)
    {
        MangaControl mangaCard = new MangaControl(mangaModels);
        mangaCard.OnAddToCart += MangaCart_OnAddToCart;
        flpManga.Controls.Add(mangaCard);
    }

    private void MangaCart_OnAddToCart(MangaModels mangaModels)
    {
        cartHandler.AddToCart(mangaModels, 1);
    }
}
