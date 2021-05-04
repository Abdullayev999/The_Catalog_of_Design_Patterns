using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter_Pattern
{
    public interface ISaveLoadAdapter
    {
        void Save<T>(string filePath, List<T> data) where T : class;
        List<T> Load<T>(string filePath) where T : class;
    }
}
