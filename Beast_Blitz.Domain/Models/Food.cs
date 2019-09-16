using Beast_Blitz.Domain.Abstracts;

namespace Beast_Blitz.Domain.Models
{
    public class Food : Item
    {
        // Properties
        public int FullnessAmt { get; set; }

        // Constructor
        public Food(string name, int basecost, string img, int fullnessamt) : base(name, basecost, img)
        {
          FullnessAmt = fullnessamt;
        }

        public Food()
        {
          FullnessAmt = 10; 
        }
    }
}