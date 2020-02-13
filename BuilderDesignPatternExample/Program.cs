using System;

namespace BuilderDesignPatternExample
{
    class Program
    {
        static void Main(string[] args)
        {
            VehicleCreator vCreator = new VehicleCreator(new HondaBuilder());
            vCreator.CreateVehicle();
            var vJazz = vCreator.GetVehicle();
            vJazz.ShowInfo();


            VehicleCreator bikeCreator = new VehicleCreator(new MotoBikeBuilder());
            bikeCreator.CreateVehicle();
            var bikeMorrison = bikeCreator.GetVehicle();
            bikeMorrison.ShowInfo();
        }
    }
}
