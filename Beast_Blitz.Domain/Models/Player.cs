using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Beast_Blitz.Domain.Abstracts;

namespace Beast_Blitz.Domain.Models
{
  public class Player : User
  {
    // Properties 
    public List<Pet> Pets { get; set; }

    [NotMapped]
    public List<Item> Inventory { get; set; }
    public List<UserItem> UserItems { get; set; }
    public int Coins { get; set; }

    // Constants
    int MAX_PETS = 3; 

    // Constructor
    public Player(string email, string username, string password) : base(email, username, password)
    {
      Pets = new List<Pet>();
      Inventory = new List<Item>();
      Coins = 0;
    }

    public Player()
    {
    }

    // Methods
    public void AddNewPet(Species species, string color, string name)
    {
      if (Pets.Count < MAX_PETS)
      {
        Pets.Add(new Pet(species, color, name));
      }
    }

    public void AddNewPet(Pet pet)
    {
      if (Pets.Count < MAX_PETS)
      {
        Pets.Add(pet);
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