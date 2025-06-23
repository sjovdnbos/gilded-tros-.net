using GildedTros.App;
using GildedTros.App.Strategies;

namespace GildedTros.Tests
{
    public class NormalItemStrategyTests
    {
        [Fact]
        public void DegradesByOne_WhenNotExpired()
        {
            var item = new Item { Name = "Normal Item", SellIn = 10, Quality = 20 };
            var strategy = new NormalItemStrategy();

            strategy.Update(item);

            Assert.Equal(9, item.SellIn);
            Assert.Equal(19, item.Quality);
        }

        [Fact]
        public void DegradesTwiceAsFast_WhenExpired()
        {
            var item = new Item { Name = "Normal Item", SellIn = 0, Quality = 20 };
            var strategy = new NormalItemStrategy();

            strategy.Update(item);

            Assert.Equal(-1, item.SellIn);
            Assert.Equal(18, item.Quality);
        }

        [Fact]
        public void NeverDegradesBelowZero()
        {
            var item = new Item { Name = "Normal Item", SellIn = 0, Quality = 0 };
            var strategy = new NormalItemStrategy();

            strategy.Update(item);

            Assert.Equal(-1, item.SellIn);
            Assert.Equal(0, item.Quality);
        }
    }
}
