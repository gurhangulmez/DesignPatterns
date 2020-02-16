using DependencyInjectionWithIOC.DependencyResolvers;
using Ninject;
using System;

namespace DependencyInjectionWithIOC
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductManager p = new ProductManager(InstanceFactory.GetInstance<IProductDal>());
            p.Save();

            p = new ProductManager(new NhProductDal());
            p.Save();
        }
    }
}
