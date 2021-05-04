using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.IO;
using System.Xml.Serialization;

namespace Xml
{
    public class XMLSaveLoad
    {
        public List<T> Load<T>(string filePath) where T : class 
        {
            List<T> list = new List<T>();
            if (File.Exists(filePath))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<T>));
                FileStream stream = new FileStream(filePath, FileMode.Open);
                
                try
                {
                     list = serializer.Deserialize(stream) as List<T> ;
                }
                finally
                {
                    stream.Dispose();
                }
            }

            return list;
        }

        public void Save<T>(string filePath, List<T> data) where T : class
        {
            FileStream stream = new FileStream(filePath, FileMode.OpenOrCreate);
            XmlSerializer serializer = new XmlSerializer(typeof(List<T>));
            try
            {
                serializer.Serialize(stream, data);
            }
            finally
            {
                stream.Dispose();
            }
        }
    }
}
