using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorDesignPattern
{
    class SpecialOffer : CarDecoratorBase
    {
        public int DiscountPercentage { get; set; }

        readonly CarBase _carBase;
        public SpecialOffer(CarBase carBase) : base(carBase)
        {
            _carBase = carBase;
        }

        public override string Make { get; set; }
        public override string Model { get; set; }
        public override decimal HirePrice
        {
            get
            {
                return _carBase.HirePrice - _carBase.HirePrice * DiscountPercentage/100;
            }
            set { }
        }
    }
}
