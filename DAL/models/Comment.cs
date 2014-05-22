using System.Collections.Generic;

namespace DAL.models
{
    public class Comment
    {
        public long Id { get; set; }

        public int OldId { get; set; }

        public long ModuleId { get; set; }

        public long MaterialId { get; set; }

        public bool Pending { get; set; }

        public long AdditionTime { get; set; }

        public User Author { get; set; }

        public string Message { get; set; }

        public string Answer { get; set; }

        public List<Comment> Comments { get; set; } 

        public long ParentCommentId { get; set; }

    }
}
