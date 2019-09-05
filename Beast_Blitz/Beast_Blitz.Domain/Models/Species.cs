namespace Beast_Blitz.Domain.Models
{
    public class Species 
    {
      public string Name { get; set; }
      public string Sprite { get; set; }
      public BattleStats BaseBattleStats { get; set; }
      public CareStats BaseCareStats { get; set; }
      public Element Element { get; set; }
    }
}