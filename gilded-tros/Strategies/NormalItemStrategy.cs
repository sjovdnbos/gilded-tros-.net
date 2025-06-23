namespace GildedTros.App.Strategies
{
    public class NormalItemStrategy : IUpdateStrategy
    {
        public void Update(Item item)
        {
            item.SellIn--;

            var degrade = item.SellIn < 0 ? 2 : 1;

            item.Quality = Math.Max(0, item.Quality - degrade);
        }
    }
}