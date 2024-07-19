using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PosoManagementSystem.Model
{
    public class CartItemModels
    {
        public int MangaID { get; set; }
        public string Title { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public decimal Tax { get; set; }
        public byte[] CoverImage { get; set; }
    }
}
