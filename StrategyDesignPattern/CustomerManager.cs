using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyDesignPattern
{
    class CustomerManager
    {
        public CreditCalculatorBase creditCalculatorBase { get; set; }
        public void SaveCredit()
        {
            Console.WriteLine("Customer manager business.");

            creditCalculatorBase.Calculate();
        }
    }
}
