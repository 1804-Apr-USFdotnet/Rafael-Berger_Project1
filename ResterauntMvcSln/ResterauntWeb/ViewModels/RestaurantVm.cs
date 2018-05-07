using RestaurantData.Models;
using System.Collections.Generic;
using System.Web.Mvc;

namespace ResterauntWeb.ViewModels
{
    public class RestaurantVm
    {

        public List<Restaurant> restaurants { get; set; }
        public List<Restaurant> Featuredrestaurants { get; set; }
        public List<Restaurant> LatestReviews { get; set; }

        public List<Restaurant> SearchResults { get; set; }

        public IEnumerable<SelectListItem> SortMethods { get; set; }
        public string SelectedMethod { get; set; }
    }
}