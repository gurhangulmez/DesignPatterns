using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjectionWithIOC
{
    class ProductManager
    {
        IProductDal productDal;

        public ProductManager(IProductDal _productDal)
        {
            productDal = _productDal;
        }

        public void Save()
        {
            productDal.Save();
        }
    }
}
