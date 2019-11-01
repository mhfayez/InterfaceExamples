using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace WriterInterface
{
    public class XMLWriter : IWriter
    {
        public string Write(Article article)
        {
            string xml = "";
            XmlSerializer serializer = new XmlSerializer(typeof(Article));
            var sw = new StringWriter();
            using (XmlWriter writer = XmlWriter.Create(sw))
            {
                serializer.Serialize(writer, article);
                xml = sw.ToString();
                writer.Close();
            }

            return xml;
        }
    }
}
