using System;

namespace Beast_Blitz.Domain.Abstracts
{
    public abstract class Accessory : Item
    {
        // Properties 
        string Image { get; set; }

        // Constructor
        public Accessory(string name, int basecost, string image) : base(name, basecost)
        {
          Image = image;
        }
    }
}