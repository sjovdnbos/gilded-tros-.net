using GildedTros.App.Strategies;

namespace GildedTros.App
{
    public static class UpdateStrategyFactory
    {
        public static IUpdateStrategy GetStrategyFor(Item item)
        {
            if (item.Name == "Good Wine")
                return new GoodWineStrategy();

            if (item.Name == "Backstage passes for Re:factor"
                || item.Name == "Backstage passes for HAXX")
                return new BackstagePassStrategy();

            if (item.Name == "B-DAWG Keychain")
                return new LegendaryItemStrategy();

            if (item.Name == "Duplicate Code" || item.Name == "Long Methods" || item.Name == "Ugly Variable Names")
                return new SmellyItemStrategy();

            // Default
            return new NormalItemStrategy();
        }
    }
}
