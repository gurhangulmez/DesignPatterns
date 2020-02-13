using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderDesignPatternExample
{
    class VehicleCreator
    {
        private readonly IVehicleBuilder objBuilder;

        public VehicleCreator(IVehicleBuilder _objBuilder)
        {
            objBuilder = _objBuilder;
        }

        public void CreateVehicle()
        {
            objBuilder.SetAccessories();
            objBuilder.SetBody();
            objBuilder.SetEngine();
            objBuilder.SetModel();
            objBuilder.SetTransmission();
        }

        public Vehicle GetVehicle()
        {
            return objBuilder.GetVehicle();
        }
    }
}
