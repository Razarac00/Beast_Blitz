namespace Beast_Blitz.Domain.Models
{
    public class Enemy : Pet
    {
      public decimal Multiplier { get; set; }

      public Enemy(string NewName, string NewColor, Species NewSpecies) : base(NewName, NewColor, NewSpecies)
      {

      }
    }
}