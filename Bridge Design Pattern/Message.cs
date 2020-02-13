using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge_Design_Pattern
{
    class CustomerManager
    {
        public MessageSenderBase messageSenderBase { get; set; }
        
        public void UpdateCustomer()
        {
            messageSenderBase.Send(new Body());
            Console.WriteLine("Customer Updated");
        }
    }
}
