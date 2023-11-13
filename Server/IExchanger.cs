using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    public interface IExchanger
    {
        string simpleExchange(string from, string to, double amount);
    }
}
