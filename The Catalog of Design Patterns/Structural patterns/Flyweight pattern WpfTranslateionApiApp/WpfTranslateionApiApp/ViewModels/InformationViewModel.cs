using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfTranslateionApiApp.Messages;

namespace WpfTranslateionApiApp.ViewModels
{
    public class InformationViewModel : ViewModelBase
    {
        private RelayCommand backCommand = null;

        private readonly IMessenger messenger;

        public InformationViewModel(IMessenger messenger)
        {
            this.messenger = messenger;
        }        

        public RelayCommand BackCommand => backCommand ??= new RelayCommand(
        () =>
        {
            messenger.Send(new NavigationMessage() { ViewModelType = typeof(HomeViewModel) });
        });
    }
}
