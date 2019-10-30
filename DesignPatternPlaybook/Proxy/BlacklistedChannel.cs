using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternPlaybook.Proxy
{
    public class BlacklistedChannel : IChannel
    {
        private static List<string> blacklistedUsers = new List<string>();

        ChatChannel realChannel;
        string userMail;

        public BlacklistedChannel(string userMail)
        {
            this.realChannel = new ChatChannel(userMail);
            this.userMail = userMail;
        }


        public void Send(string message)
        {

            // Possible patterns:
            // LazyInstantiation
            // AccessControl
            // RemoteAccess
            if (!blacklistedUsers.Contains(userMail))
            {
                realChannel.Send(message);
            }
        }


        public void Blacklist(string userMail)
        {

        }
    }
}
