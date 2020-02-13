﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderDesignPatternExample
{
    class Vehicle
    {
        public List<string> Accessories { get; set; }
        public string Body { get; set; }
        public string Engine { get; set; }
        public string Model { get; set; }
        public string Transmission { get; set; }

        public void ShowInfo()
        {
            Console.WriteLine("");
            Console.WriteLine("********* OUR VEHICLE'S FEATURES  **********");
            Console.WriteLine("");

            int index = 0;
            foreach (var acc in Accessories)
            {
                index++;
                Console.WriteLine("Accessories {0}: {1}", index, acc);
            }

            Console.WriteLine("Body : {0}", Body);

            Console.WriteLine("Engine : {0}", Engine);

            Console.WriteLine("Model : {0}", Model);

            Console.WriteLine("Transmission : {0}", Transmission);
            Console.WriteLine("");

            Console.WriteLine("********* OUR VEHICLE'S FEATURES  **********");
            Console.WriteLine("********************************************");
        }

        public Vehicle()
        {
            Accessories = new List<string>();
        }
    }
}
