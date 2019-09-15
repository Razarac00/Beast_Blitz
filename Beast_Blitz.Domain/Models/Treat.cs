using Beast_Blitz.Domain.Abstracts;

namespace Beast_Blitz.Domain.Models
{
    public class Treat : Item
    {
        // Properties
        public int HappinessAmt { get; set; }
        
        // Constructor
        public Treat(string name, int basecost, int happinessamt) : base(name, basecost)
        {
          HappinessAmt = happinessamt;
        }

        public Treat()
        {
          HappinessAmt = 10;
        }
    }
}