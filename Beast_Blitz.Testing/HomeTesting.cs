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
          Home home = new Home("Test's Home");
          Pet pet = new Pet(new Species("testSpecies", new Element("testElement"), new BattleStats(), "testImg"), "testColor", "testPet");
          pet.CareStats.Fullness = 0;
          Food food = new Food("testFood", 20, "testImg", 20);
          home.Feed(pet, food);

          //When
          int expected = 20;
          int actual = pet.CareStats.Fullness;
          
          //Then
          Assert.True(expected == actual);
        }

        [Fact]
        public void CleanWorks()
        {
          //Given
          Home home = new Home("testHome");
          Pet pet = new Pet(new Species("testSpecies", new Element("testElement"), new BattleStats(), "testImg"), "testColor", "testPet");
          pet.CareStats.Cleanliness = 0;
          home.Clean(pet);
          
          //When
          int expected = 20;
          int actual = pet.CareStats.Cleanliness;
          
          //Then
          Assert.True(expected == actual);
        }
    }
}