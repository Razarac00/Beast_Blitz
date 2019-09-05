using System;

namespace Beast_Blitz.Domain.Abstracts
{
    public abstract class Accessory
    {
      private int _basePrice = 100;  
      public string Name { get; set; } 
      public int Price { get => _basePrice; set => _basePrice = value; }
      public string Color { get; set; }

      public virtual int SellingPrice()
      {
          decimal result = Price / 2;
          return (int) Math.Ceiling(result);
      }
    }
}