using System;

namespace WpfTranslateionApiApp.Models
{
    public class Languages
    {
        public string LanguageFrom { get; set; }
        public string LanguageTo { get; set; }

        public override bool Equals(object obj)
        {
            if (obj is Languages languages)
            {
                return languages.LanguageFrom.Equals(LanguageFrom) &&
              languages.LanguageTo.Equals(LanguageTo);
            }
            return false;
        }
        public override int GetHashCode()
        {
            return HashCode.Combine(LanguageFrom,LanguageTo);
        }
    }
}
