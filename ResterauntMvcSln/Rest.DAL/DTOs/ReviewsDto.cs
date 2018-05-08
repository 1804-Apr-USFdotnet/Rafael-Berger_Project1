using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rest.DAL.DTOs
{
   public class ReviewsDto
    {

        public int Id { get; set; }
        [Range(1, 10)]
        public double Rating { get; set; }
        [StringLength(200)]
        [DataType(DataType.MultilineText)]
        public string Comments { get; set; }

        public virtual RestaurantDto Restaurant { get; set; }
    }
}
