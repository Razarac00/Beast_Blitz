using Beast_Blitz.Domain.Models;
using Xunit;

namespace Beast_Blitz.Testing
{
    public class AdminTesting
    {
        [Fact]
        public void CanBeConstructed()
        {
          //Given
          Admin admin = new Admin("admin@test.com", "admin", "Password123");
          
          //When
          string expected = "admin";
          string actual = admin.Username;
          
          //Then
          Assert.True(expected == actual);
        }
    }
}