using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SecondHand.Models.Homepage
{
    public class Homepage
    {
        public IEnumerable<Categories> Hp_Categories { get; set; }
        public IEnumerable<Products> Hp_Products { get; set; }
        public IEnumerable<Contents> Hp_Contents { get; set; }
        public IEnumerable<Reviews> Reviews { get; set; }

        public User Hp_Users { get; set; }
    }
}
