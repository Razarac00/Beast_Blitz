using Beast_Blitz.Domain.Abstracts;

namespace Beast_Blitz.Domain.Models
{
    public class Index : Location
    {
        // Constructor
        public Index(string name) : base(name)
        {
        }

        // Methods
        public User LogIn(User user)
        {
          return user;
        }

        public Player Register(string email, string username, string password)
        {
          return new Player(email, username, password);
        }
    }
}