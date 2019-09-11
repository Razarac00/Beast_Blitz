using Beast_Blitz.Domain.Abstracts;

namespace Beast_Blitz.Domain.Models
{
  public class Admin : User
  {
    // Constructor
    public Admin(string email, string username, string password) : base(email, username, password)
    {
    }

    // Methods
    void AddNewSpecies(Species species)
    {
    }

    void AddNewElement(Element element)
    {
    }

    void AddNewShop(Shop shop)
    {
    }

    void AddNewItem(Item item)
    {
    }

    void AddToShop(Item item, Shop shop)
    {
    }

    void AddNewLocation(Location location)
    {
    }

    void AddNewEnemy(Enemy enemy)
    {
    }

    void AddNewAdmin(Admin admin)
    {
    }
  }
}