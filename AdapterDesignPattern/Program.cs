using System;

/* 
 * When we want to integrate different systems to our systems,
 this provide other system can work like our system and 
 our system keeps to work with no problem  
*/

namespace AdapterDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductManager pManager = new ProductManager(new GGLogger());
            pManager.Save();

            pManager = new ProductManager(new Log4NetAdapter());
            pManager.Save();
        }
    }
}
