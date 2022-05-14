using System;

namespace Task5
{
    internal class Office
    {
        public void Login(IEmployee employee)
        {
            dynamic accessLevel = employee.GetType().GetCustomAttributes(typeof(AccessLevelAttribute), true)[0];
            if (!(accessLevel.AccessLevel is AccessLevelAttribute.AccessLevels))
            {
                throw new AccessErrorExeption();
            }
            Console.WriteLine("Успешное подключенние");
            
        }
    }
}
