using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfTranslateionApiApp.Models
{
    public class TranslateRequest
    {
        public Data data { get; set; }
        public string q { get; set; }
        public string source { get; set; }
        public string target { get; set; }
        public string format { get; set; }
    }


}
