using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PosoManagementSystem.Model
{
    public class PurchaseModels
    {
        public int PurchaseID { get; set; }
        public int MangaID { get; set; }
        public string Title { get; set; }
        public decimal TotalAmount { get; set; }
        public decimal Tax { get; set; }
        public DateTime PurchaseDate { get; set; }
    }
}
