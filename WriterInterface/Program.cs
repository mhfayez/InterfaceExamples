using System;


namespace WriterInterface
{
    class Program
    {
        static void Main(string[] args)
        {

            Article article = new Article("C# programming", "Homayoon", DateTime.Now, "prog" );

           // var type = article.Write("xml", article);

            var xml = article.Write(new XMLWriter());
            Console.WriteLine(xml);

            var json = article.Write(new JsonWriter());
            Console.WriteLine(json);

            Console.ReadKey();
        }
    }
}
