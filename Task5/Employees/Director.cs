namespace Task5
{
    [AccessLevel(AccessLevelAttribute.AccessLevels.Director)]
    internal class Director : IEmployee
    {
        public string Name { get; } = "Director";
    }
}
