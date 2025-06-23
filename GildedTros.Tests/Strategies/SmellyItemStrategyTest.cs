using GildedTros.App;
using GildedTros.App.Strategies;

namespace GildedTros.Tests
{
    public class SmellyItemUpdateStrategyTests
    {
        [Fact]
        public void DegradesTwiceAsFast_WhenNotExpired()
        {
            var item = new Item { Name = "Duplicate Code", SellIn = 5, Quality = 10 };
            var strategy = new SmellyItemStrategy();

            strategy.Update(item);

            Assert.Equal(4, item.SellIn);
            Assert.Equal(8, item.Quality);
        }

        [Fact]
        public void DegradesFourTimesAsFast_WhenExpired()
        {
            var item = new Item { Name = "Duplicate Code", SellIn = 0, Quality = 10 };
            var strategy = new SmellyItemStrategy();

            strategy.Update(item);

            Assert.Equal(-1, item.SellIn);
            Assert.Equal(6, item.Quality);
        }

        [Fact]
        public void NeverDegradesBelowZero()
        {
            var item = new Item { Name = "Duplicate Code", SellIn = 0, Quality = 3 };
            var strategy = new SmellyItemStrategy();

            strategy.Update(item);

            Assert.Equal(-1, item.SellIn);
            Assert.Equal(0, item.Quality);
        }
    }
}