namespace Beast_Blitz.Domain.Abstracts
{
    public abstract class User
    {
        // DATA
        public int UserID { get; set; }
        // Properties
        public string Email { get; set; }
        public string Username { get; set; }
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