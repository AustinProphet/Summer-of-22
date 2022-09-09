using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Dynamic;
using System.Xml;
using System.IO;
using System.Xml.Linq;

namespace XMLConverter
{
    public class SaveLoad
    {
        //public void Save<T>( data, string handle)
        //{
        //    using (var stream = new FileStream(handle, FileMode.Create))
        //    {
        //        var XML = new XmlSerializer(typeof(T));
        //        XML.Serialize(stream, data);
        //    }
        //}

        public static dynamic Convert(XElement parent)
        {
            dynamic dynamicObject = new ExpandoObject();

            dynamicObject.Name = parent.Name.LocalName;
            dynamicObject = parent.Value;

            dynamicObject.HasAttributes = parent.HasAttributes;

            if (parent.HasAttributes)
            {
                dynamicObject.Attributes = new List<KeyValuePair<string, string>>();
                foreach (XAttribute attr in parent.Attributes())
                {
                    KeyValuePair<string, string> temp = new KeyValuePair<string, string>(attr.Name.LocalName, attr.Value);
                    dynamicObject.Attributes.Add(temp);
                }
            }

            dynamicObject.HasElements = parent.HasElements;
            if (parent.HasElements)
            {
                dynamicObject.Elements = new List<dynamic>();
                foreach (XElement element in parent.Elements())
                {
                    dynamic temp = Convert(element);
                    dynamicObject.Elements.Add(temp);
                }
            }
            return dynamicObject;

        }
    }
}

