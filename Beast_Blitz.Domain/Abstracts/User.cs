using System.ComponentModel.DataAnnotations;

namespace Beast_Blitz.Domain.Abstracts
{
    public abstract class User
    {
        // Data
        public int UserID { get; set; }

        // Properties
        [Required(ErrorMessage = "Email is required")]
        [MaxLength(100)]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(ErrorMessage = "Username is required")]
        [MaxLength(25)]
        [MinLength(5)]
        [StringLength(25, ErrorMessage = "Username must be between 5 and 25 characters", MinimumLength = 5)]
        public string Username { get; set; }
        
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        // Constructors
        protected User(string email, string username, string password) 
        {
          Email = email;
          Username = username;
          Password = password;
        }

        protected User()
        {
        }
    }
}