using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantData.Models
{
    public class SearchAndSortRestaurants
    {
        public List<Restaurant> SearchResturant(string userInput, List<Restaurant> restList)
        {
            List<Restaurant> searchResults = new List<Restaurant>();

            try
            {
              
                    rest.SearchResults = crud.Table.Where(x => x.Name.StartsWith(userInput)).DefaultIfEmpty().ToList();
            }
            catch
            {


            }
            return searchResults;

        }

    }

}
