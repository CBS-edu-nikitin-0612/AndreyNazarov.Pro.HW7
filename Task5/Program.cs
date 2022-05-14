using System;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            Admin admin = new();
            Sale sale = new();
            Director director = new();
            Accauntant accauntant = new();

            Bank bank = new();
            Office office = new();

            try
            {
                Console.WriteLine("\nAdmin");
                office.Login(admin);
                bank.Login(admin);
            }
            catch(AccessErrorExeption e)
            {
                Console.WriteLine(e.Message);
            }

            try
            {
                Console.WriteLine("\nsale");
                office.Login(sale);
                bank.Login(sale);
            }
            catch (AccessErrorExeption e)
            {
                Console.WriteLine(e.Message);
            }

            try
            {
                Console.WriteLine("\ndirector");
                office.Login(director);
                bank.Login(director);
            }
            catch (AccessErrorExeption e)
            {
                Console.WriteLine(e.Message);
            }

            try
            {
                Console.WriteLine("\naccauntant");
                office.Login(accauntant);
                bank.Login(accauntant);
            }
            catch (AccessErrorExeption e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
