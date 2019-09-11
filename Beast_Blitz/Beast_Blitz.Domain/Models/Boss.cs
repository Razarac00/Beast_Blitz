using Beast_Blitz.Domain.Abstracts;

namespace Beast_Blitz.Domain.Models
{
    public class Boss : Enemy
    {
        // Properties
        public Item Reward { get; set; }

        // Constructor
        public Boss(Species species, string color, int coinreward, Item item) : base(species, color, coinreward)
        {
          Reward = item;
        }
    }
}