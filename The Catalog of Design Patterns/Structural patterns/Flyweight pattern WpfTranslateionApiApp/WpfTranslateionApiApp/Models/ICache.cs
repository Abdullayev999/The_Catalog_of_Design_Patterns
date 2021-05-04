using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfTranslateionApiApp.Models
{
    interface ICache<TLanguages, Tkey, TValue>
    {
        TValue GetValue(TLanguages languages, Tkey key);
        void AddValue(TLanguages languages, Tkey key, TValue value);
    }
}
