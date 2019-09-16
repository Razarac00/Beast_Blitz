using Beast_Blitz.Domain.Abstracts;

namespace Beast_Blitz.Domain.Models
{
  public class Admin : User
  {
    // Constructor
    public Admin(string email, string username, string password) : base(email, username, password)
    {
    }

    public Admin() 
    {
    }

    // Methods
    Species AddNewSpecies(string name, Element element, BattleStats basestats, string image)
    {
      return new Species(name, element, basestats, image);
    }

    Element AddNewElement(string name)
    {
      return new Element(name);
    }

    Shop AddNewShop(string name)
    {
      return new Shop(name);
    }

    Armor AddNewArmor(string name, int basecost, string image, int defense)
    {
      return new Armor(name, basecost, image, defense);
    }

    Food AddNewFood(string name, int basecost, int fullnessamt)
    {
      return new Food(name, basecost, fullnessamt);
    }

    Potion AddNewPotion(string name, int basecost, string stat, int amt)
    {
      return new Potion(name, basecost, stat, amt);
    }

    Treat AddNewTreat(string name, int basecost, int happinessamt)
    {
      return new Treat(name, basecost, happinessamt);
    }

    Shop AddToShop(Item item, Shop shop)
    {
      shop.Inventory.Add(item);
      return shop;
    }

    Admin AddNewAdmin(string email, string username, string password)
    {
      return new Admin(email, username, password);
    }
  }
}