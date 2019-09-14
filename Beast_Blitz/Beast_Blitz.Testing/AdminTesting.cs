using Beast_Blitz.Domain.Models;
using Xunit;

namespace Beast_Blitz.Testing
{
    public class AdminTesting
    {
        string email = "tester@testing.test";
        string username = "tester69";
        string password = "Testing123";
      
        [Fact]
        public void CanBeConstructed()
        {
          // Given
          Admin admin = new Admin(email, username, password);
          
          // When
          string expected = email;
          string actual = admin.Email;
          
          // Then
          Assert.True(expected == actual);
        }

        [Fact]
        public void AddNewSpecies()
        {
          // Given
          Admin admin = new Admin(email, username, password);
          string name = "Raichu";
          Element element = new Element("Electric");
          BattleStats battlestats = new BattleStats();
          string img = "Raichu.png";
          Species s = admin.AddNewSpecies(name, element, battlestats, img);

          // When
          // Species expected = new Species(name, element, battlestats, img);
          // Species actual = s; 
          string expected = name;
          string actual = s.Name;

          // Then
          Assert.True(expected.Equals(actual));
        }
    }
}