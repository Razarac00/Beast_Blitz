using Beast_Blitz.Domain.Abstracts;

namespace Beast_Blitz.Domain.Models
{
    public class Potion : Item
    {
        // Properties
        public string Stat { get; set; }
        public int Amt { get; set; }

        // Constructor
        public Potion(string name, int basecost, string stat, int amt) : base(name, basecost)
        {
          Stat = stat;
          Amt = amt; 
        }
    }
}