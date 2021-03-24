using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SecondHand.Models
{
    public class ProductPhotos
    {
        [Key]
        public int photoId { get; set; }

        [Required]
        public int productId { get; set; }
    
        public Products Product { get; set; }

        public int photoOrder { get; set; } = 1;

        [Required]
        [StringLength(255)]
        public string photoSrc { get; set; }

        [Required]
        [StringLength(255)]
        public string photoThumb { get; set; }
    }
}
