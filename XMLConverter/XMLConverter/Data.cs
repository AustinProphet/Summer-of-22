using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace XMLConverter
{
    public class Data
    {
        public int Id = 1;
        public string Name = "Config_File";
        public string Description { get; set; }
        public void Save(string fileName)
        {
            using (var stream = new FileStream(fileName, FileMode.Create))
            {
                var XML = new XmlSerializer(typeof(Data));
                XML.Serialize(stream, this);
            }
        }

        public static Data LoadFromFile(string fileName)
        {
            using (var stream = new FileStream(fileName, FileMode.Open))
            {
                var XML = new XmlSerializer(typeof(Data));
                return (Data)XML.Deserialize(stream);
            }
        }
    }
}