using Beast_Blitz.Domain.Abstracts;

namespace Beast_Blitz.Domain.Models
{
    public class UserItem
    {
        // DATA
        public int UserID { get; set; }
        public Player Player { get; set; }
        public int ItemID { get; set; }
        public Item Item { get; set; }
    }
}