using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using Serialization.Properties;

namespace Serialization
{
    class DataSerialization
    {
        public void SerializeXml(Catalog catalog)
        {
            XmlSerializerNamespaces xsNamespaces = new XmlSerializerNamespaces();

            xsNamespaces.Add("","http://library.by/catalog");

            string filePath = Resources.PathForSerialization;

            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Catalog));
            using (FileStream fs = new FileStream(filePath,FileMode.OpenOrCreate))
            {
                XmlWriterSettings xmlWriterSettings = new XmlWriterSettings();
                xmlWriterSettings.Encoding = Encoding.UTF8;
                xmlWriterSettings.Indent = true;

                using (XmlWriter xmlWriter = XmlWriter.Create(fs, xmlWriterSettings))
                {
                    xmlSerializer.Serialize(xmlWriter,catalog,xsNamespaces);
                }
            }
        }
    }
}
