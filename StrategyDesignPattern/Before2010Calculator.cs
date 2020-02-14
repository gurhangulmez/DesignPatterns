using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyDesignPattern
{
    class Before2010Calculator : CreditCalculatorBase
    {
        public override void Calculate()
        {
            Console.WriteLine("Credit calculated using Before 2010.");
        }
    }
}
