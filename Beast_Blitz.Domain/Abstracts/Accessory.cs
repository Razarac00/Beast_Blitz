using System;
using System.ComponentModel.DataAnnotations;

namespace Beast_Blitz.Domain.Abstracts
{
    public abstract class Accessory : Item
    {
        // Properties 
        [DataType(DataType.Text, ErrorMessage = "Image must be text")]
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