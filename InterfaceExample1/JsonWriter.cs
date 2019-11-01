
using Newtonsoft.Json;

namespace InterfaceExample1
{
    public class JsonWriter : IWriter
    {
        public string Write(Article article)
        {
            return JsonConvert.SerializeObject(article);
        }
    }
}
