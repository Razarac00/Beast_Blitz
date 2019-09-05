using Xunit;
using Beast_Blitz.Domain.Models;

namespace Beast_Blitz.Testing
{
    public class HatTesting
    {
        [Fact]
        public void CanBeConstructed()
        {
        //Given
        var hat = new Hat();
        //When
        int expected = 50;
        var actual = hat.SellingPrice();
        //Then
        Assert.True(expected == actual);
        }
    }
}