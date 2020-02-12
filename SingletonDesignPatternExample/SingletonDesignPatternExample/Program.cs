using System;

namespace SingletonDesignPatternExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is a thread-safety SingletonDesignPattern Example!");

            //*** USE only SingletonClass.GetInstance ***/
            //No need to assign it to another variable when using


            //LET'S CHECK!

            // The client code.
            SingletonClass s1 = SingletonClass.GetInstance;
            SingletonClass s2 = SingletonClass.GetInstance;

            if (s1 == s2)
            {
                Console.WriteLine("Singleton works, both variables contain the same instance.");
            }
            else
            {
                Console.WriteLine("Singleton failed, variables contain different instances.");
            }
        }
    }
}
