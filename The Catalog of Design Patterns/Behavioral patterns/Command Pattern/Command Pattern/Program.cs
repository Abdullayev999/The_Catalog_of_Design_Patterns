using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    class Program
    {
        static void Main(string[] args)
        {
            WebBrowserEngine engine = new WebBrowserEngine();
            WebBrowserFavoritesStorage favoritesStorage = new WebBrowserFavoritesStorage();
            WebBrowser browser = new WebBrowser(engine, favoritesStorage);

            try
            {
                int menuSelection;
                while (true)
                {
                    Console.WriteLine("1 - Go to url");
                    Console.WriteLine("2 - Add to favorites");
                    menuSelection = int.Parse(Console.ReadLine());
                    Console.Write(":");

                    switch (menuSelection)
                    {
                        case 1:
                            browser.GoToPage();
                            break;

                        case 2:
                            browser.AddToFavorites();
                            break;

                        default:
                            Console.WriteLine("Error!");
                            break;
                    }
                }
            }
            catch (Exception)
            {

                
            }
        }
    }

    //Base command
    interface ICommand
    {
        void Execute();
    }

}