using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using Utiles;

namespace Client
{
    internal class TCPClient
    {
        static void Main(string[] args)
        {
            TcpClient client = null;
            String fromCurrency;
            String toCurrency;
            String amount;
            String data;

            Console.WriteLine("*********[CLIENTE - Ejer. Conversor de monedas]*********");
            Console.WriteLine("Ingrese la moneda de origen: ");
            fromCurrency = Console.ReadLine();
            Console.WriteLine("Ingrese la moneda de destino: ");
            toCurrency = Console.ReadLine();
            Console.WriteLine("Ingrese la cantidad a convertir: ");
            amount = Console.ReadLine();

            try
            {
                //Configuracion del cliente
                Int32 port = int.Parse(ConfigurationManager.AppSettings["port"]);
                String host = ConfigurationManager.AppSettings["host"];
                client = new TcpClient(host, port);

                data = XMLConversor.createXmlRequest(fromCurrency, toCurrency, amount);

                //Convierte de String a byte
                Byte[] request = Encoding.ASCII.GetBytes(data);

                //Manejador de la data (Esccribe y lee)
                NetworkStream handlerData = client.GetStream();

                //Envia la peticion 
                handlerData.Write(request, 0, request.Length);
                Console.WriteLine($"El cliente envio: {data}");

                //Se reserva un buffer para la respuesta
                Byte[] buffer = new Byte[256];
                data = null;

                //Recibe la respuesta
                Int32 response = handlerData.Read(buffer, 0, buffer.Length);

                //Convierte de byte a String
                data = Encoding.ASCII.GetString(buffer, 0, response);
                data = XMLConversor.interpretXmlResponse(data);

                Console.WriteLine($"El cliente recibio: {data}");
                handlerData.Close();
            }
            catch (ArgumentNullException err)
            {
                Console.WriteLine($"Argumento vacio: {err}");
            }
            catch (SocketException err)
            {
                Console.WriteLine($"Error en el socket: {err}");
            }
            finally {
                client.Close();
            }

            Console.WriteLine("Pulse ENTER para continuar...");
            Console.Read();
        }
    }
}
