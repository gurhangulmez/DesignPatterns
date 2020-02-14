﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorDesignPattern
{
    class CommercialCar : CarBase
    {
        public override string Make { get; set; }
        public override string Model { get; set; }
        public override decimal HirePrice { get; set; }
    }
}
