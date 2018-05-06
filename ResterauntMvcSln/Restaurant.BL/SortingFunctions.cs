using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace RestaurantBL
{
   public class SortingFunctions
    {
        public static IEnumerable<SelectListItem> SortMethods()
        {
            IList<SelectListItem> items = new List<SelectListItem>
            {
                new SelectListItem{Text = "City", Value = "B"},
                new SelectListItem{Text = "Name", Value = "B"}
           

            };
            return items;
        }



    }
}
