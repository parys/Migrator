using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.models
{
    public class NewsCategory
    {
        public int Id { get; set; }

        public int Position { get; set; }

        public int ItemsCount { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string UrlPath { get; set; }
    }
}
