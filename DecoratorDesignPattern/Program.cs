using System;

namespace DecoratorDesignPattern
{
    /*
     * If you have a base class, and in different situation you want to 
     * load different feautures you can do it with this pattern
     * 
     * The Participants
        The Component defines the interface for objects which will have responsibilities or abilities added to them dynamically.
        The ConcreteComponent objects are objects to which said responsibilities are added.
        The Decorator maintains a reference to a Component and defines and interface that conforms to the Component interface.
        The ConcreteDecorator objects are the classes which actually add responsibilities to the ConcreteComponent classes.
     * 
     * 
     * */
    class Program
    {
        static void Main(string[] args)
        {
            var personalCar = new PersonalCar { Make="BMW", Model="3.20", HirePrice=2500};

            SpecialOffer sO = new SpecialOffer(personalCar);
            sO.DiscountPercentage = 10;

            Console.WriteLine("Special Offer : {0}", sO.HirePrice);
            Console.WriteLine("Personal Car Offer : {0}", personalCar.HirePrice);
        }
    }
}
