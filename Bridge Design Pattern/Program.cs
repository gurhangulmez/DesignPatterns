using System;

namespace Bridge_Design_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager cManager = new CustomerManager();
            cManager.messageSenderBase = new EMailSender();

            cManager.UpdateCustomer();           
        }
    }
}
