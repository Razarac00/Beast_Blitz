using Beast_Blitz.Domain.Abstracts;

namespace Beast_Blitz.Domain.Models
{
    public class ShopItems
    {
        // DATA
        public int ShopID { get; set; }
        public Shop Shop { get; set; }
        public int ItemID { get; set; }
        public Item Item { get; set; }
    }
}