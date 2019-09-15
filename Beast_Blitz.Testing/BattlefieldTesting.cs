using System.Collections.Generic;
using Beast_Blitz.Domain.Models;
using Xunit;

namespace Beast_Blitz.Testing
{
    public class BattlefieldTesting
    {
        [Fact]
        public void CanBeConstructed()
        {
          //Given
          Element testElement = new Element("testElement");
          BattleStats testBaseStats = new BattleStats();
          Species testSpecies = new Species("testSpecies", testElement, testBaseStats, "testSpecies.png");
          Armor testArmor = new Armor("testArmor", 100, "testArmor.png", 3);
          List<Enemy> enemies = new List<Enemy>();
          enemies.Add(new Enemy(testSpecies, "testColor1", 100));
          enemies.Add(new Enemy(testSpecies, "testColor2", 100));
          Boss boss = new Boss(testSpecies, "testColor3", 200, testArmor);

          Battlefield battlefield = new Battlefield("testBattlefield", enemies, boss);
          
          //When
          string expected = "testColor3";
          string actual = battlefield.Boss.Color;
          
          //Then
          Assert.True(expected == actual);
        }
    }
}