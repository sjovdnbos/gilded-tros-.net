namespace GildedTros.App
{
    public class Item
    {
        public string Name { get; set; }
        public int SellIn { get; set; }
        public int Quality { get; set; }

        public void DecreaseSellIn(int amount = 1) => SellIn -= amount;

        public void IncreaseQuality(int amount = 1, int max = 50)
        {
            if (SellIn < 0)
            {
                amount *= 2;
            }
            Quality = Math.Min(Quality + amount, max);

        }

        public void DecreaseQuality(int amount = 1, int min = 0)
        {
            if (SellIn < 0)
            {
                amount *= 2;
            }
            Quality = Math.Max(Quality - amount, min);
        }
    }
}
