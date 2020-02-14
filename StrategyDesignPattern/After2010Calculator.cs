using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyDesignPattern
{
    class After2010Calculator : CreditCalculatorBase
    {
        public override void Calculate()
        {
            Console.WriteLine("Credit calculated using After 2010.");
        }
    }
}
