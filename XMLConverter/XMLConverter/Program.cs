using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Xml;
using System.Xml.Linq;
using System.Dynamic;

namespace XMLConverter
{
    public class Program
    {


        public static void Main(string[] args)
        {

            //var data = new Data();
            //Console.WriteLine("Please Enter a Description for the XML File");
            //data.Description = Console.ReadLine();
            //Console.WriteLine("Please Enter a Name for the XML File");
            //string fileName = Console.ReadLine();
            //data.Save(fileName + ".xml");
            //Console.WriteLine(fileName + ".xml saved to harddrive. /n");
            //Console.WriteLine("Enter XML File to Load.");
            //string newFile = Console.ReadLine();
            //Data loadFile = Data.LoadFromFile(newFile);
            //Console.WriteLine(newFile + " has been loaded successfuly");

            //var doggo = new Pet();
            //var worker = new SaveLoad<Pet>();
            //Console.WriteLine("Enter the Type of Pet you have.");
            //Console.WriteLine("ex. 'Dog', 'Cat', 'Ferret'");
            //doggo.Type = Console.ReadLine();
            //Console.WriteLine("Enter the Name of your pet.");
            //doggo.Name = Console.ReadLine();
            //Console.WriteLine("You have a " + doggo.Type + " named " + doggo.Name);
            //worker.Save(doggo, doggo.Name + ".xml");



            
            Console.WriteLine("Enter Path of XML File to Load.");
            string newfile = Console.ReadLine();
            XElement parent = XElement.Load(newfile);
            var result = SaveLoad.Convert(parent);
            
            Console.WriteLine("Your File Has Been Loaded");



        }
        
        //public static dynamic Convert(XElement parent)
        //{
        //    dynamic dyn_obj = new ExpandoObject();

        //    dyn_obj.Name = parent.Name.LocalName;
        //    dyn_obj.Value = parent.Value;

        //    dyn_obj.HasAttributes = parent.HasAttributes;

        //    if (parent.HasAttributes)
        //    {
        //        dyn_obj.Attributes = new List<KeyValuePair<string, string>>();
        //        foreach (XAttribute attr in parent.Attributes())
        //        {
        //            KeyValuePair<string, string> temp = new KeyValuePair<string, string>(attr.Name.LocalName, attr.Value);
        //            dyn_obj.Attributes.Add(temp);
        //        }
        //    }

        //    dyn_obj.HasElements = parent.HasElements;
        //    if (parent.HasElements)
        //    {
        //        dyn_obj.Elements = new List<dynamic>();
        //        foreach (XElement element in parent.Elements())
        //        {
        //            dynamic temp = Convert(element);
        //            dyn_obj.Elements.Add(temp);
        //        }
        //    }
        //    return dyn_obj;
        //}
    }
}


