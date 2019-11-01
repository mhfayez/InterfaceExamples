using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace WriterInterface
{
    public class Article
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public DateTime DateTime { get; set; }
        public string Category { get; set; }

        public Article(string title, string author, DateTime dateTime, string category)
        {
            Title = title;
            Author = author;
            DateTime = dateTime;
            Category = category;
        }

        public Article() { }

        public string Write(string type, Article article)
        {
            string str = "";

            switch (type)
            {
                case "xml":
                    XmlSerializer serializer = new XmlSerializer(typeof(Article));
                    var sw = new StringWriter();
                    using (XmlWriter writer = XmlWriter.Create(sw))
                    {
                        serializer.Serialize(writer, article);
                        str = sw.ToString();
                        writer.Close();
                    }
                    
                    break;
                case "json":
                    str = JsonConvert.SerializeObject(this);
                    break;
                default:
                    str = "something went berserk";
                    break;

            }

            return str;
        }

        public string Write(IWriter writer)
        {
            return writer.Write(this);
        }
    }
}
