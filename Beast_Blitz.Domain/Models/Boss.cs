using Beast_Blitz.Domain.Abstracts;

namespace Beast_Blitz.Domain.Models
{
    public class Boss : Enemy
    {
        // Properties
        public Item Reward { get; set; }

        // Constructors
        public Boss(Species species, string color, int coinreward, Item item) : base(species, color, coinreward)
        {
          Reward = item;
        }

        public Boss()
        {
          Species = new Species();
          Color = "defaultColor";
          CoinReward = 10;
          Reward = new Armor(); 
        }
    }
}