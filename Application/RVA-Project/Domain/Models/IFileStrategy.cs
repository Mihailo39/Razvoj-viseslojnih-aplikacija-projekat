using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Models
{
    public interface IFileStrategy
    {
        void Save<T>(IEnumerable<T> data, string path);
        IEnumerable<T> Load<T>(string path);
    }
}
