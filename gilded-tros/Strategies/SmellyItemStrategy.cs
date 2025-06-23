namespace GildedTros.App.Strategies
{
    public class SmellyItemStrategy : IUpdateStrategy
    {
        public void Update(Item item)
        {
            item.DecreaseSellIn();
            item.DecreaseQuality(2);
        }
    }
}
