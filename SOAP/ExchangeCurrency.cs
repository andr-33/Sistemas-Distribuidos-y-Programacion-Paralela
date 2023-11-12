using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace SOAP
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ExchangeCurrency" en el código y en el archivo de configuración a la vez.
    public class ExchangeCurrency : IExchangeCurrency
    {
        public ConvertResponse exchange(ConvertRequest request)
        {
            ConvertResponse response = new ConvertResponse();

            if (request.To == Currency.EUR) {
                response.Amount = Math.Round(request.Amount / 1.07, 2);
            }
            else if(request.To == Currency.USD) {
                response.Amount = request.Amount * 1.07;
            }

            response.To = request.To;

            return response;
        }
    }
}
