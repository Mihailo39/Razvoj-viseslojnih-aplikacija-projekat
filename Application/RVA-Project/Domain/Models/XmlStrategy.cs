using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace Domain.Models
{
    public class XmlStrategy : IFileStrategy
    {
        public IEnumerable<T> Load<T>(string path)
        {
            if (!File.Exists(path))
                return new List<T>();

            using (var stream = new FileStream(path, FileMode.Open))
            {
                var serializer = new XmlSerializer(typeof(List<T>));
                return (List<T>)serializer.Deserialize(stream);
            }
        }

        public void Save<T>(IEnumerable<T> data, string path)
        {
            using (var stream = new FileStream(path, FileMode.Create))
            {
                var serializer = new XmlSerializer(typeof(List<T>));
                serializer.Serialize(stream, data.ToList());
            }
        }
    }
}
