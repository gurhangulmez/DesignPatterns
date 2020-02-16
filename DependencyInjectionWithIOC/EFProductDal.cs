using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjectionWithIOC
{
    class EFProductDal : IProductDal
    {
        public void Save()
        {
            Console.WriteLine("Saved with Entity Framework.");
        }
    }
}
