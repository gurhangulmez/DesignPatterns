using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderDesignPatternExample
{
    //This is a class which implements the Builder interface to create a complex product.
    class MotoBikeBuilder : IVehicleBuilder
    {
        Vehicle hondaMotoBike = new Vehicle();
        public Vehicle GetVehicle()
        {
            return hondaMotoBike;
        }

        public void SetAccessories()
        {
            hondaMotoBike.Accessories = new List<string> { "Sterio Radio", "Fog Stops Lights" };
        }

        public void SetBody()
        {
            hondaMotoBike.Body = "Classic 69";
        }

        public void SetEngine()
        {
            hondaMotoBike.Engine = "800 cc";
        }

        public void SetModel()
        {
            hondaMotoBike.Model = "2020 Morrison";
        }

        public void SetTransmission()
        {
            hondaMotoBike.Transmission = "Manuel 6";
        }
    }
}
