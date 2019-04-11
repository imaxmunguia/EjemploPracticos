using EFCodeFirst.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace EFCodeFirst.Web.DAL
{
    public class BlogPostRepository
    {
        public List<BlogPost> getAll()
        {
            using (var context = new EFCodeFirstContext())
            {
                return context.BlogPosts.Include(x => x.Comments).ToList();
            }
        }

        internal void Create(BlogPost model)
        {
            try
            {
                using (var context = new EFCodeFirstContext())
                {
                    context.BlogPosts.Add(model);
                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }
    }
}