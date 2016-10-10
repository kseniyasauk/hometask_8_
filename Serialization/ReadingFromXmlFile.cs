using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Serialization.Properties;

namespace Serialization
{
    class ReadingFromXmlFile
    {
        public string CheckForExisting()
        {
            var filePath = Resources.PathForDeserialization;
            if (!File.Exists(filePath))
            {
                throw new FileNotFoundException("File is not found");
            }
            if (new FileInfo(filePath).Length == 0)
            {
                throw new FileLoadException("File is empty");
            }
            
            return filePath;
        }
        
    }
}
