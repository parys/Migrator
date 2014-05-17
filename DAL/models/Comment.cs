using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.models
{
    public class Comment
    {
        public long Id { get; set; }

        public long ModuleId { get; set; }

        public long MaterialId { get; set; }

        public bool Pending { get; set; }

        public long AdditionTime { get; set; }

        public User Author { get; set; }

        public string Message { get; set; }

        public string Answer { get; set; }

       // public List<Comment> comments { get; set; } 

        public long ParentCommentId { get; set; }

    }
}
