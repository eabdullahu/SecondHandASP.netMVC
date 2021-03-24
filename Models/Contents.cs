using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SecondHand.Models
{
    public class Contents
    {
        [Key]
        public int contentId { get; set; }

        [Required]
        [StringLength(55)]
        public string contentPage { get; set; }

        [Required]
        public int contentGroup { get; set; }

        public int contentOrder { get; set; } = 1;

        [Required]
        [StringLength(105)]
        public string contentCategory { get; set; }

        [Required]
        [StringLength(155)]
        public string contentTitle { get; set; }

        [StringLength(512)]
        public string contentDesc { get; set; }

        [StringLength(255)]
        public string contentImg { get; set; }

        [StringLength(255)]
        public string contentIcon { get; set; }

        [StringLength(105)]
        public string contentLink { get; set; }

        public DateTime contentDt { get; set; } = DateTime.Now;
    }
}
