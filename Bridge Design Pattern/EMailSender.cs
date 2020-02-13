using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge_Design_Pattern
{
    class EMailSender : MessageSenderBase
    {
        public override void Send(Body body)
        {
            Console.WriteLine("EMail Message sent! {0}", body.Text);
        }
    }
}
