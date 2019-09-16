using System.ComponentModel.DataAnnotations;

namespace Beast_Blitz.Domain.Abstracts
{
    public abstract class User
    {
        // DATA
        public int UserID { get; set; }
        // Properties
        [Required]
        [MaxLength(100)]
        public string Email { get; set; }

        [Required]
        [MaxLength(25)]
        public string Username { get; set; }
        
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        // Constructor
        public User(string email, string username, string password) 
        {
          Email = email;
          Username = username;
          Password = password;
        }

        public User()
        {
          Email = "defaultEmail";
          Username = "defaultUsername";
          Password = "defaultPassword";
        }
    }
}