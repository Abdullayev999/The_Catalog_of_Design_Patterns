using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfTranslateionApiApp.Models
{
    public class TranslateCache : ICache<Languages, string, string>
    {
        //obwiy kew na vse slucai perevoda
        public List<Dictionary<Languages, Dictionary<string, string>>> DictionaryCache { get; set; }

        public TranslateCache()
        {
            DictionaryCache = new List<Dictionary<Languages, Dictionary<string, string>>>();
        }

        public int  CacheSize()
        {
            int sum = 0;
            foreach (var DictionaryLanguages in DictionaryCache)
            {
                foreach (var DictionaryTranslation in DictionaryLanguages)
                {
                    sum+= DictionaryTranslation.Value.Count();
                }
            }

            return sum;
        }

        public void CacheClear()
        {
            DictionaryCache.Clear();
        }

        public void AddValue(Languages languages, string key, string value)
        {
            foreach (var DictionaryLanguages in DictionaryCache)
            {
                if (!DictionaryLanguages.Any(x=>x.Key.Equals(languages)))
                {
                    DictionaryLanguages[languages] = new Dictionary<string, string>();
                    DictionaryLanguages[languages][key] = value;
                    return;
                }
                else
                {
                    if (!DictionaryLanguages[languages].Any(x=>x.Key.Equals(key)))
                    {
                        DictionaryLanguages[languages][key] = value;
                            return;
                    }
                }
            }

            var subDictionary = new Dictionary<Languages, Dictionary<string, string>>();
            var subSubDictionary = new Dictionary<string, string>();
                subSubDictionary[key] = value;
                subDictionary.Add(languages,subSubDictionary);

            DictionaryCache.Add(subDictionary);
        }

        public string GetValue(Languages languages, string key)
        {
            foreach (var DictionaryLanguages in DictionaryCache)
            {
               
                if (DictionaryLanguages.ContainsKey(languages))
                {
                    foreach (var DictionaryTranslation in DictionaryLanguages[languages])
                    {
                        if (DictionaryTranslation.Key.Equals(key))
                        {
                            return DictionaryTranslation.Value;
                        }
                    }
                }
            }

            return null;
        }
    }
}
