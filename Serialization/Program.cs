using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serialization
{
    class Program
    {
        static void Main(string[] args)
        {
            DataDeserialization dd = new DataDeserialization();
            Catalog catalog = dd.DeserializeXml();

            DataSerialization ds = new DataSerialization();
            ds.SerializeXml(catalog);

            Console.ReadKey();
        }
    }
}
