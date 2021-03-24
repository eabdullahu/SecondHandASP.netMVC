using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SecondHand.Models
{
    public class Categories
    {
        [Key]
        public int categoryId { get; set; }
        public int categoryOrder { get; set; } = 1;
        public int categoryParentId { get; set; }
        public int categorySubParentId { get; set; } = 0;
        [Required]
        [StringLength(105)]
        public string categoryTitle { get; set; }
        [StringLength(255)]
        public string categoryThumb { get; set; }

        public bool categoryShowHomepage { get; set; } = false;
    }
}
