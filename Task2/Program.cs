using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass myClass = new();
            myClass.Method1();
            //myClass.Method2();
        }
    }

    internal class MyClass
    {
        [Obsolete("Метод устарел")]
        public void Method1()
        {
            Console.WriteLine("Method1");
        }
        [Obsolete("Метод устарел", true)]
        public void Method2()
        {
            Console.WriteLine("Method2");
        }
    }
}
