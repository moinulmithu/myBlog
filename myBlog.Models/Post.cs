using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myBlog.Models
{
    public class Post
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string ShortDescription { get; set; }
        public string Description { get; set; }
        public string Meta { get; set; }
        public string UrlBlog { get; set; }
        public bool IsPublished { get; set; }
        public DateTime PostedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public Category Category { get; set; }
        public virtual ICollection<Tag> Tags { get; set; }

    }
}
