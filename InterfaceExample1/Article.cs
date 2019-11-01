using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace InterfaceExample1
{
    public class Article
    {
        public Article(string title, string author, DateTime dateTime, string category)
        {
            Title = title;
            Author = author;
            DateTime = dateTime;
            Category = category;
        }
        //needed by XmlSerializer
        public Article() { }

        public string Title { get; set; }
        public string Author { get; set; }
        public DateTime DateTime { get; set; }
        public string Category { get; set; }

        /*
         A Naive solution:
         Our Write method has to deal with different formats which forces us 
         to change our code(add new formats to our switch) each time there is
         a request for a new format
        */
        /// <summary>
        /// Simple Write method that deals with different format using a switch
        /// Weakness: Needs new cases to be added each time there is a need/request for a new format 
        /// </summary>
        /// <param name="format"></param>
        /// <returns>string version of a new format</returns>
        public string Write(string format)
        {
            string str = "";

            switch (format)
            {
                case "xml":
                    XmlSerializer serializer = new XmlSerializer(typeof(Article));
                    var sw = new StringWriter();
                    using (XmlWriter writer = XmlWriter.Create(sw))
                    {
                        serializer.Serialize(writer, this);
                        str = sw.ToString();
                        writer.Close();
                    }

                    break;
                case "json":
                    str = JsonConvert.SerializeObject(this);
                    break;
                default:
                    str = "We do not support this format, send a request for an update";
                    break;
            }

            return str;
        }

        /*
         A better solution:
         After using the IWriter interface we will never need to change our Write method
         because whoever needs a new format should just implement our IWriter interface
         which has a Write method to be implemented
        */
        /// <summary>
        /// takes IWriter as argument and calls the Write method of the type write e.g JsonWriter.Write(this)
        /// or XMLWriter.Write(this). "this" is the Article object, which is passed to the Write method of the
        /// Writer e.g the Write method of the JsonWriter or XMLWriter
        /// </summary>
        /// <param name="writer"></param>
        /// <returns>stringified version of any format e.g json or xml or ...</returns>
        public string Write(IWriter writer)
        {
           return writer.Write(this);
        }
    }
}
