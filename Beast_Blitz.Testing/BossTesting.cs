using Beast_Blitz.Domain.Models;
using Xunit;

namespace Beast_Blitz.Testing
{
    public class BossTesting
    {
        [Fact]
        public void CanBeConstructed()
        {
          //Given
          Species species = new Species("testSpecies", new Element("testElement"), new BattleStats(), "testImg");
          Treat treat = new Treat("testTreat", 10, 10, "testTreatImg");
          Boss boss = new Boss(species, "testColor", 100, treat);
          
          //When
          string expected = "testColor";
          string actual = boss.Color;
          
          //Then
          Assert.True(expected == actual);
        }

        [Fact]
        public void CanBeConstructedEmpty()
        {
          //Given
          Boss boss = new Boss();
          
          //When
          int expected = 10;
          int actual = boss.CoinReward;
          
          //Then
          Assert.True(expected == actual);
        }
    }
}