namespace BatchGuy.App.Shared.Interface
{
    public interface IJsonSerializationService<T>
    {
        void WriteToJsonFile<T>(string filePath, T objectToWrite, bool append = false);
        T ReadFromJsonFile<T>(string filePath);

        T ReadFromJsonString<T>(string json);
    }
}
