using System;

namespace ObserverDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerObserver custObs = new CustomerObserver();
            ProductManager pManager = new ProductManager();
            pManager.Attach(custObs);
            pManager.Attach(new EmployeeObserver());

            pManager.Detach(custObs);
            pManager.UpdatePrice();
        }
    }
}
