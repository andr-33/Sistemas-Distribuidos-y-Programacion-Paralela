using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using System.Text;
using System.Threading.Tasks;
using Server;

namespace Client
{
    internal class ClientRemoting
    {
        static void Main(string[] args)
        {
            TcpChannel clientChannel = new TcpChannel();
            ChannelServices.RegisterChannel(clientChannel, false);

            Type objectType = typeof(IExchanger);
            IExchanger exchnagerRemoteObject = (IExchanger)Activator.GetObject(objectType,
                "tcp://localhost:13000/ExchangeOperatorService");

            string exchangeResult = exchnagerRemoteObject.simpleExchange("EUR", "USD", 2.3);
            Console.WriteLine($"Result: {exchangeResult}");

            Console.WriteLine("Press ENTER to finish...");
            Console.ReadLine();
        }
    }
}
