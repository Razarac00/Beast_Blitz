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
          Food f = new Food("testFood", 10, 10);
          
          //When
          var expected = "testFood";
          var actual = f.Name;
          
          //Then
          Assert.True(expected == actual);
        }
    }
}