using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantData.Models
{
   public class Reviews : BaseEntity
    {
        [Key]
        public int Id { get; set; }
        [Required (ErrorMessage = "A Rating is required")]
        [Range(1, 10)]
        public double Rating { get; set; }
        [StringLength(200)]
        [DataType(DataType.MultilineText)]
        public string Comments { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime? Created { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime? Modified { get; set; }
     //  [Required]
        public virtual Restaurant Restaurant { get; set; }
    }
}
