using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace Domain.Models
{
    public class JsonStrategy : IFileStrategy
    {
        public IEnumerable<T> Load<T>(string path)
        {
            if (!File.Exists(path))
                return new List<T>();

            var json = File.ReadAllText(path);
            return JsonConvert.DeserializeObject<List<T>>(json);
        }

        public void Save<T>(IEnumerable<T> data, string path)
        {
            var json = JsonConvert.SerializeObject(data, Formatting.Indented);
            File.WriteAllText(path, json);
        }
    }
}
