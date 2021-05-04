using System;

namespace Command
{
    //UI
    class WebBrowser
    {
        private readonly WebBrowserEngine engine;
        private readonly WebBrowserFavoritesStorage favoritesStorage;

        public WebBrowser(WebBrowserEngine engine, WebBrowserFavoritesStorage favoritesStorage)
        {
            this.engine = engine;
            this.favoritesStorage = favoritesStorage;
        }

        public void GoToPage()
        {
            Console.WriteLine("Enter URL:");
            var url = Console.ReadLine();

            ICommand command = new GoToPageCommand(engine, "http://www."+url);
            command.Execute();
        }

        public void AddToFavorites()
        {
            Console.WriteLine("Enter URL:");
            var url = Console.ReadLine();
            Console.WriteLine("Enter title:");
            var title = Console.ReadLine();

            ICommand command = new AddToFavoritesCommand(favoritesStorage, url, title);
            command.Execute();
        }
    }

}