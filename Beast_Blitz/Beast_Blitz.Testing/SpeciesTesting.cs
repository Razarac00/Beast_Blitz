using Beast_Blitz.Domain.Models;
using Xunit;

namespace Beast_Blitz.Testing
{
    public class SpeciesTesting
    {
        [Fact]
        public void CanBeConstructed()
        {
          // Given 
          string name = "Dog";
          Element element = new Element("Fire");
          BattleStats basestats = new BattleStats();
          string image = "dog.jpg";
          Species s = new Species(name, element, basestats, image);

          // When
          string expected = name;
          string actual = s.Name;

          // Then
          Assert.True(expected == actual);
        }
    }
}