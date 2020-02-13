using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge_Design_Pattern
{
    abstract class MessageSenderBase
    {
        public void Save(Body body)
        {
            Console.WriteLine("Message saved! {0}", body.Text);
        }

        public abstract void Send(Body body);
    }
}
