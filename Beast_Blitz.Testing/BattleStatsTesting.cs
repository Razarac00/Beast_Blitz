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

        [Fact]
        public void BattleStatsIDWorks()
        {
          //Given
          BattleStats bs = new BattleStats();
          bs.BattleStatsID = 10;
          
          //When
          int expected = 10;
          int actual = bs.BattleStatsID;
          
          //Then
          Assert.True(expected == actual);
        }

        [Fact]
        public void TakeDamageWorks()
        {
          //Given
          BattleStats bs = new BattleStats();
          bs.TakeDamage(10);
          
          //When
          int expected = 10;
          int actual = bs.Health;
          
          //Then
          Assert.True(expected == actual);
        }

        [Fact]
        public void TakeDamageLimitWorks()
        {
          //Given
          BattleStats bs = new BattleStats();
          bs.TakeDamage(30);
          
          //When
          int expected = 0;
          int actual = bs.Health;
          
          //Then
          Assert.True(expected == actual);
        }

        [Fact]
        public void UseMagicWorks()
        {
          //Given
          BattleStats bs = new BattleStats();
          bs.UseMagic(10);
          
          //When
          int expected = 10;
          int actual = bs.Magic;
          
          //Then
          Assert.True(expected == actual);
        }

        [Fact]
        public void UseMagicLimitWorks()
        {
          //Given
          BattleStats bs = new BattleStats();
          bool mg = bs.UseMagic(30);
          
          //Then
          Assert.False(mg);
        }

        [Fact]
        public void HealWorks()
        {
          //Given
          BattleStats bs = new BattleStats();
          bs.TakeDamage(20);
          bs.Heal(10);
          
          //When
          int expected = 10;
          int actual = bs.Health;
          
          //Then
          Assert.True(expected == actual);
        }

        [Fact]
        public void HealLimitWorks()
        {
          //Given
          BattleStats bs = new BattleStats();
          bs.TakeDamage(20);
          bs.Heal(30);
          
          //When
          int expected = 20;
          int actual = bs.Health;
          
          //Then
          Assert.True(expected == actual);
        }

        [Fact]
        public void RestoreWorks()
        {
          //Given
          BattleStats bs = new BattleStats();
          bs.UseMagic(20);
          bs.Restore(10);
          
          //When
          int expected = 10;
          int actual = bs.Magic;
          
          //Then
          Assert.True(expected == actual);
        }

        [Fact]
        public void RestoreLimitWorks()
        {
          //Given
          BattleStats bs = new BattleStats();
          bs.UseMagic(20);
          bs.Restore(30);
          
          //When
          int expected = 20;
          int actual = bs.Magic;
          
          //Then
          Assert.True(expected == actual);
        }

        [Fact]
        public void FullHealWorks()
        {
          //Given
          BattleStats bs = new BattleStats();
          bs.TakeDamage(20);
          bs.FullHeal();
          
          //When
          int expected = 20;
          int actual = bs.Health;
          
          //Then
          Assert.True(expected == actual);
        }

        [Fact]
        public void FullRestoreWorks()
        {
          //Given
          BattleStats bs = new BattleStats();
          bs.UseMagic(20);
          bs.FullRestore();
          
          //When
          int expected = 20;
          int actual = bs.Magic;
          
          //Then
          Assert.True(expected == actual);
        }

        [Fact]
        public void AddExperienceWorks()
        {
          //Given
          BattleStats bs = new BattleStats();
          
          //When
          bool exp = bs.AddExperience(10);
          
          //Then
          Assert.False(exp);
        }
    }
}