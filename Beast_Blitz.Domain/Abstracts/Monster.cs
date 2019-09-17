using System.ComponentModel.DataAnnotations;
using Beast_Blitz.Domain.Models;

namespace Beast_Blitz.Domain.Abstracts
{
    public abstract class Monster
    {
        // Data
        public int MonsterID { get; set; }

        // Properties
        // [Required(ErrorMessage = "Species is required")]
        public Species Species { get; set; }
        public BattleStats BattleStats { get; set; }

        [Required(ErrorMessage = "Color is required")]
        public string Color { get; set; }

        // Constructors 
        protected Monster(Species species, string color) 
        {
          Species = species; 
          Color = color; 
          BattleStats = species.BaseStats;
        }

        protected Monster()
        {
          Species = new Species();
          BattleStats = new BattleStats();
          Color = "defaultColor";
        }
    }
}