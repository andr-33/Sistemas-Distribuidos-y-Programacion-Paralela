using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    internal class MovieTicket : MarshalByRefObject, IMovieTicket
    {
        public string GetTicketStatus(string stringToPrint)
        {
            string status = "Ticket confirmed";
            Console.WriteLine($"Enquiry: {stringToPrint}");
            Console.WriteLine($"Sending back status: {status}");
            return status;
        }
    }
}
