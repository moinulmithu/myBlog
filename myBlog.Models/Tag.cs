﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myBlog.Models
{
    public class Tag
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string UrlBlog { get; set; }
        public string Description { get; set; }
        public virtual ICollection<Post> Posts { get; set; }
    }
}
