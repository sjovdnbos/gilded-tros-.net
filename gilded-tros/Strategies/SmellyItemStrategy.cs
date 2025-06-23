namespace GildedTros.App.Strategies
{
    public class SmellyItemStrategy : IUpdateStrategy
    {
        public void Update(Item item)
        {
            item.SellIn--;

            var degrade = item.SellIn < 0 ? 4 : 2;

            item.Quality = Math.Max(0, item.Quality - degrade);
        }
    }
}
