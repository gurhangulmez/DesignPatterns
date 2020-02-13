using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterDesignPattern
{
    //Assume that it is a DLL from NUGET
    class Log4Net
    {
        public void LogMessage(string message)
        {
            Console.WriteLine("Logged with Log4Net {0}", message);
        }
    }
}
