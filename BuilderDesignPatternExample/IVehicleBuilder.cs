using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderDesignPatternExample
{
    //This is an interface which is used to define all the steps required to create a product.

    interface IVehicleBuilder
    {
        Vehicle GetVehicle();
        void SetAccessories();
        void SetBody();
        void SetEngine();
        void SetModel();
        void SetTransmission();
    }
}
