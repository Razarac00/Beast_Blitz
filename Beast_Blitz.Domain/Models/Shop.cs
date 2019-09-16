using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Beast_Blitz.Domain.Abstracts;

namespace Beast_Blitz.Domain.Models
{
    public class Shop : Location
    {
        // Backing Field
        private List<Item> inventory = new List<Item>();
        // Properties
        protected List<Item> Inventory { get => buildInventory(); set => inventory = resetInventory(value); }
        public List<ShopItems> ShopItems { get; set; }

        // Constructors
        public Shop(string name) : base(name)
        {
        }

        public Shop(string name, List<Item> inventory) : base(name)
        {
          Inventory = inventory;
        }

        public Shop()
        {
        }

        // Methods
        private List<Item> buildInventory()
        {
            inventory = new List<Item>();

            foreach (var shopItem in ShopItems)
            {
                inventory.Add(shopItem.Item);
            }
            return inventory;
        }

        private List<Item> resetInventory(List<Item> value)
        {
            ShopItems = new List<ShopItems>();

            foreach (var item in value)
            {
                var si = new ShopItems();
                si.Item = item;
                si.LocationID = this.LocationID;
                si.Shop = this;
                ShopItems.Add(si);
            }

            return value;
        }
        
        // Return true if buy was successful
        public bool Buy(Player player, Item item)
        {
          if (Inventory.Contains(item) && player.Coins >= item.SellCost())
          {
            player.Coins = player.Coins - item.SellCost();
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
            player.Coins = player.Coins + item.SellCost();
            return true;
          } else 
          {
            return false; 
          }
        }
    }
}