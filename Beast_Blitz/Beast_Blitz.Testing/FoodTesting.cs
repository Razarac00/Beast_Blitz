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
        Food food = new Food("testFood", 10, 10);

        //When
        string expected = "testFood";
        string actual = food.Name;

        //Then
        Assert.True(expected == actual);
      }
    }
}