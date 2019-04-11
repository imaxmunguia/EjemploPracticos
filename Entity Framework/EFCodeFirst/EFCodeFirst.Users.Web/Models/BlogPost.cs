using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EFCodeFirst.Users.Web.Models
{
    public class BlogPost
    {
        public int BlogPostId { get; set; }

        [Required]
        [StringLength(200)]
        public string Title { get; set; }
        [Required]
        public string Content { get; set; }

        [StringLength(100)]
        public string Author { get; set; }
        public DateTime PublishDate { get; set; }
    }
}