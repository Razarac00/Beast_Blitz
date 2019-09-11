namespace Beast_Blitz.Domain.Abstracts
{
    public abstract class User
    {
        // Properties
        public string Email { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        // Constructor
        public User(string e, string u, string p) 
        {
          Email = e;
          Username = u;
          Password = p;
        }
    }
}