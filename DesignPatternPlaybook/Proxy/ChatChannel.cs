using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternPlaybook.Proxy
{
    public class ChatChannel : IChannel
    {

        string userMail;


        public ChatChannel(string userMail)
        {
            this.userMail = userMail;
        }

        public void Send(string message)
        {
            Console.WriteLine(message);
        }
    }
}
