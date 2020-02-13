using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterDesignPattern
{
    class Log4NetAdapter : ILogger
    {
        public void Log(string message)
        {
            Log4Net log4Net = new Log4Net();
            log4Net.LogMessage(message);
        }
    }
}
