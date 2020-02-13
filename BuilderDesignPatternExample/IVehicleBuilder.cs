using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderDesignPatternExample
{
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
