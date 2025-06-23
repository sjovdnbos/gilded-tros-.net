using GildedTros.App;
using GildedTros.App.Strategies;

namespace GildedTros.Tests
{
    public class BackstagePassUpdateStrategyTests
    {
        [Theory]
        [InlineData(15, 20, 21)] // >10 dagen
        [InlineData(10, 20, 22)] // <=10 dagen
        [InlineData(5, 20, 23)]  // <=5 dagen
        public void IncreasesQualityCorrectly(int sellIn, int quality, int expectedQuality)
        {
            var item = new Item { Name = "Backstage passes for HAXX", SellIn = sellIn, Quality = quality };
            var strategy = new BackstagePassStrategy();

            strategy.Update(item);

            Assert.Equal(sellIn - 1, item.SellIn);
            Assert.Equal(expectedQuality, item.Quality);
        }

        [Fact]
        public void QualityDropsToZeroAfterEvent()
        {
            var item = new Item { Name = "Backstage passes for HAXX", SellIn = 0, Quality = 30 };
            var strategy = new BackstagePassStrategy();

            strategy.Update(item);

            Assert.Equal(-1, item.SellIn);
            Assert.Equal(0, item.Quality);
        }

        [Fact]
        public void QualityDoesNotExceedFifty()
        {
            var item = new Item { Name = "Backstage passes for HAXX", SellIn = 5, Quality = 49 };
            var strategy = new BackstagePassStrategy();

            strategy.Update(item);

            Assert.Equal(4, item.SellIn);
            Assert.Equal(50, item.Quality); // Quality should not exceed 50
        }   
    }
}