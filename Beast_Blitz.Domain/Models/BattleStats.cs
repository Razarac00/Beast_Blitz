using System;

namespace Beast_Blitz.Domain.Models
{
    public class BattleStats
    {
        // DATA
        public int BattleStatsID { get; set; }
        // Properties
        public int Speed { get; set; }
        public int Attack { get; set; }
        public int Defense { get; set; }
        public int Health { get; set; }
        public int MaxHealth { get; set; }
        public int Magic { get; set; }
        public int MaxMagic { get; set; }
        public int Level { get; set; }
        public int Experience { get; set; }
        public int ExperienceNeeded { get; set; }

        // Constants
        readonly int STAT_UP = 5;
        readonly int BASE_HEALTH = 20; 
        readonly int BASE_MAGIC = 20;
        readonly int BASE_EXPERIENCE_NEEDED = 20;

        // Constructor
        public BattleStats()
        {
          Speed = 0;
          Attack = 0;
          Defense = 0;
          Health = BASE_HEALTH;
          MaxHealth = BASE_HEALTH;
          Magic = BASE_MAGIC;
          MaxMagic = BASE_MAGIC;
          Level = 1; 
          Experience = 0;
          ExperienceNeeded = BASE_EXPERIENCE_NEEDED;
        }

        public BattleStats(int speed, int attack, int defense, int maxhealth, int maxmagic)
        {
          Speed = speed;
          Attack = attack;
          Defense = defense;
          MaxHealth = maxhealth;
          Health = MaxHealth;
          MaxMagic = maxmagic;
          Magic = MaxMagic;
          Level = 1;
          Experience = 0;
          ExperienceNeeded = BASE_EXPERIENCE_NEEDED;
        }

        // Methods
        public void LevelUp(string stat)
        {
          if (stat.Equals("Speed"))
          {
            Speed = Speed + STAT_UP;
          } else if (stat.Equals("Attack"))
          {
            Attack = Attack + STAT_UP;
          } else if (stat.Equals("Defense"))
          {
            Defense = Defense + STAT_UP;
          } else if (stat.Equals("MaxHealth"))
          {
            MaxHealth = MaxHealth + STAT_UP;
          } else if (stat.Equals("MaxMagic"))
          {
            MaxMagic = MaxMagic + STAT_UP;
          } else
          {
            throw new ArgumentException("Invalid stat name");
          }
          Level = Level + 1; 
          ExperienceNeeded = Level * BASE_EXPERIENCE_NEEDED;
          Experience = 0;
          FullHeal();
          FullRestore();
        }

        public void TakeDamage(int cost)
        {
          if (Health - cost >= 0)
          {
            Health = Health - cost;
          } else
          {
            Health = 0;
          }
        }

        public bool UseMagic(int cost)
        {
          if (Magic - cost >= 0)
          {
            Magic = Magic - cost;
            return true;
          } else
          {
            return false;
          }
        }

        public void Heal(int amt)
        {
          if (Health + amt <= MaxHealth)
          {
            Health = Health + amt;
          } else
          {
            Health = MaxHealth;
          }
        }

        public void Restore(int amt)
        {
          if (Magic + amt <= MaxMagic)
          {
            Magic = Magic + amt;
          } else
          {
            Magic = MaxMagic;
          }
        }

        public void FullHeal()
        {
          Health = MaxHealth;
        }

        public void FullRestore()
        {
          Magic = MaxMagic;
        }

        //Returns true if available to level up
        public bool AddExperience(int amt)
        {
          if (Experience + amt < ExperienceNeeded)
          {
            Experience = Experience + amt;
            return false;
          } else
          {
            Experience = ExperienceNeeded;
            return true;
          }
        }
    }
}