namespace Beast_Blitz.Domain.Models
{
  public class Attack
  {
      // Properties
      public string Name { get; set; }
      public int LevelRequirement { get; set; }
      public int MagicRequirement { get; set; }
      public int Damage { get; set; }
      public Element Element { get; set; }

      // Constructors
      public Attack(string name, int levelrequirment, int magicrequirement, int damage, Element element)
      {
        Name = name;
        LevelRequirement = levelrequirment;
        MagicRequirement = magicrequirement;
        Damage = damage; 
        Element = element;
      }

      public Attack(string name, int levelrequirment, int magicrequirement, int damage)
      {
        Name = name;
        LevelRequirement = levelrequirment;
        MagicRequirement = magicrequirement;
        Damage = damage; 
        Element = new Element("None");
      }
  }   
}