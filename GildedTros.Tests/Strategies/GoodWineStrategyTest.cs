using GildedTros.App;
using GildedTros.App.Strategies;

namespace GildedTros.Tests
{
    public class GoodWineUpdateStrategyTests
    {
        [Fact]
        public void IncreasesQualityByOne()
        {
            var item = new Item { Name = "Good Wine", SellIn = 5, Quality = 10 };
            var strategy = new GoodWineStrategy();

            strategy.Update(item);

            Assert.Equal(4, item.SellIn);
            Assert.Equal(11, item.Quality);
        }

        [Fact]
        public void NeverExceedsQualityOfFifty()
        {
            var item = new Item { Name = "Good Wine", SellIn = 5, Quality = 50 };
            var strategy = new GoodWineStrategy();

            strategy.Update(item);

            Assert.Equal(4, item.SellIn);
            Assert.Equal(50, item.Quality);
        }

        [Fact]
        public void IncreasesQualityByTwoAfterSellInDate()
        {
            var item = new Item { Name = "Good Wine", SellIn = 0, Quality = 10 };
            var strategy = new GoodWineStrategy();

            strategy.Update(item);

            Assert.Equal(-1, item.SellIn);
            Assert.Equal(12, item.Quality);
        }
    }
}