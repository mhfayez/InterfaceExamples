﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace InterfaceExample1
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
