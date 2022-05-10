using System.Text.Json;

namespace JsonToFile
{
    internal class FileHandling
    {
        const string path = @"C:\path.json";

        /// <summary>
        /// Converts a Object to JSON and writes to file
        /// </summary>
        public void ObjectToJsonToFile(Object data)
        {
            string content = JsonSerializer.Serialize(data);
            File.WriteAllText(path, content);
        }

        /// <summary>
        /// Reads file from path and convert JSON to type T Object
        /// </summary>
        internal T? FileToJsonToObject<T>()
        {
            string json = File.ReadAllText(path);
            T? obj = JsonSerializer.Deserialize<T>(json);
            return obj;
        }
    }
}