using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Beast_Blitz.Domain.Abstracts;

namespace Beast_Blitz.Domain.Models
{
  public class Player : User
  {

    // Backing Fields
    private List<UserItem> userItems = new List<UserItem>();
    private List<Item> inventory = new List<Item>();
    private List<Pet> pets = new List<Pet>();
    // Properties 
    public List<Pet> Pets { get => pets; set => pets = value; }

    [NotMapped]
    public List<Item> Inventory { get => buildInventory(); private set => inventory = resetInventory(value); }
    public List<UserItem> UserItems { get => userItems; set => userItems = value; }
    public int Coins { get; set; }

    // Constants
    readonly int MAX_PETS = 3; 

    // Constructor
    public Player(string email, string username, string password) : base(email, username, password)
    {
      Coins = 0;
    }

    public Player()
    {
    }

    // Methods
    private List<Item> buildInventory()
    {
        inventory = new List<Item>();

        foreach (var userItem in UserItems)
        {
            inventory.Add(userItem.Item);
        }
        return inventory;
    }

    private List<Item> resetInventory(List<Item> value)
    {
        if (!(UserItems != null && UserItems.Count != 0))
        {
            UserItems = new List<UserItem>();

            foreach (var item in value)
            {
                var ui = new UserItem();
                ui.Item = item;
                ui.UserID = this.UserID;
                ui.Player = this;
                UserItems.Add(ui);
            }
        }

        return buildInventory();
    }
    public void AddToInventory(Item item)
    {
        var result = new UserItem();
        result.Item = item;
        result.Player = this;
        result.UserID = this.UserID;
        UserItems.Add(result);
    }

    public bool RemoveFromInventory(Item item)
    {
        if (Inventory.Contains(item))
        {
            return 1 == UserItems.RemoveAll(si => si.Item == item);
        }

        return false;
    }
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