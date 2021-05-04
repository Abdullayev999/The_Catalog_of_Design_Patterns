using GalaSoft.MvvmLight.Messaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfTranslateionApiApp.Messages
{
    public class NavigationMessage 
    {
        public Type ViewModelType { get; set; }

    }
}
