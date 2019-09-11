namespace Beast_Blitz.Domain.Abstracts
{
    public abstract class Monster
    {
        // Properties
        Species Species { get; set; }
        Element Element { get; set; }
        BattleStats BattleStats { get; set; }
        string Color { get; set; }

        // Constructors 
        public Monster(Species s, Element e, string c) 
        {
          Species = s; 
          Element = e; 
          Color = c; 
          BattleStats = s.BaseStats;
        }
    }
}