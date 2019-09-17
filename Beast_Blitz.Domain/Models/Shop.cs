using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Beast_Blitz.Domain.Abstracts;

namespace Beast_Blitz.Domain.Models
{
    public class Shop : Location
    {
        // Backing Field
        private List<Item> inventory = new List<Item>();
        private List<ShopItem> shopItems = new List<ShopItem>();

        // Properties
        [NotMapped]
        public List<Item> Inventory { get => buildInventory(); private set => inventory = resetInventory(value); }
        public List<ShopItem> ShopItems { get => shopItems; set => shopItems = value; }

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
            if (!(ShopItems != null && ShopItems.Count != 0))
            {
                ShopItems = new List<ShopItem>();

                foreach (var item in value)
                {
                    var si = new ShopItem();
                    si.Item = item;
                    si.LocationID = this.LocationID;
                    si.Shop = this;
                    ShopItems.Add(si);
                }
            }

            return buildInventory();
        }
        
        public void AddToInventory(Item item)
        {
            var result = new ShopItem();
            result.Item = item;
            result.Shop = this;
            result.LocationID = this.LocationID;
            ShopItems.Add(result);
        }

        public bool RemoveFromInventory(Item item)
        {
            if (Inventory.Contains(item))
            {
                return 1 == ShopItems.RemoveAll(si => si.Item == item);
            }

            return false;
        }

        // Return true if buy was successful
        public bool Buy(Player player, Item item)
        {
          if (Inventory.Contains(item) && player.Coins >= item.BuyCost)
          {
            player.Coins = player.Coins - item.BuyCost;
            player.AddToInventory(item);
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
            player.RemoveFromInventory(item);
            player.Coins = player.Coins + item.SellCost();
            return true;
          } else 
          {
            return false; 
          }
        }
    }
}