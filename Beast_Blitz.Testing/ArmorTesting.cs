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
          Armor armor = new Armor("testArmor", 10, "testArmor.jpg", 10);
          
          //When
          string expected = "testArmor";
          string actual = armor.Name;
          
          //Then
          Assert.True(expected == actual);
        }
    }
}