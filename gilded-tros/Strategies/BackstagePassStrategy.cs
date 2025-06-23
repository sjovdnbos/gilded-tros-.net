namespace GildedTros.App.Strategies
{
    public class BackstagePassStrategy : IUpdateStrategy
    {
        public void Update(Item item)
        {
            item.SellIn--;

            if (item.SellIn < 0)
            {
                item.Quality = 0;
                return;
            }

            if (item.Quality < 50) item.Quality++;

            if (item.SellIn < 10 && item.Quality < 50) item.Quality++;
            if (item.SellIn < 5 && item.Quality < 50) item.Quality++;
        }
    }
}
