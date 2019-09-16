using Beast_Blitz.Domain.Models;
using Xunit;

namespace Beast_Blitz.Testing
{
    public class PetTesting
    {
        [Fact]
        public void CanBeConstructed()
        {
          //Given
          Element testElement = new Element("testElement");
          Species testSpecies = new Species("testSpecies", testElement, new BattleStats(), "testSpecies");
          Pet pet = new Pet(testSpecies, "testColor", "testName");
          
          //When
          string expected = "testName";
          string actual = pet.Name;
          
          //Then
          Assert.True(expected == actual);
        }
    }
}