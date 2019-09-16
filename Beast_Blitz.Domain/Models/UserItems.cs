using Beast_Blitz.Domain.Abstracts;

namespace Beast_Blitz.Domain.Models
{
    public class UserItems
    {
        // DATA
        public int UserID { get; set; }
        public User User { get; set; }
        public int ItemID { get; set; }
        public Item Item { get; set; }
    }
}