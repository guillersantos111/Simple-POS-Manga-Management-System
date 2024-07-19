namespace PosoManagementSystem.Model
{
    public class MangaModels
    {
        public int MangaID { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Genre { get; set; }
        public decimal Price { get; set; }
        public decimal Tax { get; set; }
        public int Stock { get; set; }
        public byte[] CoverImage { get; set; }
    }
}
