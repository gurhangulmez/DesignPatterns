using System;


namespace FactoryDesignPattern
{
    //Factory pattern prevents your code from long "if else" codes
    //If there will be created various order of objects you should consider to use this pattern


    // This is a factory thats only job is creating ships
    // By encapsulating ship creation, we only have one
    // place to make modifications

    public class EnemyShipFactory
    {
        // This could be used as a static method if we
        // are willing to give up subclassing it
        public EnemyShip makeEnemyShip(String newShipType)
        {
            if (newShipType.Equals("U"))
            {
                return new UFOEnemyShip();
            }
            else if (newShipType.Equals("R"))
            {
                return new RocketEnemyShip();
            }
            else if (newShipType.Equals("B"))
            {
                return new WarPlaneEnemyShip();
            }
            else return null;
        }
    }
}
