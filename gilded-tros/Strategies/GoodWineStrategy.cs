namespace GildedTros.App.Strategies
{
    public class GoodWineStrategy : IUpdateStrategy
    {
        public void Update(Item item)
        {
            item.DecreaseSellIn();
            item.IncreaseQuality();

        }
    }
}