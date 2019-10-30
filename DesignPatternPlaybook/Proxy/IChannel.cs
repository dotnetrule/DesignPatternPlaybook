using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternPlaybook.Proxy
{
    public interface IChannel
    {
        void Send(string message);
    }
}
