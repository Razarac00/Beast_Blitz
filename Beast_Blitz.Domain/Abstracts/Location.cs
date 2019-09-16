using System.ComponentModel.DataAnnotations;

namespace Beast_Blitz.Domain.Abstracts
{
    public abstract class Location
    {
        // DATA
        public int LocationID { get; set; }
        // Properties
        [Required(ErrorMessage = "Name is required")]
        [MaxLength(50)]
        [MinLength(1)]
        [StringLength(50, ErrorMessage = "Name must be between 1 and 50 characters", MinimumLength = 1)]
        public string Name { get; set; }

        // Constructor
        public Location(string name)
        {
          Name = name;
        }

        public Location()
        {
          Name = "defaultLocation";
        }
    }
}