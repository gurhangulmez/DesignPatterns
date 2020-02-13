using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge_Design_Pattern
{
    class SMSSender : MessageSenderBase
    {
        public override void Send(Body body)
        {
            Console.WriteLine("SMS Message sent! {0}", body.Text);
        }
    }
}
