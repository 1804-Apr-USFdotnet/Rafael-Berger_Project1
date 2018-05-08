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
          
            try
            {
              
                  restList = restList.Where(x => x.Name.StartsWith(userInput)).DefaultIfEmpty().ToList();
            }
            catch(Exception ex)
            {


            }
            return restList;

        }

    }

}
