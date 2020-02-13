﻿using System;

namespace FactoryDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create the factory object
            EnemyShipFactory shipFactory = new EnemyShipFactory();

            // Enemy ship object
            EnemyShip theEnemy = null;

            Console.WriteLine("What type of ship? (U / R / B)");
            var txt = Console.ReadLine();

            if (!string.IsNullOrEmpty(txt))
            {
                String typeOfShip = txt;

                theEnemy = shipFactory.makeEnemyShip(typeOfShip);

                if (theEnemy != null)
                {
                    doStuffEnemy(theEnemy);
                }
                else
                    Console.WriteLine("Please enter U, R, or B next time");
            }

            /*
			EnemyShip theEnemy = null;

			// Old way of creating objects
			// When we use new we are not being dynamic

			EnemyShip ufoShip = new UFOEnemyShip();

			doStuffEnemy(ufoShip);

			System.out.print("\n");

			// -----------------------------------------

			// This allows me to make the program more dynamic
			// It doesn't close the code from being modified
			// and that is bad!

			// Defines an input stream to watch: keyboard
			Scanner userInput = new Scanner(System.in);

			String enemyShipOption = "";

			System.out.print("What type of ship? (U or R)");

			if (userInput.hasNextLine()){

				enemyShipOption = userInput.nextLine();

			}

			if (enemyShipOption == "U"){

				theEnemy = new UFOEnemyShip();


			} else 

			if (enemyShipOption == "R"){

				theEnemy = new RocketEnemyShip();

			} else {

				theEnemy = new BigUFOEnemyShip();

			}

			doStuffEnemy(theEnemy);

			// --------------------------------------------
			*/

        }

        // Executes methods of the super class

        public static void doStuffEnemy(EnemyShip anEnemyShip)
        {
            anEnemyShip.displayEnemyShip();
            anEnemyShip.followHeroShip();
            anEnemyShip.enemyShipShoots();
        }
    }
}
