using GildedTros.App;
using GildedTros.App.Strategies;

namespace GildedTros.Tests.Strategies
{
    public class LegendaryItemUpdateStrategyTests
    {
        [Fact]
        public void NeverChangesQualityOrSellIn()
        {
            var item = new Item { Name = "B-DAWG Keychain", SellIn = 10, Quality = 80 };
            var strategy = new LegendaryItemStrategy();

            strategy.Update(item);

            Assert.Equal(10, item.SellIn);
            Assert.Equal(80, item.Quality);
        }
    }
}