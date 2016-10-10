using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Serialization
{
    class DataDeserialization
    {
        public Catalog DeserializeXml()
        {
            Catalog catalog;

            ReadingFromXmlFile xmlFile = new ReadingFromXmlFile();

            string filePath = xmlFile.CheckForExisting();

            XmlSerializer serializer = new XmlSerializer(typeof(Catalog));

            using (XmlReader xmlReader = XmlReader.Create(filePath))
            {
                catalog = (Catalog) serializer.Deserialize(xmlReader);
                xmlReader.Close();
            }

            return catalog;
        }
    }
}
