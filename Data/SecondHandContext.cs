using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SecondHand.Models;

namespace SecondHand.Data
{
    public class SecondHandContext : IdentityDbContext<User>
    {
        public SecondHandContext(DbContextOptions<SecondHandContext> options)
            : base(options)
        {
        }
        public DbSet<SecondHand.Models.City> City { get; set; }

        public DbSet<SecondHand.Models.Categories> Categories { get; set; }

        public DbSet<SecondHand.Models.User> Users { get; set; }

        public DbSet<SecondHand.Models.Products> Products { get; set; }

        public DbSet<SecondHand.Models.Reviews> Reviews { get; set; }

        public DbSet<SecondHand.Models.Contents> Contents { get; set; }
        public Task ProductsPhotos { get; internal set; }
    }
}
