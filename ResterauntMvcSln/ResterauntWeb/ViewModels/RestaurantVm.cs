using RestaurantData.Models;
using System.Collections.Generic;
using System.Web.Mvc;

namespace ResterauntWeb.ViewModels
{
    public class RestaurantVm
    {

        public List<Restauraunt> restaurants { get; set; }
        public List<Restauraunt> Featuredrestaurants { get; set; }

        public List<Restauraunt> SearchResults { get; set; }
        public string SearchText { get; set; }
        public IEnumerable<SelectListItem> SortMethods { get; set; }
        public string SelectedMethod { get; set; }
    }
}