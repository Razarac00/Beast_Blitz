using Beast_Blitz.Domain.Models;
using Xunit;

namespace Beast_Blitz.Testing
{
    public class ArmorTesting
    {
      [Fact]
      public void CanBeConstructed()
      {
        //Given
        string name = "Helmet";
        int basecost = 100;
        string image = "Helmet.jpg";
        int defense = 5;
        Armor armor = new Armor(name, basecost, image, defense); 
      
        //When
        int expected = defense;
        int actual = armor.Defense; 
      
        //Then
        Assert.True(expected == actual);
      }

      [Fact]
      public void SellCost()
      {
        //Given
        string name = "Helmet";
        int basecost = 100;
        string image = "Helmet.jpg";
        int defense = 5;
        Armor armor = new Armor(name, basecost, image, defense); 

        //When
        int expected = 25; 
        int actual = armor.SellCost;
        
        //Then
        Assert.True(expected == actual);
      }
    }
}