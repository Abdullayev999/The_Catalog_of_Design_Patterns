using Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace Adapter_Pattern
{
    public class JsonSaveLoadAdapter : ISaveLoadAdapter
    {
        private readonly JsonSaveLoad adaptee;

        public JsonSaveLoadAdapter(JsonSaveLoad adaptee)
        {
            this.adaptee = adaptee;
        }

        public List<T> Load<T>(string filePath) where T : class
        {
            if (!Path.HasExtension(filePath)) 
                return adaptee.Load<T>(filePath + ".json");
            
            return adaptee.Load<T>(filePath);
        }

        public void Save<T>(string filePath, List<T> data) where T : class
        {
            if (!Path.HasExtension(filePath))
                adaptee.Save(data, filePath + ".json");
            else
               adaptee.Save(data, filePath);
        }
    }

}
