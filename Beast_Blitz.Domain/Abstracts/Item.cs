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
        public List<UserItem> UserItems { get; set; }
        public List<ShopItem> ShopItems { get; set; }

        // Properties
        [Required(ErrorMessage = "Username is required")]
        [MaxLength(50)]
        [MinLength(1)]
        [StringLength(50, ErrorMessage = "Username must be between 5 and 25 characters", MinimumLength = 1)]
        public string Name { get; set; }

        [Required(ErrorMessage = "BuyCost is required")]
        public int BuyCost { get; set; }

        [DataType(DataType.Text, ErrorMessage = "Image must be text")]
        string Image { get; set; }

        // Constants
        readonly double SELL_PENALTY = .25; 

        //Constructor
        protected Item(string name, int basecost, string img)
        {
          Name = name; 
          BuyCost = basecost;
          Image = img;
        }

        protected Item()
        {
        }

        // Methods
        public int SellCost()
        {
            return Convert.ToInt32(BuyCost * SELL_PENALTY);
        }
    }
}