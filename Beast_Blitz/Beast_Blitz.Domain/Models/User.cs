using System.Collections.Generic;

namespace Beast_Blitz.Domain.Models
{
  public class User
  {
      public string Username { get; set; }
      public string Email { get; set; }
      public string Password { get; set; }
      public List<Pet> Pets { get; set; }
      public List<Hat> Hats { get; set; }
      public List<Armor> Armor { get; set; }
      public List<Food> Food { get; set; }
  }
}