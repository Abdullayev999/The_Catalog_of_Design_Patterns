using System.Net;

namespace Command
{
    //Buisnes logic
    class WebBrowserEngine
    {
        public string LoadWebPage(string url)
        {
            WebClient webClient = new WebClient();
            var html = webClient.DownloadString(url);
            return html;
        }
    }

}