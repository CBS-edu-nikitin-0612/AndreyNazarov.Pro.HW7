namespace Task5
{
    [AccessLevel(AccessLevelAttribute.AccessLevels.Sale)]
    internal class Sale : IEmployee
    {
        public string Name { get; } = "Sale";
    }
}
