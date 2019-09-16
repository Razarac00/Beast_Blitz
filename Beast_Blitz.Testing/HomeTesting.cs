using Beast_Blitz.Domain.Models;
using Xunit;

namespace Beast_Blitz.Testing
{
    public class HomeTesting
    {
        [Fact]
        public void CanBeConstructed()
        {
          //Given
          Home home = new Home("Test's Home");
          
          //When
          string expected = "Test's Home";
          string actual = home.Name;
          
          //Then
          Assert.True(expected == actual);
        }

        [Fact]
        public void FeedWorks()
        {
          //Given
          
          //When
          
          //Then
        }
    }
}