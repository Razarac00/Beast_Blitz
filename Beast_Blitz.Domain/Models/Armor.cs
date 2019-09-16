using Beast_Blitz.Domain.Abstracts;

namespace Beast_Blitz.Domain.Models
{
    public class Armor : Accessory
    {
        // Properties
        int Defense { get; set; }

        // Constructor
        public Armor( string name, int basecost, string image, int defense) : base(name, basecost, image)
        {
          Defense = defense;
        }

        public Armor()
        {
          Defense = 2;
        }
    }
}