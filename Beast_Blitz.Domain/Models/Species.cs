namespace Beast_Blitz.Domain.Models
{
    public class Species
    {
        // Properties
        public string Name { get; set; }
        public Element Element { get; set; }
        public BattleStats BaseStats { get; set; }
        public string Image { get; set; }

        // Constructors
        public Species(string name, Element element, BattleStats basestats, string image)
        {
          Name = name;
          Element = element;
          BaseStats = basestats;
          Image = image;
        }

        public Species()
        {
          Name = "defaultSpecies";
          Element = new Element();
          BaseStats = new BattleStats();
          Image = "defaultSpecies.jpg";
        }
    }
}