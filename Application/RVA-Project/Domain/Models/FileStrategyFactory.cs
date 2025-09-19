using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public static class FileStrategyFactory
    {
        public static IFileStrategy Create(string choice)
        {
            switch (choice.ToLower())
            {
                case "xml":
                    return new XmlStrategy();
                case "json":
                    return new JsonStrategy();
                case "csv":
                    return new CsvStrategy();
                default:
                    throw new ArgumentException("Unknown file format.");
            }
        }

    }
}
