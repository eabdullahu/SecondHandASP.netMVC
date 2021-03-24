using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using System.Security.Claims;
using System.Threading.Tasks;


namespace SecondHand.Models
{
    public class User : IdentityUser
    {

        [StringLength(105)]
        [Required(ErrorMessage = "Please Enter Username")]
        public string UserFirstname { get; set; }

        [StringLength(105)]
        [Required(ErrorMessage = "Please Enter LastName")]
        public string UserLastname { get; set; }



        [DisplayFormat(DataFormatString = "{0:dd MMM yyyy}")]
        [Display(Name = "Date of Birthday")]
        [DataType(DataType.Date)]
        [Required]
        public DateTime UserDOB { get; set; }

        
        public int? UserCityId { get; set; }
        public City? UserCity { get; set; }
        [StringLength(255)]
        public string UserAddress { get; set; }

        [Required]
        public DateTime UserRegisterDate { get; set; } = DateTime.Now;

        [NotMapped]
        [Required, Compare("Password", ErrorMessage = "Password do not match.")]
        public string ConfirmPassword { get; set; }

    }
}