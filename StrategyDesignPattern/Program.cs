using System;

namespace StrategyDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager cManager = new CustomerManager();
            cManager.creditCalculatorBase = new Before2010Calculator();
            cManager.SaveCredit();
        }
    }
}
