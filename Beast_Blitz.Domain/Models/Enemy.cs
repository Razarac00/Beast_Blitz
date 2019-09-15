using Beast_Blitz.Domain.Abstracts;

namespace Beast_Blitz.Domain.Models
{
    public class Enemy : Monster
    {
        // Properties
        public int CoinReward { get; set; }

        // Constructor
        public Enemy(Species species, string color, int coinreward) : base(species, color)
        {
          CoinReward = coinreward; 
        }

        public Enemy()
        {
          CoinReward = 10;
        }
    }
}