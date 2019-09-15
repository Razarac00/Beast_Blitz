using Beast_Blitz.Domain.Abstracts;

namespace Beast_Blitz.Domain.Models
{
    public class Home : Location
    {
        // Properties

        // Constructor 
        public Home(string name) : base(name)
        {
        }

        // Methods
        public void Feed(Pet pet, Food food)
        {
          // To do
        }

        public void Clean(Pet pet)
        {
          // To do
        }
    }
}