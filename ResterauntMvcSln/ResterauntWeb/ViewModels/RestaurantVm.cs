using RestaurantData.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace ResterauntWeb.ViewModels
{
    public class RestaurantVm
    {

        public List<Restaurant> restaurants { get; set; }
        public List<Restaurant> Featuredrestaurants { get; set; }
        public List<Restaurant> LatestReviews { get; set; }
        public List<Restaurant> SearchResults { get; set; }



        public int Id { get; set; }
        [Required]
        [StringLength(25, ErrorMessage = "Restaurant Name must be less than 25 charachters")]
        public string Name { get; set; }
        public string Street1 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        [DataType(DataType.PhoneNumber)]
        public string phone { get; set; }
        [DataType(DataType.PostalCode)]

        public string Zipcode { get; set; }




        public ICollection<Reviews> reviews { get; set; }





        public IEnumerable<SelectListItem> SortMethods { get; set; }
        public string SelectedMethod { get; set; }
    }
}