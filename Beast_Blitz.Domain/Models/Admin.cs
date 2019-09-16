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
    public Species AddNewSpecies(string name, Element element, BattleStats basestats, string image)
    {
      return new Species(name, element, basestats, image);
    }

    public Element AddNewElement(string name)
    {
      return new Element(name);
    }

    public Shop AddNewShop(string name)
    {
      return new Shop(name);
    }

    public Armor AddNewArmor(string name, int basecost, string image, int defense)
    {
      return new Armor(name, basecost, image, defense);
    }

    public Food AddNewFood(string name, int basecost, string img, int fullnessamt)
    {
      return new Food(name, basecost, img, fullnessamt);
    }

    public Potion AddNewPotion(string name, int basecost, string img, string stat, int amt)
    {
      return new Potion(name, basecost, img, stat, amt);
    }

    public Treat AddNewTreat(string name, int basecost, string img, int happinessamt)
    {
      return new Treat(name, basecost, happinessamt, img);
    }

    public Shop AddToShop(Item item, Shop shop)
    {
      shop.Inventory.Add(item);
      return shop;
    }

    public Admin AddNewAdmin(string email, string username, string password)
    {
      return new Admin(email, username, password);
    }
  }
}