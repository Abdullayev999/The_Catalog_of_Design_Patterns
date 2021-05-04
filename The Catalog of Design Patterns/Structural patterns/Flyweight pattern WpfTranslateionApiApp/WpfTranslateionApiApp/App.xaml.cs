using GalaSoft.MvvmLight;
using SimpleInjector;
using System.Windows;

using GalaSoft.MvvmLight.Messaging;
using WpfTranslateionApiApp.ViewModels;
using WpfTranslateionApiApp.Messages;

namespace WpfTranslateionApiApp
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static Container Services { get; set; }

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            RegisterServices();
            Start<HomeViewModel>();
        }

        private void Start<T>() where T : ViewModelBase
        {
            var windowViewModel = Services.GetInstance<MainViewModel>();
            windowViewModel.CurrentViewModel = Services.GetInstance<T>();

            var mainWindow = new MainWindow { DataContext = windowViewModel };
            mainWindow.ShowDialog();
        }

        public void RegisterServices()
        {
            Services = new Container();

            Services.RegisterSingleton<IMessenger, Messenger>();
            Services.RegisterSingleton<MainViewModel>();
            Services.RegisterSingleton<TranslationViewModel>();
            Services.RegisterSingleton<HomeViewModel>();
            Services.RegisterSingleton<InformationViewModel>(); 

            Services.Verify();
        }
    }
}
