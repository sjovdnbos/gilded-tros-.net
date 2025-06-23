namespace GildedTros.App.Strategies
{
    public class BackstagePassStrategy : IUpdateStrategy
    {
        public void Update(Item item)
        {
            item.DecreaseSellIn();
            item.IncreaseQuality();

            if (item.SellIn <= 10) item.IncreaseQuality();
            if (item.SellIn <= 5) item.IncreaseQuality();

            if (item.SellIn < 0)
            {
                item.Quality = 0; 
            }
        }
    }
}
