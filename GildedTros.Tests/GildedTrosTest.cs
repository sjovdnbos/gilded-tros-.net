using Xunit;

namespace GildedTros.App
{
    public class GildedTrosTest
    {
        [Fact]
        public void foo()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "foo", SellIn = 0, Quality = 0 } };
            GildedTros app = new(Items);
            app.UpdateQuality();
            Assert.Equal("foo", Items[0].Name);
        }
    }
}