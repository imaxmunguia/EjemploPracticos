using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace EFCodeFirst.Web.Models
{
    public class EFCodeFirstContext : DbContext
    {
        public EFCodeFirstContext()
            : base("connectionStringEFCodeFirst")
        {
        }

        public DbSet<BlogPost> BlogPosts { get; set; }
        public DbSet<BlogComment> BlogComments { get; set; }
    }
}