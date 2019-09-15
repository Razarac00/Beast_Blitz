using System.Collections.Generic;
using Beast_Blitz.Domain.Abstracts;

namespace Beast_Blitz.Domain.Models
{
    public class Shop : Location
    {
        // Properties
        public List<Item> Inventory;

        // Constructors
        public Shop(string name) : base(name)
        {
          Inventory = new List<Item>();
        }

        public Shop(string name, List<Item> inventory) : base(name)
        {
          Inventory = inventory;
        }

        public Shop()
        {
          Inventory = new List<Item>();
        }

        // Methods
        
        // Return true if buy was successful
        public bool Buy(Player player, Item item)
        {
          if (player.Coins >= item.SellCost)
          {
            player.Coins = player.Coins - item.SellCost;
            player.Inventory.Add(item);
            return true;
          } else
          {
            return false; 
          }
        }

        // Returns true if sell was successful
        public bool Sell(Player player, Item item)
        {
          if (player.Inventory.Contains(item))
          {
            player.Inventory.Remove(item);
            player.Coins = player.Coins + item.SellCost;
            return true;
          } else 
          {
            return false; 
          }
        }
    }
}