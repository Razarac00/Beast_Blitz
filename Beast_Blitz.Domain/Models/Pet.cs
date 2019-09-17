using System;
using System.ComponentModel.DataAnnotations;
using Beast_Blitz.Domain.Abstracts;

namespace Beast_Blitz.Domain.Models
{
    public class Pet : Monster
    {
        // Properties
        [Required(ErrorMessage = "Name is required")]
        [MaxLength(50)]
        [MinLength(1)]
        [StringLength(50, ErrorMessage = "Name must be between 1 and 50 characters", MinimumLength = 1)]
        public string Name { get; set; }

        [DataType(DataType.Date)]
        public DateTime Birthday { get; protected set; }
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