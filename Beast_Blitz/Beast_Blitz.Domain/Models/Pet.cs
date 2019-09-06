using System;
using System.Collections.Generic;
using Beast_Blitz.Domain.Abstracts;

namespace Beast_Blitz.Domain.Models
{
    public class Pet
    {
      public string Name { get; set; }
      public double Age { get; set; }
      public DateTime CreationDate { get; set; }
      public int Color { get; set; }

      public BattleStats BattleStats { get; set; }
      public CareStats CareStats { get; set; }

      public Species Species { get; set; }

      public Hat Hat { get; set; }
      public Armor Armor { get; set; }

      public Pet(string NewName, int NewColor, Species NewSpecies)
      {
        Name = NewName;
        Age = 0;
        CreationDate = DateTime.Now; 
        Color = NewColor;
        Species = NewSpecies;
        BattleStats = Species.BaseBattleStats;
        CareStats = Species.BaseCareStats;
      }

      public void FeedPet(Food food)
      {
        //To Do
      }

      public void CleanPet()
      {
        CareStats.Cleanliness = CareStats.Cleanliness + 20; 
      }

      public void PlayWithPet()
      {
        CareStats.Fun = CareStats.Fun + 20; 
      }

      public void ChangeColor(int NewColor)
      {
        Color = NewColor;
      }

      public void CalculateAge()
      {
        DateTime now = DateTime.Now;
        TimeSpan difference = now.Subtract(CreationDate);
        Age = Math.Floor(difference.TotalDays);
      }

      public void EquipHat(Hat NewHat)
      {
        Hat = NewHat;
      }

      public void EquipArmor(Armor NewArmor)
      {
        Armor = NewArmor;
      }

      public void ChangeName(string NewName)
      {
        Name = NewName;
      }
    }
}