using System.Collections.Generic;
using Beast_Blitz.Domain.Abstracts;

namespace Beast_Blitz.Domain.Models
{
  public class Player : User
  {
    // Properties 
    List<Pet> Pets { get; set; }
    List<Item> Inventory { get; set; }
    int Coins { get; set; }

    // Constants
    int MAX_PETS = 3; 

    // Constructor
    public Player(string email, string username, string password) : base(email, username, password)
    {
      Pets = new List<Pet>();
      Inventory = new List<Item>();
      Coins = 0;
    }

    // Methods
    public void AddNewPet(Species species, Element element, string color, string name)
    {
      if (Pets.Count < MAX_PETS)
      {
        Pets.Add(new Pet(species, element, color, name));
      }
    }

    public void RemovePet(Pet pet)
    {
      if (Pets.Count > 0)
      {
        Pets.Remove(pet);
      }
    }
  }
}