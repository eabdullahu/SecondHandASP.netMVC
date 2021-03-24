using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SecondHand.Models
{
    public class Products
    {
        [Key]
        public int productId { get; set; }

        [Required]
        public int userId { get; set; }
        public User Users { get; set; }


        [Required]
        [StringLength(255)]
        public string productTitle { get; set; }

        [StringLength(5125)]
        public string productDesc { get; set; }

        [Required]
        public int categoryId { get; set; }
        public virtual Categories Categories { get; set; }

        [Required]
        public double productPrice { get; set; }
        [Column(TypeName = "decimal(10,2)")]
        public decimal productDiscount { get; set; } = 0;

        [Required]
        [StringLength(10)]
        public string productSize { get; set; }

        [Required]
        public int productStock { get; set; }

        [StringLength(55)]
        public string productStatus { get; set; } = "new";


        public decimal productShippingPrice { get; set; }
        [NotMapped]
        public int productQuanitity { get; set; } = 0;
        [NotMapped]
        public double productPriceTotal { get; set; } = 0;
        public ICollection<ProductPhotos> Photos { get; set; }
        public ICollection<Reviews> Reviews { get; set; }

        [System.ComponentModel.DefaultValue(typeof(DateTime), "")]
        public DateTime AddDate { get; set; }



    }
}
