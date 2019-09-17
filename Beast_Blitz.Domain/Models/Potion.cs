using Beast_Blitz.Domain.Abstracts;

namespace Beast_Blitz.Domain.Models
{
    public class Potion : Item
    {
        // Properties
        public string Stat { get; set; }
        public int Amt { get; set; }

        // Constructor
        public Potion(string name, int basecost, string img, string stat, int amt) : base(name, basecost, img)
        {
          Stat = stat;
          Amt = amt; 
        }

        public Potion()
        {
          Stat = "defaultStat";
          Amt = 10;
        }
    }
}