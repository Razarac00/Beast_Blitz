using Beast_Blitz.Domain.Models;
using Xunit;

namespace Beast_Blitz.Testing
{
    public class BattleStatsTesting
    {
        [Fact]
        public void CanBeConstructed()
        {
          //Given
          BattleStats bs = new BattleStats(5, 3, 8, 10, 10);
          
          //When
          int expected = 5;
          int actual = bs.Speed;
          
          //Then
          Assert.True(expected == actual);
        }

        [Fact]
        public void CanBeConstructedEmpty()
        {
          //Given
          BattleStats bs = new BattleStats();
          
          //When
          int expected = 0;
          int actual = bs.Speed;
          
          //Then
          Assert.True(expected == actual);
        }

        [Fact]
        public void LevelUpSpeedWorks()
        {
          //Given
          BattleStats bs = new BattleStats();
          bs.LevelUp("Speed");
          
          //When
          int expected = 5;
          int actual = bs.Speed;
          
          //Then
          Assert.True(expected == actual);
        }

        [Fact]
        public void LevelUpAttackWorks()
        {
          //Given
          BattleStats bs = new BattleStats();
          bs.LevelUp("Attack");
          
          //When
          int expected = 5;
          int actual = bs.Attack;
          
          //Then
          Assert.True(expected == actual);
        }

        [Fact]
        public void LevelUpDefenseWorks()
        {
          //Given
          BattleStats bs = new BattleStats();
          bs.LevelUp("Defense");
          
          //When
          int expected = 5;
          int actual = bs.Defense;
          
          //Then
          Assert.True(expected == actual);
        }

        [Fact]
        public void LevelUpMaxHealthWorks()
        {
          //Given
          BattleStats bs = new BattleStats();
          bs.LevelUp("MaxHealth");
          
          //When
          int expected = 25;
          int actual = bs.MaxHealth;
          
          //Then
          Assert.True(expected == actual);
        }

        [Fact]
        public void LevelUpMaxMagicWorks()
        {
          //Given
          BattleStats bs = new BattleStats();
          bs.LevelUp("MaxMagic");
          
          //When
          int expected = 25;
          int actual = bs.MaxMagic;
          
          //Then
          Assert.True(expected == actual);
        }

        [Fact]
        public void LevelUpErrorWorks()
        {
          //Given
          BattleStats bs = new BattleStats();
          bool errorThrown = false;
          try
          {
            bs.LevelUp("Bogus");
          }
          catch (System.Exception)
          {
            errorThrown = true;
          }
          
          //Then
          Assert.True(errorThrown);
        }

    }
}