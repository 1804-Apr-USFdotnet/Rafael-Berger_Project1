using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantData.Models
{
   public class Reviews
    {
        [Key]
        public int Id { get; set; }
        [Range(1, 10)]
        public int Rating { get; set; }
        [StringLength(200)]
        [DataType(DataType.MultilineText)]
        public string Comments { get; set; }

        public virtual Restauraunt Restaurant { get; set; }
    }
}
