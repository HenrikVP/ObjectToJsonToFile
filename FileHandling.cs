using System.Text.Json;

namespace JsonToFile
{
    internal class FileHandling
    {

        /// <summary>
        /// Converts an Object to JSON and writes to file
        /// </summary>
        internal void ObjectToJsonToFile(string path, object data)
        {
            string json = JsonSerializer.Serialize(data);
            File.WriteAllText(path, json);
        }

        /// <summary>
        /// Reads file from path and convert JSON to generic type T object
        /// </summary>
        internal T? FileToJsonToObject<T>(string path)
        {
            string json = File.ReadAllText(path);
            T? obj = JsonSerializer.Deserialize<T>(json);
            return obj;
        }
    }
}