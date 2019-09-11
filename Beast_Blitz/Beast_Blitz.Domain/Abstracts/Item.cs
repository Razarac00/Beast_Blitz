using System;

namespace Beast_Blitz.Domain.Abstracts
{
    public abstract class Item
    {
        // Properties
        string Name { get; set; }
        int BuyCost { get; set; }
        int SellCost { get; set; }

        // Constants
        double SELL_PENALTY = .25; 

        //Constructor
        public Item(string n, int bc)
        {
          Name = n; 
          BuyCost = bc;
          SellCost = Convert.ToInt32(BuyCost * SELL_PENALTY);
        }
    }
}