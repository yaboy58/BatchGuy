using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BatchGuy.App.Shared.Interface
{
    public interface IJsonSerializationService<T>
    {
        void WriteToJsonFile<T>(string filePath, T objectToWrite, bool append = false);
        T ReadFromJsonFile<T>(string filePath);

        T ReadFromJsonString<T>(string json);
    }
}
