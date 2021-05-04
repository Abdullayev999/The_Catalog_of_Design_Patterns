using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using Xml;

namespace Adapter_Pattern
{
    public class XMLSaveLoadAdapter : ISaveLoadAdapter
    {
        private readonly XMLSaveLoad adaptee;

        public XMLSaveLoadAdapter(XMLSaveLoad adaptee)
        {
            this.adaptee = adaptee;
        }

        public List<T> Load<T>(string filePath) where T : class
        {
            if (!Path.HasExtension(filePath))
                return adaptee.Load<T>(filePath + ".xml");

            return adaptee.Load<T>(filePath);
        }

        public void Save<T>(string filePath, List<T> data) where T : class
        {
            if (!Path.HasExtension(filePath))
                adaptee.Save(filePath + ".xml", data);
            else
                adaptee.Save(filePath, data);
        }
    }
}
