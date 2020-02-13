using System;

namespace PrototypeDesignPattern
{
    class Program
    {
        //This Prototype DP is used for share resource. If you have a big object and
        //there is a need to use same object or similar, you can use this DP
        //Special case here is cloning
        static void Main(string[] args)
        {
            Customer customer = new Customer { FirstName = "Gurhan", LastName = "Gulmez", City = "London", Id = 7 };
            Console.WriteLine(customer.FirstName);

            Customer customer2 = (Customer)customer.Clone();
            customer2.FirstName = "Aysegul";

            Console.WriteLine("customer2 : {0}", customer2.FirstName);
            Console.WriteLine("customer : {0}", customer.FirstName);
        }
    }
}
