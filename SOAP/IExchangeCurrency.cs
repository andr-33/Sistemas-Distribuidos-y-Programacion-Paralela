using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace SOAP
{
    // NOTA: puede usar el comando "Cambiar nombre" del menú "Refactorizar" para cambiar el nombre de interfaz "IExchangeCurrency" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IExchangeCurrency
    {
        [OperationContract]
        ConvertResponse exchange(ConvertRequest request);
    }

    [DataContract]
    public class ConvertRequest {
        Currency from;
        Currency to;
        double amount;

        [DataMember]
        public Currency From {
            get { return this.from; }
            set { this.from = value; }
        }

        [DataMember]
        public Currency To
        {
            get { return this.to; }
            set { this.to = value; }
        }
        [DataMember]
        public double Amount
        {
            get { return this.amount; }
            set { this.amount = value; }
        }
    }

    [DataContract]
    public class ConvertResponse
    {
        Currency to;
        double amount;

        [DataMember]
        public Currency To
        {
            get { return this.to; }
            set { this.to = value; }
        }
        [DataMember]
        public double Amount
        {
            get { return this.amount; }
            set { this.amount = value; }
        }
    }

    [DataContract]
    public enum Currency {
        [EnumMember]
        EUR,
        [EnumMember]
        USD
    }

}
