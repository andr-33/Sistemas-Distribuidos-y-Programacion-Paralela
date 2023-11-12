using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Utiles
{
    public class XMLConversor
    {
        public static string interpretXmlRequest(string xmlData, out decimal result){
            XmlDocument document = new XmlDocument();
            document.LoadXml(xmlData);

            var fromNode = document.SelectSingleNode("//from").InnerText;
            var toNode = document.SelectSingleNode("//to").InnerText;
            var unitsNode = document.SelectSingleNode("//units").InnerText;
           
            result = Convert.ToDecimal(unitsNode);

            return String.Concat(fromNode.ToUpper().Trim(), "-", toNode.ToUpper().Trim());
        }

        public static string interpretXmlResponse(string xmlData)
        {
            XmlDocument document = new XmlDocument();
            document.LoadXml(xmlData);

            var toNode = document.SelectSingleNode("//to").InnerText;
            var unitsNode = document.SelectSingleNode("//units").InnerText;

            return String.Concat(toNode.ToUpper().Trim(),": ", unitsNode);
        }

        public static string createXmlResponse(string finalCurrency, string units){
            XmlDocument document = new XmlDocument();
            XmlNode declarationNode = document.CreateXmlDeclaration("1.0", "UTF-8", null);
            document.AppendChild(declarationNode);

            XmlNode responseNode = document.CreateElement("ConvertResponse");
            document.AppendChild(responseNode);

            XmlNode toNode = document.CreateElement("to");
            toNode.InnerText = finalCurrency;
            responseNode.AppendChild(toNode);

            XmlNode unitsNode = document.CreateElement("units");
            unitsNode.InnerText = units;
            responseNode.AppendChild(unitsNode);

            return document.OuterXml;
        }

        public static string createXmlRequest(string from, string to, string units) {
            XmlDocument document = new XmlDocument();
            XmlNode declarationNode = document.CreateXmlDeclaration("1.0", "UTF-8", null);
            document.AppendChild(declarationNode);

            XmlNode requestNode = document.CreateElement("ConvertRequest");
            document.AppendChild(requestNode);

            XmlNode fromNode = document.CreateElement("from");
            fromNode.InnerText = from;
            requestNode.AppendChild(fromNode);

            XmlNode toNode = document.CreateElement("to");
            toNode.InnerText = to;
            requestNode.AppendChild(toNode);

            XmlNode unitsNode = document.CreateElement("units");
            unitsNode.InnerText = units;
            requestNode.AppendChild(unitsNode);

            return document.OuterXml;
        }

        public static string createXmlResponseError(string message)
        {
            XmlDocument document = new XmlDocument();
            XmlNode declarationNode = document.CreateXmlDeclaration("1.0", "UTF-8", null);
            document.AppendChild(declarationNode);
            XmlNode responseNode = document.CreateElement("ConvertResponse");
            responseNode.InnerText = message;
            document.AppendChild(responseNode);
            return document.InnerXml;
        }

    }
}
