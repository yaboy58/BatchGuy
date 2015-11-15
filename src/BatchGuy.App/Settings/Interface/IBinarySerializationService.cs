using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatchGuy.App.Settings.Interface
{
    public interface IBinarySerializationService<T>
    {
        void WriteToBinaryFile<T>(string filePath, T objectToWrite, bool append = false);
        T ReadFromBinaryFile<T>(string filePath);
    }
}
