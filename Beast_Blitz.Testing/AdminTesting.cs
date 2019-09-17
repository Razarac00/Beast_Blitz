using Beast_Blitz.Domain.Models;
using Xunit;

namespace Beast_Blitz.Testing
{
    public class AdminTesting
    {
        [Fact]
        public void CanBeConstructed()
        {
          //Given
          Admin admin = new Admin("admin@test.com", "admin", "Password123");
          
          //When
          string expected = "admin";
          string actual = admin.Username;
          
          //Then
          Assert.True(expected == actual);
        }

        [Fact]
        public void CanBeConstructedEmpty()
        {
          //Given
          Admin admin = new Admin();
          
          //When
          string expected = null;
          string actual = admin.Email;
          
          //Then
          Assert.True(expected == actual);
        }

        [Fact]
        public void AddNewSpeciesWorks()
        {
          //Given
          Admin admin = new Admin("admin@test.com", "admin", "Password123");
          Element elm = new Element("testElement");
          BattleStats basestats = new BattleStats();
          Species species = admin.AddNewSpecies("testSpecies", elm, basestats, "testImg");

          //When
          string expected = "testSpecies";
          string actual = species.Name;
          
          //Then
          Assert.True(expected == actual);
        }

        [Fact]
        public void AddNewElementWorks()
        {
          //Given
          Admin admin = new Admin("admin@test.com", "admin", "Password123");
          Element element = admin.AddNewElement("testElement");
          
          //When
          string expected = "testElement";
          string actual = element.Name;
          
          //Then
          Assert.True(expected == actual);
        }

        [Fact]
        public void AddNewShopWorks()
        {
          //Given
          Admin admin = new Admin("admin@test.com", "admin", "Password123");
          Shop shop = admin.AddNewShop("testShop");
          
          //When
          string expected = "testShop";
          string actual = shop.Name;
          
          //Then
          Assert.True(expected == actual);
        }

        [Fact]
        public void AddNewArmorWorks()
        {
          //Given
          Admin admin = new Admin("admin@test.com", "admin", "Password123");
          Armor armor = admin.AddNewArmor("armorTest", 100, "testImg", 10);
          
          //When
          string expected = "armorTest";
          string actual = armor.Name;
          
          //Then
          Assert.True(expected == actual);
        }

        [Fact]
        public void AddNewFoodWorks()
        {
          //Given
          Admin admin = new Admin("admin@test.com", "admin", "Password123");
          Food food = admin.AddNewFood("testFood", 100, "testImg", 10);
          
          //When
          string expected = "testFood";
          string actual = food.Name;
          
          //Then
          Assert.True(expected == actual);
        }

        [Fact]
        public void AddNewPotionWorks()
        {
          //Given
          Admin admin = new Admin("admin@test.com", "admin", "Password123");
          Potion potion = admin.AddNewPotion("testPotion", 100, "testImg", "testStat", 2);
          
          //When
          string expected = "testPotion";
          string actual = potion.Name;
          
          //Then
          Assert.True(expected == actual);
        }

        [Fact]
        public void AddNewTreatWorks()
        {
          //Given
          Admin admin = new Admin("admin@test.com", "admin", "Password123");
          Treat treat = admin.AddNewTreat("testTreat", 100, "testImg", 4);
          
          //When
          string expected = "testTreat";
          string actual = treat.Name;
          
          //Then
          Assert.True(expected == actual);
        }

        // [Fact]
        // public void AddToShopWorks()
        // {
        //   //Given
        //   Admin admin = new Admin("admin@test.com", "admin", "Password123");
        //   Shop shop = new Shop("testShop");
        //   Treat treat = new Treat("testTreat", 100, 10, "testImg");
        //   shop = admin.AddToShop(treat, shop);

        //   //When
        //   int expected = 1;
        //   int actual = shop.Inventory.Count;
                    
        //   //Then
        //   Assert.True(expected == actual);
        // }

        [Fact]
        public void AddNewAdminWorks()
        {
          //Given
          Admin admin = new Admin("admin@test.com", "admin", "Password123");
          Admin admin1 = admin.AddNewAdmin("testEmail1", "testPassword1", "testPassword1");
          
          //When
          string expected = "testEmail1";
          string actual = admin1.Email;
          
          //Then
          Assert.True(expected == actual);
        }
    }
}