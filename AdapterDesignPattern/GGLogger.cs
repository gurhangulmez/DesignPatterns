using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterDesignPattern
{
    class GGLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine("Logged {0}", message);
        }
    }
}
