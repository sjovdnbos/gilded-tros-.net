namespace GildedTros.App.Strategies
{
    public class NormalItemStrategy : IUpdateStrategy
    {
        public void Update(Item item)
        {
            item.DecreaseSellIn();
            item.DecreaseQuality();
        }
    }
}