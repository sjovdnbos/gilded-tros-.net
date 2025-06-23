using GildedTros.App;
using GildedTros.App.Strategies;

public static class UpdateStrategyFactory
{
    private static readonly Dictionary<string, IUpdateStrategy> _strategies = new()
    {
        { "Good Wine", new GoodWineStrategy() },
        { "Backstage passes for Re:factor", new BackstagePassStrategy() },
        { "Backstage passes for HAXX", new BackstagePassStrategy() },
        { "B-DAWG Keychain", new LegendaryItemStrategy() },
        { "Duplicate Code", new SmellyItemStrategy() },
        { "Long Methods", new SmellyItemStrategy() },
        { "Ugly Variable Names", new SmellyItemStrategy() }
    };

    public static IUpdateStrategy GetStrategyFor(Item item)
    {
        return _strategies.TryGetValue(item.Name, out IUpdateStrategy? value) ? value : new NormalItemStrategy();
    }
}