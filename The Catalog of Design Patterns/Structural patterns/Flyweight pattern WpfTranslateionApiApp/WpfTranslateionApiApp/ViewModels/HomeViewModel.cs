using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WpfTranslateionApiApp.Messages;

namespace WpfTranslateionApiApp.ViewModels
{
    public class HomeViewModel : ViewModelBase
    {
        private RelayCommand exitCommand = null;
        private RelayCommand informationCommand = null;
        private RelayCommand translationCommand = null;

        private readonly IMessenger messenger;

        public HomeViewModel(IMessenger messenger)
        {
            this.messenger = messenger;
        }

        public RelayCommand InformationCommand => informationCommand ??= new RelayCommand(
        () =>
        {
            messenger.Send(new NavigationMessage { ViewModelType = typeof(InformationViewModel) });
        });

        public RelayCommand ExitCommand => exitCommand ??= new RelayCommand(
        () =>
        {
            Application.Current.Shutdown();
        });

        public RelayCommand TranslationCommand => translationCommand ??= new RelayCommand(
        () =>
        {
            messenger.Send(new NavigationMessage { ViewModelType = typeof(TranslationViewModel) });
        });


    }
}
