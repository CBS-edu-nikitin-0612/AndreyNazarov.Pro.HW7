using System;

namespace Task5
{
    internal class Bank
    {
        public void Login(IEmployee employee)
        {
            dynamic accessLevel = employee.GetType().GetCustomAttributes(typeof(AccessLevelAttribute), true)[0];
            if (!(accessLevel.AccessLevel == AccessLevelAttribute.AccessLevels.Admin || accessLevel.AccessLevel == AccessLevelAttribute.AccessLevels.Accauntant))
            {
                throw new AccessErrorExeption();
            }

            Console.WriteLine("Успешное подключенние");
        }
    }
}
