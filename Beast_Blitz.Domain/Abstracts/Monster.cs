using Beast_Blitz.Domain.Models;

namespace Beast_Blitz.Domain.Abstracts
{
    public abstract class Monster
    {
        // DATA
        public int MonsterID { get; set; }
        // Properties
        public Species Species { get; set; }
        public BattleStats BattleStats { get; set; }
        public string Color { get; set; }

        // Constructors 
        public Monster(Species species, string color) 
        {
          Species = species; 
          Color = color; 
          BattleStats = species.BaseStats;
        }

        public Monster()
        {
          Species = new Species();
          BattleStats = new BattleStats();
          Color = "defaultColor";
        }
    }
}