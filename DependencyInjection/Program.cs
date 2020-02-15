using System;

namespace DependencyInjection
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductManager p = new ProductManager(new EFProductDal());
            p.Save();

            p = new ProductManager(new NhProductDal());
            p.Save();
        }
    }
}
