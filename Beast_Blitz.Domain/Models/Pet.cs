using System;
using System.ComponentModel.DataAnnotations;
using Beast_Blitz.Domain.Abstracts;

namespace Beast_Blitz.Domain.Models
{
    public class Pet : Monster
    {
        // Backing Fields
        private DateTime birthday = DateTime.Now.Date;
        private CareStats careStats = new CareStats();
        // Properties
        [Required(ErrorMessage = "Name is required")]
        [MaxLength(50)]
        [MinLength(1)]
        [StringLength(50, ErrorMessage = "Name must be between 1 and 50 characters", MinimumLength = 1)]
        public string Name { get; set; }

        [DataType(DataType.Date)]
        public DateTime Birthday { get => birthday; protected set => birthday = value; }
        public CareStats CareStats { get => careStats; set => careStats = value; }
        
        // Constructor
        public Pet(Species species, string color, string name) : base(species, color)
        {
          Name = name;
        }

        public Pet()
        {
        }
    }
}