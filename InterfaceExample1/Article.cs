using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public Article() { }

        public string Title { get; set; }
        public string Author { get; set; }
        public DateTime DateTime { get; set; }
        public string Category { get; set; }

        public string Write(string format)
        {
            string result = "";
            switch (format)
            {
                case "xml":
                    result = $"<Article><Author>{Author}</Author></Article>";
                    break;
                case "json":
                    result = $"author: {Author}";
                    break;
                case "html":
                    result = $"<html><head><title>file format</title></head><body>author = {Author}</body></html>";
                    break;
                default:
                    result = $"We dont support this format";
                    break;

            }

            return result;
        }

        public string Write(IWriter writer)
        {
           return writer.Write(this);
        }
    }
}
