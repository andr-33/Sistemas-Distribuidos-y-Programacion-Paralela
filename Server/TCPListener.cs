using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Net;
using System.Configuration;
using Utiles;

namespace Server
{
    internal class TCPListener
    {
        static void Main(string[] args)
        {
            TcpListener server = null;
            decimal amount = 0;

            Console.WriteLine("*********[SERVIDOR - Ejer. Conversor de monedas]*********");
            
            try
            {
                //Configuracion del servidor
                Int32 port = int.Parse(ConfigurationManager.AppSettings["port"]);
                IPAddress host = IPAddress.Parse(ConfigurationManager.AppSettings["host"]);
                server = new TcpListener(host, port);

                server.Start();

                //Se reserva un buffer para leer la data
                Byte[] buffer = new Byte[256];
                String data = null;

                while (true)
                {
                    Console.WriteLine("Esperando una conexion...");

                    TcpClient client = server.AcceptTcpClient();
                    Console.WriteLine("Cliente conectado al servidor :)");

                    data = null;

                    //Manejador de la data (leer y escribir)
                    NetworkStream handlerData = client.GetStream();

                    Int32 request = handlerData.Read(buffer, 0, buffer.Length);

                    //Convierte de byte a string
                    data = Encoding.ASCII.GetString(buffer, 0, request);
                    Console.WriteLine($"El servidor recibio: {data}");

                    string exchangeOperation = XMLConversor.interpretXmlRequest(data, out amount);

                    //Reglas del negocio
                    if (exchangeOperation == "EUR-USD")
                    {
                        amount = amount * 1.07m;
                        data = XMLConversor.createXmlResponse("USD", amount.ToString());
                    }
                    else if (exchangeOperation == "USD-EUR")
                    {
                        amount = amount / 1.07m;
                        data = XMLConversor.createXmlResponse("EUR", amount.ToString());
                    }
                    else {
                        data = XMLConversor.createXmlResponseError("ERROR: Divisas no reconocidad :(");
                    }

                        //Convierte de string a byte
                        Byte[] response = Encoding.ASCII.GetBytes(data);

                        handlerData.Write(response, 0, response.Length);
                        Console.WriteLine($"El servidor respondio: {data}");
                    

                }
            }
            catch (SocketException err)
            {
                Console.WriteLine($"Error en el socket: {err}");
            }
            finally {
                server.Stop();
            }

            Console.WriteLine("Pulse ENTER para continuar...");
            Console.Read();
        }
    }
}
