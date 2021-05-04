using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows;
using WpfTranslateionApiApp.Messages;
using WpfTranslateionApiApp.Models;

namespace WpfTranslateionApiApp.ViewModels
{
    public class TranslationViewModel : ViewModelBase
    {
        public TranslateCache TranslateCache { get; set; }
        public List<string> LanguageCode { get; set; }
        private WebClient Web { get; set; }
        private TranslateRequest Translate { get; set; }
        public string url { get; set; }

        private readonly IMessenger messenger;

        public TranslationViewModel(IMessenger messenger)
        {
            this.messenger = messenger;
            Init();            
        }

        public void Init()
        {
            TranslateCache = new TranslateCache();
            Web = new WebClient();
            Web.Encoding = Encoding.UTF8;

            LanguageCode = new List<string>()
            {
                "en","az","tr","ru","ka",
                "de","ar","it","ko","uk",
                "uz","no","ja","fr","kn"
            };

            List = new List<string>()
            {
                "English","Azerbaijan","Turkey","Russian","Georgian",
                "German","Arabic", "Italian","Korean", "Ukrainian",
                "Uzbek","Norwegian","Japanese", "French","Kannada"
            };

            url = "https://translation.googleapis.com/language/translate/v2?key=AIzaSyC0zVxrjrGIPGmarXeMxZmpp5OLB2uUUg8";

            SelectFrom = 0;
            SelectTo = 1;
            SizeKB = " 0 Kb";
        }


        private List<string> list;
        private string readInfo;
        private int selectFrom;
        private int selectTo;
        private string from;
        private string to;
        private string sizeKB;

        public string To { get => to; set => Set(ref to, value); }    
        public List<string> List { get => list; set => Set(ref list, value); }
        public string SizeKB { get => sizeKB; set => Set(ref sizeKB, value); }
        public string ReadInfo { get => readInfo; set => Set(ref readInfo, value); }    
        public int SelectFrom { get => selectFrom; set => Set(ref selectFrom, value); }    
        public int SelectTo { get => selectTo; set => Set(ref selectTo, value); }
        public string From
        {
            get => from;
            set { 
                Set(ref from, value);
                TranslateOnline();
                if (from.Length==0) ReadInfo = "";     
            }
        }

        private RelayCommand clearChacheCommand = null;
        private RelayCommand backCommand = null;

        public RelayCommand ClearChacheCommand => clearChacheCommand ??= new RelayCommand(
        () =>
        {
            TranslateCache.CacheClear();
            SizeKB = " 0 Kb";
        });

        public RelayCommand BackCommand => backCommand ??= new RelayCommand(
        () =>
        {
            messenger.Send(new NavigationMessage() { ViewModelType = typeof(HomeViewModel) });
        });
        public void TranslateOnline()
        {
           var result = TranslateCache.GetValue(new Languages() { LanguageFrom = LanguageCode[selectFrom], LanguageTo = LanguageCode[selectTo] }, From);

            if (result !=null)
            {
                To = result;
                ReadInfo = "Read form Cache";
            }
            else
            {
                ReadInfo = "Read from Internet";

                try
                {

                    Translate = new TranslateRequest()
                    {
                        source = LanguageCode[selectFrom],
                        target = LanguageCode[selectTo],
                        format = "text"
                    };
                    Translate.q = From;


                    string answerUploadString = Web.UploadString(url, System.Text.Json.JsonSerializer.Serialize(Translate));

                    var resulTranslateResponse = System.Text.Json.JsonSerializer.Deserialize<TranslateResponse>(answerUploadString);

                    To = resulTranslateResponse.data.translations[0].translatedText;
                    TranslateCache.AddValue(new Languages() { LanguageFrom = LanguageCode[selectFrom], LanguageTo = LanguageCode[selectTo] }, From, To);
                    
                    //vizualizaciya tipa bayti , na 1024 pri umnojenii bolwoe cislo polucayetsa poetomu ne sdelal
                    SizeKB = (TranslateCache.CacheSize() * 17).ToString() +" Kb" ;
                }
                catch (Exception Exception)
                {
                    //   MessageBox.Show(Exception.Message); // kajdiy raz vivodid soobwenie ne sootvetsvuet realnosti Translate Google
                }
            }
        }
    }
}
