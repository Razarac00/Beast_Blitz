using Beast_Blitz.Domain.Models;
using Xunit;

namespace Beast_Blitz.Testing
{
    public class FoodTesting
    {
        [Fact]
        public void CanBeConstructed()
        {
          //Given
          Food food = new Food("testFood", 20, "testImg", 20);

          //When
          string expected = "testFood";
          string actual = food.Name;

          //Then
          Assert.True(expected == actual);
        }

        [Fact]
        public void CanBeConstructedEmpty()
        {
          //Given
          Food food = new Food();
          
          //When
          int expected = 10;
          int actual = food.FullnessAmt;
          
          //Then
          Assert.True(expected == actual);
        }
    }
}