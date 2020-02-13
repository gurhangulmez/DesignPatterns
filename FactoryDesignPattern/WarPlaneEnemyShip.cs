using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryDesignPattern
{
    public class WarPlaneEnemyShip : UFOEnemyShip
    {
        public WarPlaneEnemyShip()
        {
            setName("War Plane Enemy Ship");
            setDamage(40.0);
        }
    }
}
