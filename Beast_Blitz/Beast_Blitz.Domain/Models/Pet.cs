using System;

namespace Beast_Blitz.Domain.Models
{
    public class Pet
    {
      public string Name { get; set; }
      public int Age { get; set; }
      public DateTime CreationDate { get; set; }
      public string Color { get; set; }

      public BattleStats BattleStats { get; set; }
      public CareStats CareStats { get; set; }

      public Species Species { get; set; }

      public Hat Hat { get; set; }
      public Armor Armor { get; set; }

      public Pet(string NewName, string NewColor, Species NewSpecies)
      {
        Name = NewName;
        Age = 0;
        CreationDate = DateTime.Now; 
        Color = NewColor;
        Species = NewSpecies;
        BattleStats = Species.BaseBattleStats;
        CareStats = Species.BaseCareStats;
      }

    }
}