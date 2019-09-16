using System;
using System.ComponentModel.DataAnnotations;

namespace Beast_Blitz.Domain.Abstracts
{
    public abstract class Accessory : Item
    {
        // Constructors
        protected Accessory(string name, int basecost, string image) : base(name, basecost, image)
        {
        }

        protected Accessory()
        {
        }
    }
}