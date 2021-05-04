using System.Collections.Generic;

namespace Command
{
    //Buisnes logic
    class WebBrowserFavoritesStorage
    {
        public List<Favorite> Favorites;

        public WebBrowserFavoritesStorage()
        {
            Favorites  = new List<Favorite>();
        }
        public void Add(Favorite favorite)
        {
            Favorites.Add(favorite);
        }
    }

}