using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorDesignPattern
{
    abstract class CarDecoratorBase : CarBase
    {
        CarBase carBase;

        protected CarDecoratorBase(CarBase _carBase)
        {
            carBase = _carBase;
        }
    }
}
