using System;

namespace Command
{
    class GoToPageCommand : ICommand
    {
        private WebBrowserEngine reciever;
        private string url;

        public GoToPageCommand(WebBrowserEngine reciever, string url)
        {
            this.url = url;
            this.reciever = reciever;
        }

        public void Execute()
        {
            var html = reciever.LoadWebPage(url);
            Console.WriteLine(html);
        }
    }

}