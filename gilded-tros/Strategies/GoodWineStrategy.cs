namespace GildedTros.App.Strategies
{
    public class GoodWineStrategy : IUpdateStrategy
    {
        public void Update(Item item)
        {
            item.SellIn--;

            if (item.Quality < 50)
                item.Quality++;

            if (item.SellIn < 0 && item.Quality < 50)
                item.Quality++;
        }
    }
}