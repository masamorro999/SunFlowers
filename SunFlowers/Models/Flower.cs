using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SunFlowers.Models
{
    public class Flower
    {
        [Key]
        public int FlowerID { get; set; }

        [Required(ErrorMessage = "You must enter a {0}")]
        [StringLength(50, ErrorMessage = "The field {0} must be below 50 caracters")]
        [Index("Flower_Description_Index", IsUnique = true)]
        public string Descripcion { get; set; }

        [DisplayFormat(DataFormatString ="{0:C2}", ApplyFormatInEditMode =false)]
        public decimal Price { get; set; }
    }
}