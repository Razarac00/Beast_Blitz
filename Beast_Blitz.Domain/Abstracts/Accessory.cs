using System;

namespace Beast_Blitz.Domain.Abstracts
{
    public abstract class Accessory : Item
    {
        // Properties 
        string Image { get; set; }

        // Constructors
        protected Accessory(string name, int basecost, string image) : base(name, basecost)
        {
          Image = image;
        }

        protected Accessory()
        {
          Image = "defaultImage";
        }
    }
}