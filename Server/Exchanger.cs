using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    public class Exchanger : MarshalByRefObject, IExchanger
    {
        public string simpleExchange(string from, string to, double amount)
        {
            double newAmount = 0;
            string exchangeResponse = "";
            if (to == "EUR")
            {
                newAmount = amount / 1.07;
                exchangeResponse = $"€{newAmount}";
            }
            else if (to == "USD")
            {
                newAmount = amount * 1.07;
                exchangeResponse = $"${newAmount}";
            }
            else {
                exchangeResponse = "No se pudo realizar la convercion";
            }

            Console.WriteLine($"Server recived: {from}{amount}");
            Console.WriteLine($"Server sent: {exchangeResponse}");

            return exchangeResponse;
        }
    }
}
