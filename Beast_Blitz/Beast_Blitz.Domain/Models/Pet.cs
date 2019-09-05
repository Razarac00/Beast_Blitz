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

      //Returns True if pet is able to level up
      public bool AddExperience(int Exp)
      {
        BattleStats.Experience = BattleStats.Experience + Exp;
        if (BattleStats.Experience >= 100 + (50 * (BattleStats.Level - 1)))
        {
          return true;
        } else
        {
          return false; 
        }
      }

      public void LevelUpPet(string Stat)
      {
        BattleStats.Level = BattleStats.Level + 1;
        BattleStats.Experience = 0; 
        
        if (Stat.Equals("Attack"))
        {
          BattleStats.Attack = BattleStats.Attack + 5;
        } else if (Stat.Equals("Defense"))
        {
          BattleStats.Defense = BattleStats.Defense + 5;
        } else if (Stat.Equals("Speed"))
        {
          BattleStats.Speed = BattleStats.Speed + 5;
        } else if (Stat.Equals("Health"))
        {
          BattleStats.Health = BattleStats.Health + 5;
        } else if (Stat.Equals("Mana"))
        {
          BattleStats.Mana = BattleStats.Mana + 5;
        } else 
        {
          throw new Exception("Invalid Input");
        }
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