using System.Collections.Generic;

namespace Beast_Blitz.Domain.Models
{
    public class AttackSet
    {
        // Properties
        List<Attack> Attacks;

        // Constructor
        public AttackSet(BattleStats battleStats)
        {

        }

        public void UpdateSet(BattleStats battleStats)
        {

        }

        public List<Attack> FullAttackList()
        {
          List<Attack> FullAttackList = new List<Attack>();
          
          // Attack(string name, int levelrequirment, int magicrequirement, int damage, Element element)

          // Non-elemental attacks
          Element None = new Element("None"); 
          FullAttackList.Add(new Attack("Tackle", 0, 0, 2, None));
          FullAttackList.Add(new Attack("Pound", 1, 5, 5, None));
          FullAttackList.Add(new Attack("Blast", 5, 10, 15, None));
          FullAttackList.Add(new Attack("Curb-Stomp", 10, 20, 30, None));

          // Fire Attacks
          Element Fire = new Element("Fire");

          // Water Attacks
          Element Water = new Element("Water");

          // Wind Attacks
          Element Wind = new Element("Wind");

          // Earth Attacks 
          Element Earth = new Element("Earth");
          
          return FullAttackList;
        }
    }
}