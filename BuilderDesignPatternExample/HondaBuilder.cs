using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderDesignPatternExample
{
    //This is a class which implements the Builder interface to create a complex product.
    class HondaBuilder : IVehicleBuilder
    {
        Vehicle hondaJazz = new Vehicle();

        public Vehicle GetVehicle()
        {
            return hondaJazz;
        }

        public void SetAccessories()
        {
            hondaJazz.Accessories = new List<string> { "Hi-Tech Screen UH", "Vinly" };
        }

        public void SetBody()
        {
            hondaJazz.Body = "4 Doors Hatchback";
        }

        public void SetEngine()
        {
            hondaJazz.Engine = "1400 cc";
        }

        public void SetModel()
        {
            hondaJazz.Model = "2009 Fun";
        }

        public void SetTransmission()
        {
            hondaJazz.Transmission = "i-Shift";
        }
    }
}
