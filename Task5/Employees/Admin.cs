namespace Task5
{
    [AccessLevel(AccessLevelAttribute.AccessLevels.Admin)]
    internal class Admin : IEmployee
    {
        public string Name { get; } = "Admin";
    }
}
