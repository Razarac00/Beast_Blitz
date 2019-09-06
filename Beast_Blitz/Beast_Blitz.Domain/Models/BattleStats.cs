using System;

namespace Beast_Blitz.Domain.Models
{
    public class BattleStats
    {
        const int LEVEL_UP_VALUE = 5;
        const int MAX_XP_BASE = 100;
        const int MAX_XP_MULTIPLIER = 50;
        public int Health { get; set; }
        public int MaxHealth { get; set; }
        public int MaxMana { get; set; }
        public int Mana { get; set; }
        public int Attack { get; set; }
        public int Speed { get; set; }
        public int Defense { get; set; }
        public int Level { get; set; }
        public int Experience { get; set; }

        public void LevelUpPet(string Stat)
      {
        Level = Level + 1;
        Experience = 0; 
        
        if (Stat.Equals("Attack"))
        {
          Attack = Attack + LEVEL_UP_VALUE;
        } else if (Stat.Equals("Defense"))
        {
          Defense = Defense + LEVEL_UP_VALUE;
        } else if (Stat.Equals("Speed"))
        {
          Speed = Speed + LEVEL_UP_VALUE;
        } else if (Stat.Equals("Health"))
        {
          Health = Health + LEVEL_UP_VALUE;
        } else if (Stat.Equals("Mana"))
        {
          Mana = Mana + LEVEL_UP_VALUE;
        } else 
        {
          throw new Exception("Invalid Input");
        }
      }

      //Returns True if pet is able to level up
      public bool AddExperience(int Exp)
      {
        Experience = Experience + Exp;
        if (Experience >= MAX_XP_BASE + (MAX_XP_MULTIPLIER * (Level - 1)))
        {
          return true;
        } else
        {
          return false; 
        }
      }

      public void TakeDamage(int Damage)
      {
        Health = Health - Damage;
      }

      public void UseMana(int Cost)
      {
        Mana = Mana - Cost;
      }
      
      public void FillHealth()
      {
        Health = MaxHealth;
      }

      public void FillMana()
      {
        Mana = MaxMana;
      }

      //Return true if pet has fainted 
      public bool Faint()
      {
        if (Health >= 0)
        {
          return true; 
        } else 
        {
          return false; 
        }
      }
    }
}