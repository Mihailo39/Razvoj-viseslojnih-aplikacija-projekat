using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;

namespace Domain.Models
{
    public class CsvStrategy : IFileStrategy
    {
        public IEnumerable<T> Load<T>(string path)
        {
            var result = new List<T>();

            if (!File.Exists(path))
                return result;

            var lines = File.ReadAllLines(path);
            if (lines.Length < 2) return result;

            var headers = lines[0].Split(',');

            for (int i = 1; i < lines.Length; i++)
            {
                var values = lines[i].Split(',');
                var obj = Activator.CreateInstance<T>();

                for (int j = 0; j < headers.Length; j++)
                {
                    var prop = typeof(T).GetProperty(headers[j], BindingFlags.Public | BindingFlags.Instance);
                    if (prop != null && j < values.Length)
                    {
                        var converted = Convert.ChangeType(values[j], prop.PropertyType);
                        prop.SetValue(obj, converted);
                    }
                }

                result.Add(obj);
            }

            return result;
        }

        public void Save<T>(IEnumerable<T> data, string path)
        {
            var props = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);

            using (var writer = new StreamWriter(path))
            {
                // Header
                writer.WriteLine(string.Join(",", props.Select(p => p.Name)));

                // Rows
                foreach (var item in data)
                {
                    var values = props.Select(p => p.GetValue(item, null)?.ToString() ?? "");
                    writer.WriteLine(string.Join(",", values));
                }
            }
        }
    }
}
