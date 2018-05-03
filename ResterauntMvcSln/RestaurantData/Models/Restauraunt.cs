using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantData.Models
{
   public class Restauraunt
    {

        [Key]
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



        public virtual ICollection<Reviews> reviews { get; set; }

        [NotMapped]
        public int? AvgRating { get; set; }
        public DateTime dateTime { get; set; }
    }
}
