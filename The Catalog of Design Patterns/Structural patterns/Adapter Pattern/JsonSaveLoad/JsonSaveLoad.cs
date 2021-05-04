using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace Json
{
    public class JsonSaveLoad
    {
        public void Save<T>(List<T> data,string filePath) where T : class
        {
            var json = JsonSerializer.Serialize(data);
            File.WriteAllText(filePath, json);
        }

        public List<T> Load<T>(string filePath) where T : class
        {
            if (File.Exists(filePath))
            {
                var json = File.ReadAllText(filePath);
                return JsonSerializer.Deserialize<List<T>>(json);
            }
            return new List<T>() ;
        }

    }
}
