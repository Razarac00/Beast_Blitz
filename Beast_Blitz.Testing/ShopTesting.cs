using System.Collections.Generic;
using Beast_Blitz.Domain.Abstracts;
using Beast_Blitz.Domain.Models;
using Xunit;

namespace Beast_Blitz.Testing
{
    public class ShopTesting
    {
        [Fact]
        public void CanBeConstructedEmpty()
        {
          //Given
          Shop shop = new Shop("testShop");
          
          //When
          string expectedName = "testShop";
          string actualName = shop.Name;

          int expectedInventory = 0;
          int actualInventory = shop.Inventory.Count;
          
          //Then
          Assert.True(expectedName == actualName);
          Assert.True(expectedInventory == actualInventory);
        }

        [Fact]
        public void CanBeConstructedWithList()
        {
          //Given
          List<Item> inv = new List<Item>();
          Armor testArmor = new Armor();
          Treat testTreat = new Treat();
          inv.Add(testArmor);
          inv.Add(testTreat);
          Shop shop = new Shop("testShop", inv);
          
          //When
          int expected = 2;
          int actual = shop.Inventory.Count;
          
          //Then
          Assert.True(expected == actual);
        }

        [Fact]
        public void BuyWorks()
        {
          //Given
          Shop shop = new Shop();
          Armor testArmor = new Armor("testArmor", 10, "testArmor", 4);
          shop.Inventory.Add(testArmor);

          Player player = new Player("testEmail", "testUsername", "testPassword");
          player.Coins = 20;

          shop.Buy(player, testArmor);
          
          //When
          bool expectedInventory = true;
          bool actualInventory = player.Inventory.Contains(testArmor);

          int expectedCoins = 10;
          int actualCoins = player.Coins;
          
          //Then
          Assert.True(expectedInventory == actualInventory);
          Assert.True(expectedCoins == actualCoins);
        }

        [Fact]
        public void BuyDenialWorks()
        {
          //Given
          Shop shop = new Shop();
          Armor testArmor = new Armor("testArmor", 10, "testArmor", 4);
          shop.Inventory.Add(testArmor);

          Player player = new Player("testEmail", "testUsername", "testPassword");
          player.Coins = 5;

          shop.Buy(player, testArmor);
          
          //When
          int expectedCoins = 5;
          int actualCoins = player.Coins;
          
          //Then
          Assert.True(expectedCoins == actualCoins);
        }

        [Fact]
        public void SellWorks()
        {
          //Given
          Shop shop = new Shop();
          Player player = new Player("testEmail", "testUsername", "testPassword");
          Armor testArmor = new Armor("testArmor", 20, "testArmor", 4);
          player.Inventory.Add(testArmor);
          shop.Sell(player, testArmor);

          //When
          int expectedCoins = 5;
          int actualCoins = player.Coins;          
          
          //Then
          Assert.True(expectedCoins == actualCoins);
          Assert.False(player.Inventory.Contains(testArmor));
        }

        [Fact]
        public void SellLimitWorks()
        {
          //Given
          Shop shop = new Shop();
          Player player = new Player("testEmail", "testUsername", "testPassword");
          Armor testArmor = new Armor("testArmor", 20, "testArmor", 4);
          shop.Sell(player, testArmor);

          //When
          int expectedCoins = 0;
          int actualCoins = player.Coins;          
          
          //Then
          Assert.True(expectedCoins == actualCoins);
          Assert.False(player.Inventory.Contains(testArmor));
        }
    }
}