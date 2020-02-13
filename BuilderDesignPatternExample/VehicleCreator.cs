using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderDesignPatternExample
{
    //This is a class that is used to construct an object using the Builder interface.
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
