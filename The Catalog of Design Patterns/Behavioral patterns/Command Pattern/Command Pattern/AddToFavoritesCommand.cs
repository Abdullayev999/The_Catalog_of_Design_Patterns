namespace Command
{
    class AddToFavoritesCommand : ICommand
    {
        private WebBrowserFavoritesStorage reciever;
        private string url;
        private string title;

        public AddToFavoritesCommand(WebBrowserFavoritesStorage reciever, string url, string title)
        {
            this.url = url;
            this.title = title;
            this.reciever = reciever;
        }

        public void Execute()
        {
            reciever.Add(new Favorite { Title = title, Url = url });
        }
    }

}