using System.Collections.Generic;
using Beast_Blitz.Domain.Abstracts;

namespace Beast_Blitz.Domain.Models
{
    public class Battlefield : Location
    {
        // Properties
        List<Enemy> Enemies;
        Boss Boss;

        // Constructor
        public Battlefield(string name, List<Enemy> enemies, Boss boss) : base(name)
        {
          Enemies = enemies;
          Boss = boss; 
        }

        // Methods 
        public bool Battle(Pet pet, Enemy enemy)
        {
          // To do
          return true; 
        }
    }
}