using Beast_Blitz.Domain.Models;
using Xunit;

namespace Beast_Blitz.Testing
{
    public class PlayerTesting
    {
        [Fact]
        public void CanBeConstructed()
        {
          //Given
          Player player = new Player("testEmail", "testUsername", "testPassword");
          
          //When
          string expectedEmail = "testEmail";
          string actualEmail = player.Email;
          
          int expectedCoins = 0;
          int actualCoins = player.Coins;

          //Then
          Assert.True(expectedEmail == actualEmail);
          Assert.True(expectedCoins == actualCoins);
        }

        [Fact]
        public void AddNewPetWorks()
        {
          //Given
          Player player = new Player("testEmail", "testUsername", "testPassword");
          Species testSpecies = new Species("testSpecies", new Element("testElement"), new BattleStats(), "testImage");
          player.AddNewPet(testSpecies, "testColor", "testPet");
          
          //When
          int expected = 1;
          int actual = player.Pets.Count;
          
          //Then
          Assert.True(expected == actual);
        }

        [Fact]
        public void AddNewPetWorks1()
        {
          //Given
          Player player = new Player("testEmail", "testUsername", "testPassword");
          Species testSpecies = new Species("testSpecies", new Element("testElement"), new BattleStats(), "testImage");
          Pet testPet = new Pet(testSpecies, "testColor", "testPet");
          player.AddNewPet(testPet);
          
          //When
          int expected = 1;
          int actual = player.Pets.Count;
          
          //Then
          Assert.True(expected == actual);
        }

        [Fact]
        public void AddNewPetLimitWorks()
        {
          //Given
          Player player = new Player("testEmail", "testUsername", "testPassword");
          Species testSpecies = new Species("testSpecies", new Element("testElement"), new BattleStats(), "testImage");
          Pet testPet = new Pet(testSpecies, "testColor", "testPet");
          player.AddNewPet(testPet);
          player.AddNewPet(testPet);
          player.AddNewPet(testPet);
          player.AddNewPet(testPet);
          
          //When
          int expected = 3;
          int actual = player.Pets.Count;
          
          //Then
          Assert.True(expected == actual);
        }

        [Fact]
        public void RemovePetWorks()
        {
          //Given
          Player player = new Player("testEmail", "testUsername", "testPassword");
          Species testSpecies = new Species("testSpecies", new Element("testElement"), new BattleStats(), "testImage");
          Pet testPet = new Pet(testSpecies, "testColor", "testPet");
          player.AddNewPet(testPet);
          player.RemovePet(testPet);
          
          //When
          int expected = 0;
          int actual = player.Pets.Count;
          
          //Then
          Assert.True(expected == actual);
        }

        [Fact]
        public void RemovePetLimitWorks()
        {
          //Given
          Player player = new Player("testEmail", "testUsername", "testPassword");
          Species testSpecies = new Species("testSpecies", new Element("testElement"), new BattleStats(), "testImage");
          Pet testPet = new Pet(testSpecies, "testColor", "testPet");
          player.RemovePet(testPet);
          
          //When
          int expected = 0;
          int actual = player.Pets.Count;
          
          //Then
          Assert.True(expected == actual);
        }
    }
}