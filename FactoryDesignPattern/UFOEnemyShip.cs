using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryDesignPattern
{
    public class UFOEnemyShip : EnemyShip
    {
        public UFOEnemyShip()
        {
            setName("UFO Enemy Ship");
            setDamage(20.0);
        }
    }
}
