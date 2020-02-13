using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryDesignPattern
{
    public class RocketEnemyShip : EnemyShip
    {
        public RocketEnemyShip()
        {
            setName("Rocket Enemy Ship");
            setDamage(10.0);
        }
    }
}
