using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Remoting.Channels.Tcp;

namespace Server
{
    class ServerRemoting
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exchange Server started...");

            TcpChannel serverChannel = new TcpChannel(13000);
            ChannelServices.RegisterChannel(serverChannel, false);

            Type commonInterfaceType = Type.GetType("Server.Exchanger, Server");

            RemotingConfiguration.RegisterWellKnownServiceType(commonInterfaceType, "ExchangeOperatorService",
                WellKnownObjectMode.SingleCall);
            Console.WriteLine("Press ENTER to finish...");
            Console.ReadLine();
        }
    }
}
