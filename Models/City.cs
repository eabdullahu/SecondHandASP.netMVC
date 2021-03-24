using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SecondHand.Models
{
    public class City
    {
        [Key]
        public int cityId { get; set; }

        [StringLength(105)]
        [Required]
        public string cityName { get; set; }

        [StringLength(105)]
        [Required]
        public string cityCode { get; set; }
    }
}
