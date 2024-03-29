using Beast_Blitz.Domain.Models;
using Xunit;

namespace Beast_Blitz
{
    public class HatTesting
    {
        [Fact]
        public void CanBeConstructed()
        {
          //Given
          Hat hat = new Hat("testHat", 100, "testHat.jpg", 3);
          
          //When
          int expected = 100;
          int actual = hat.BuyCost;
          
          //Then
          Assert.True(expected == actual);
        }

        [Fact]
        public void CanBeConstructedEmpty()
        {
          //Given
          Hat hat = new Hat();
          
          //When
          int expected = 4;
          int actual = hat.Happiness;
          
          //Then
          Assert.True(expected == actual);
        }
    }
}