﻿using System.Collections.Generic;

namespace DAL.models
{
    public class BlogCategory
    {
        public BlogCategory()
        {
            this.BlogItems = new HashSet<BlogItem>();
        }

        public int Id { get; set; }

        public int OldId { get; set; }

        public int Position { get; set; }

        public int ItemsCount { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string UrlPath { get; set; }

        public virtual ICollection<BlogItem> BlogItems { get; set; }
    }
}
