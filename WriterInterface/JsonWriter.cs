using System;
using Newtonsoft.Json;

namespace WriterInterface
{
   public class JsonWriter : IWriter
    {
        public string Write(Article article)
        {
            return JsonConvert.SerializeObject(article);
        }
    }
}
