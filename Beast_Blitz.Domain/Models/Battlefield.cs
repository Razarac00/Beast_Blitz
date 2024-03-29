using System.Collections.Generic;
using Beast_Blitz.Domain.Abstracts;

namespace Beast_Blitz.Domain.Models
{
    public class Battlefield : Location
    {
        // Properties
        public List<Enemy> Enemies { get; set; }
        public Boss Boss { get; set; }

        // Constructors
        public Battlefield(string name, List<Enemy> enemies, Boss boss) : base(name)
        {
          Enemies = enemies;
          Boss = boss; 
        }

        public Battlefield() : base("Battlefield")
        {
        }

        // Methods 
        public bool Battle(Pet pet, Enemy enemy)
        {
          // To do
          return true; 
        }
    }
}