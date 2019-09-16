using System;

namespace Beast_Blitz.Domain.Abstracts
{
    public abstract class Item
    {
        // DATA
        public int ItemID { get; set; }
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

        public Item()
        {
          Name = "defaultItem";
          BuyCost = 10;
          SellCost = 5;
        }
    }
}