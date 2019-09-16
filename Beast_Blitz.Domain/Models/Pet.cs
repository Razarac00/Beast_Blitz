using System;
using Beast_Blitz.Domain.Abstracts;

namespace Beast_Blitz.Domain.Models
{
    public class Pet : Monster
    {
        // Properties
        public string Name { get; set; }
        public DateTime Birthday { get; }
        public CareStats CareStats { get; set; }
        
        // Constructor
        public Pet(Species species, string color, string name) : base(species, color)
        {
          Name = name;
          Birthday = DateTime.Now.Date;
          CareStats = new CareStats();
        }

        public Pet()
        {
        }
    }
}