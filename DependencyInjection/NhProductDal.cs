using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjection
{
    class NhProductDal : IProductDal
    {
        public void Save()
        {
            Console.WriteLine("Saved with NHibernate.");
        }
    }
}
