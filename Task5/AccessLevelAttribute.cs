using System;

namespace Task5
{
    internal class AccessLevelAttribute : Attribute
    {
        public AccessLevelAttribute(AccessLevels accessLevel)
        {
            AccessLevel = accessLevel;
        }
        public AccessLevels AccessLevel { get; private set; }
        public enum AccessLevels
        {
            Admin,
            Sale,
            Accauntant,
            Director
        }
    }
}
