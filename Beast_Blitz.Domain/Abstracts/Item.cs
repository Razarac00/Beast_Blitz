using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Beast_Blitz.Domain.Models;

namespace Beast_Blitz.Domain.Abstracts
{
    public abstract class Item
    {
        // DATA
        public int ItemID { get; set; }
        public List<UserItems> UserItems { get; set; }
        public List<ShopItems> ShopItems { get; set; }
        // Properties
        [Required(ErrorMessage = "Username is required")]
        [MaxLength(50)]
        [MinLength(1)]
        [StringLength(50, ErrorMessage = "Username must be between 5 and 25 characters", MinimumLength = 1)]
        public string Name { get; set; }

        [Required(ErrorMessage = "BuyCost is required")]
        public int BuyCost { get; set; }

        // Constants
        double SELL_PENALTY = .25; 

        // Methods
        public int SellCost()
        {
            return Convert.ToInt32(BuyCost * SELL_PENALTY);
        }
        //Constructor
        public Item(string name, int basecost)
        {
          Name = name; 
          BuyCost = basecost;
        }

        public Item()
        {
        }
    }
}