using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterDesignPattern
{
    class ProductManager
    {
        ILogger logger;

        public ProductManager(ILogger _logger)
        {
            logger = _logger;
        }

        public void Save()
        {
            logger.Log("User Data");

            Console.WriteLine("Saved to DB");
        }
    }
}
