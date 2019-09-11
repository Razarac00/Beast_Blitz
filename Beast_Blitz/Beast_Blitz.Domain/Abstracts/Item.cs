using System;

namespace Beast_Blitz.Domain.Abstracts
{
    public abstract class Item
    {
        // Properties
        public string Name { get; set; }
        public int BuyCost { get; set; }
        public int SellCost { get; set; }

        // Constants
        double SELL_PENALTY = .25; 

        //Constructor
        public Item(string name, int basecost)
        {
          Name = name; 
          BuyCost = basecost;
          SellCost = Convert.ToInt32(BuyCost * SELL_PENALTY);
        }
    }
}