using System.Collections.Generic;
using System.Linq;

namespace PosoManagementSystem.Model
{
    public class CartModels
    {
        public class CartItem
        {
            public int MangaID { get; set; }
            public string Title { get; set; }
            public int Quantity { get; set; }
            public byte[] CoverImage { get; set; }
            public decimal Price { get; set; }
            public decimal Tax { get; set; }
        }

        public List<CartItem> Items { get; set; } = new List<CartItem>();
        public decimal Tax => Items.Sum(item => item.Tax * item.Quantity);
        public decimal TotalAmount => Items.Sum(item => item.Price * item.Quantity);

        public void AddItem(MangaModels mangaModels, int quantity)
        {
            var existingItem = Items.FirstOrDefault(item => item.MangaID == mangaModels.MangaID);
            if (existingItem != null)
            {
                existingItem.Quantity += quantity;
            }
            else
            {
                Items.Add(new CartItem
                {
                    MangaID = mangaModels.MangaID,
                    Title = mangaModels.Title,
                    Quantity = quantity,
                    CoverImage = mangaModels.CoverImage,
                    Tax = mangaModels.Tax,
                    Price = mangaModels.Price
                });
            }
        }

        public void RemoveItem(int mangaID)
        {
            var itemToRemove = Items.FirstOrDefault(item => item.MangaID == mangaID);
            if (itemToRemove != null)
            {
                Items.Remove(itemToRemove);
            }
        }

        public void ClearItems()
        {
            Items.Clear();
        }
    }
}
