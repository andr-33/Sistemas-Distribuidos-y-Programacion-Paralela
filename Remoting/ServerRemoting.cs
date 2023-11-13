using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels.Tcp;
using System.Runtime.Remoting.Channels;

namespace Server
{
    internal class ServerRemoting
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ticket Server started...");

            TcpChannel serverChannel = new TcpChannel(9888);
            ChannelServices.RegisterChannel(serverChannel);

            Type commonInterfaceType = Type.GetType("MovieTicket");

            RemotingConfiguration.RegisterWellKnownServiceType(commonInterfaceType, "MovieTicketBooking",
                WellKnownObjectMode.SingleCall);
            Console.WriteLine("Press ENTER to finish...");
            Console.ReadLine();
        }
    }
}
