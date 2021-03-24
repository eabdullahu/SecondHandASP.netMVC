using Microsoft.AspNetCore.Components;
using SecondHand.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace SecondHand.Models.AdminHomepage
{

    public class AdminHomepage
    {

        public IEnumerable<Products> Hp_Products { get; set; }
        public IEnumerable<Contents> Hp_Contents { get; set; }
    }
}
