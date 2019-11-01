using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample1
{
    class Program
    {
        static void Main(string[] args)
        {

            Article article = new Article("Interfaces", "Dominic", DateTime.Now, "programming");
            Article article2 = new Article("Abstract classes", "James", DateTime.Now, "programming");
            
            string xmlArticle = article.Write("xml");
            string jsonArticle = article.Write("json");
            string htmlDoc = article.Write("html");

           
            Console.WriteLine(xmlArticle);
            Console.WriteLine(jsonArticle);
            Console.WriteLine(htmlDoc);

            Console.WriteLine(article2.Write("json"));

            Console.WriteLine("-------------------------------------");

            //Using the Write method that takes IWriter as parameter
            JsonWriter json = new JsonWriter();

            string jsonformat = article.Write(json);
            Console.WriteLine(jsonformat);

            XMLWriter xml = new XMLWriter();
            string xmldocument = article.Write(xml);
            Console.WriteLine(xmldocument);

            Console.ReadKey();
        }
    }
}
