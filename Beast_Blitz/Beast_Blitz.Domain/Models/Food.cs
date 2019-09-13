using Beast_Blitz.Domain.Abstracts;

namespace Beast_Blitz.Domain.Models
{
    public class Food : Item
    {
        // Properties
        public int FullnessAmt { get; set; }

        // Constructor
        public Food(string name, int basecost, int fullnessamt) : base(name, basecost)
        {
          FullnessAmt = fullnessamt;
        }
    }
}