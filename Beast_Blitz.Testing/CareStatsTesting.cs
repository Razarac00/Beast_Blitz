using System;
using Beast_Blitz.Domain.Models;
using Xunit;

namespace Beast_Blitz.Testing
{
    public class CareStatsTesting
    {
        [Fact]
        public void CanBeConstructed()
        {
          //Given
          CareStats carestats = new CareStats();

          //When
          int expected = 100;
          int actual = carestats.Happiness;
        
          //Then
          Assert.True(expected == actual);
        }

        [Fact]
        public void SubtractHappinessWorks()
        {
          //Given
          CareStats carestats = new CareStats();
          carestats.SubtractHappiness(50);

          //When
          int expected = 50;
          int actual = carestats.Happiness;
        
          //Then
          Assert.True(expected == actual);
        }
        
        [Fact]
        public void SubtractHappinessLimitWorks()
        {
          //Given
          CareStats carestats = new CareStats();
          carestats.SubtractHappiness(110);
          
          //When
          int expected = 0;
          int actual = carestats.Happiness;
          
          //Then
          Assert.True(expected == actual);
        }
        
        [Fact]
        public void AddHappinessWorks()
        {
          //Given
          CareStats carestats = new CareStats();
          carestats.SubtractHappiness(90);
          carestats.AddHappiness(10);
          
          //When
          int expected = 20;
          int actual = carestats.Happiness;
          
          //Then
          Assert.True(expected == actual);
        }

        [Fact]
        public void AddHappinessLimitWorks()
        {
          //Given
          CareStats carestats = new CareStats();
          carestats.AddHappiness(10);
          
          //When
          int expected = 100;
          int actual = carestats.Happiness;
          
          //Then
          Assert.True(expected == actual);
        }

        [Fact]
        public void SubtractFullnessWorks()
        {
          //Given
          CareStats carestats = new CareStats();
          carestats.SubtractFullness(50);

          //When
          int expected = 50;
          int actual = carestats.Fullness;
          
          //Then
          Assert.True(expected == actual);
        }

        [Fact]
        public void SubtractFullnessLimitWorks()
        {
          //Given
          CareStats carestats = new CareStats();
          carestats.SubtractFullness(110);
          
          //When
          int expected = 0;
          int actual = carestats.Fullness;
          
          //Then
          Assert.True(expected == actual);
        }

        [Fact]
        public void FeedWorks()
        {
          //Given
          CareStats carestats = new CareStats();
          carestats.SubtractFullness(100);
          Food food = new Food("testFood", 20, 20);
          carestats.Feed(food);
          
          //When
          int expectedFullness = 20;
          int actualFullness = carestats.Fullness;

          int expectedCleanliness = 95;
          int actualCleanliness = carestats.Cleanliness;
          
          //Then
          Assert.True(expectedFullness == actualFullness);
          Assert.True(expectedCleanliness == actualCleanliness);
        }

        [Fact]
        public void DailyDecreaseWorks()
        {
          //Given
          CareStats carestats = new CareStats();
          Food food = new Food("testFood", 20, 20);
          carestats.Feed(food);
          
          //When
          DateTime expected = DateTime.Today.Date;
          DateTime actual = carestats.LastFed;
          
          //Then
          Assert.True(expected.Equals(actual));
        }

        [Fact]
        public void CleanWorks()
        {
          //Given
          CareStats carestats = new CareStats();
          carestats.Cleanliness = 0;
          carestats.Clean();
          
          //When
          int expected = 20;
          int actual = carestats.Cleanliness;
          
          //Then
          Assert.True(expected == actual);
        }
    }
}