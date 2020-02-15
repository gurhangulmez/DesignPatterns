using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjection
{
    class EFProductDal : IProductDal
    {
        public void Save()
        {
            Console.WriteLine("Saved with Entity Framework.");
        }
    }
}
