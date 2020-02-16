using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjectionWithIOC.DependencyResolvers
{
    class BusinessModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IProductDal>().To<EFProductDal>().InSingletonScope();
        }
    }
}
