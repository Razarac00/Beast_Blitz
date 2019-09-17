using Beast_Blitz.Domain.Abstracts;
using Beast_Blitz.Domain.Models;
using Xunit;

namespace Beast_Blitz.Testing
{
    public class IndexTesting
    {
        [Fact]
        public void CanBeConsructed()
        {
          //Given
          Index index = new Index("testIndex");
          
          //When
          string expected = "testIndex";
          string actual = index.Name;
          
          //Then
          Assert.True(expected == actual);
        }

        [Fact]
        public void LogInWorks()
        {
          //Given
          Index index = new Index("testIndex");
          Admin admin = new Admin("testAdmin", "testUsername", "testPassword");
          User returnedUser = index.LogIn(admin);
          
          //When
          string expected = "testAdmin";
          string actual = returnedUser.Email;
          
          //Then
          Assert.True(expected == actual);
        }

        [Fact]
        public void RegisterWorks()
        {
          //Given
          Index index = new Index("testIndex");
          Player player = index.Register("testEmail", "testUsername", "testPassword");
          
          //When
          string expected = "testEmail";
          string actual = player.Email;
          
          //Then
          Assert.True(expected == actual);
        }
    }
}