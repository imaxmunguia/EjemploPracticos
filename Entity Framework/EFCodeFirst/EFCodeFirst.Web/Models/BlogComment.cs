using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFCodeFirst.Web.Models
{
    public class BlogComment
    {
        public int BlogCommentId { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }
        public int BlogPostId { get; set; }
        [ForeignKey("BlogPostId")]
        public BlogPost BlogPost { get; set; }
    }
}