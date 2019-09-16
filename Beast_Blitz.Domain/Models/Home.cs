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

        public Home()
        {
        }

        // Methods
        public void Feed(Pet pet, Food food)
        {
          pet.CareStats.Feed(food);
        }

        public void Clean(Pet pet)
        {
          pet.CareStats.Clean();
        }
    }
}