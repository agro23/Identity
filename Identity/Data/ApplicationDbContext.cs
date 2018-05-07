using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Identity.Models;

namespace Identity.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<BlogPost> BlogPosts { get; set; }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<Comment> Comments { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        //protected override void OnConfiguring(DbContextOptionsBuilder options)
        //{
        //    options.UseMySql(@"Server=localhost;Port=8889;database=identity;uid=root;pwd=root;");
        //}

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }

        //public DbSet<Identity.Models.BlogPost> BlogPost { get; set; }
        //public DbSet<Identity.Models.ApplicationUser> ApplicationUser { get; set; }
        //public DbSet<Identity.Models.Comment> Comment { get; set; }
    }
}

//public class IdentityDbContext : IdentityDbContext<ApplicationUser>
//{
//    public DbSet<BlogPost> BlogPosts { get; set; }
//    public DbSet<ApplicationUser> ApplicationUsers { get; set; }
//    public DbSet<Comment> Comments { get; set; }

//    public IdentityDbContext(DbContextOptions options) : base(options)
//    {
//    }

//    public IdentityDbContext()
//    {
//    }

//    protected override void OnConfiguring(DbContextOptionsBuilder options)
//    {
//        options.UseMySql(@"Server=localhost;Port=8889;database=identity;uid=root;pwd=root;");
//    }

//    protected override void OnModelCreating(ModelBuilder builder)
//    {
//        base.OnModelCreating(builder);
//    }

//    public DbSet<Identity.Models.BlogPost> BlogPost { get; set; }
//    public DbSet<Identity.Models.ApplicationUser> ApplicationUser { get; set; }
//    public DbSet<Identity.Models.Comment> Comment { get; set; }

//}
//}
