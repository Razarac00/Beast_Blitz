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
        public void LogIn()
        {
        }

        public void Register(string email, string username, string password)
        {
          //save to db
          Player NewPlayer = new Player(email, username, password);
        }
    }
}