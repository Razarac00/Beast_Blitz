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
        Element e = new Element("Air");
        BattleStats bs = new BattleStats();
        Species s = new Species("Bat", e, bs, "img");
        Enemy e1 = new Enemy(s, "black", 10);
        Enemy e2 = new Enemy(s, "black", 10);
        List<Enemy> es = new List<Enemy>();
        es.Add(e1);
        es.Add(e2);
        Armor a = new Armor("Helm", 40, "helm.jpg", 4);
        Boss b = new Boss(s, "red", 20, a);
        Battlefield battlefield = new Battlefield("Desert", es, b);

        //When
        var expected = b.Color;
        var actual = battlefield.Boss.Color;

        //Then
        Assert.True(expected.Equals(actual));
        }
    }
}