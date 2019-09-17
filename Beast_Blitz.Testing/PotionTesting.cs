using Beast_Blitz.Domain.Models;
using Xunit;

namespace Beast_Blitz.Testing
{
    public class PotionTesting
    {
        [Fact]
        public void CanBeConstructed()
        {
          //Given
          Potion potion = new Potion("testPotion", 10, "testImage", "Health", 4);
          
          //When
          string expected = "testPotion";
          string actual = potion.Name;
          
          //Then
          Assert.True(expected == actual);
        }

        [Fact]
        public void CanBeConstructedEmpty()
        {
          //Given
          Potion potion = new Potion();
          
          //When
          string expected = null;
          string actual = potion.Name;
          
          //Then
          Assert.True(expected == actual);
        }
    }
}