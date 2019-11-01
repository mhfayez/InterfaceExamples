using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SqlServer.Server;

namespace InterfaceExample1
{
    class Program
    {
        static void Main(string[] args)
        {

            Article article = new Article("Interfaces", "Dominic", DateTime.Now, "programming");
           
            
            //Using the Write method of Article class that uses a switch to handle different formats
            string xmlArticle = article.Write("xml");
            string jsonArticle = article.Write("json");
            string htmlDoc = article.Write("html");

            Console.WriteLine("---------------- XML Format -------------------");
            Console.WriteLine(xmlArticle);
            Console.WriteLine("---------------- JSON Format -------------------");
            Console.WriteLine(jsonArticle);
            Console.WriteLine("---------------- HTML Format -------------------");
            Console.WriteLine(htmlDoc);


            Console.WriteLine("\n-----------  Using Write method that takes in an argument of object type that implements IWriter -------------\n");

            //Using the Write method that takes in an argument of object type that implements IWriter
            JsonWriter json = new JsonWriter();
            string jsonformat = article.Write(json);
            Console.WriteLine("---------------- JSON Format -------------------");
            Console.WriteLine(jsonformat);

            XMLWriter xml = new XMLWriter();
            string xmldocument = article.Write(xml);
            Console.WriteLine("---------------- XML Format -------------------");
            Console.WriteLine(xmldocument);

            Console.ReadKey();
        }
    }
}
