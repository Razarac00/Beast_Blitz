using Beast_Blitz.Domain.Abstracts;

namespace Beast_Blitz.Domain.Models
{
    public class Hat : Accessory
    {
        // Properties
        public int Happiness { get; set; }

        // Constructor
        public Hat( string name, int basecost, string image, int happiness) : base(name, basecost, image)
        {
          Happiness = happiness;
        }

        public Hat()
        {
          Happiness = 4;
        }
    }
}