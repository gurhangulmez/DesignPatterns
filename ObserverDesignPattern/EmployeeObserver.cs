using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverDesignPattern
{
    class EmployeeObserver : Observer
    {
        public override void Update()
        {
            Console.WriteLine("Product price changed : Message to employee");
        }
    }
}
