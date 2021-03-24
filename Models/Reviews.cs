using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SecondHand.Models
{
    public class Reviews
    {
        [Key]
        public int reviewId { get; set; }

        [Required]
        public int productId { get; set; }
        [BindProperty]
        public Products Products { get; set; }

        [Required]
        public int userId { get; set; }
        public  User Users { get; set; }

        [Required]
        [StringLength(155)]
        public string reviewTitle { get; set; }

        [StringLength(255)]
        public string reviewDesc { get; set; }

        [Required]
        public int reviewRate { get; set; }

        public DateTime reviewDt { get; set; } = DateTime.Now;
    }
}
