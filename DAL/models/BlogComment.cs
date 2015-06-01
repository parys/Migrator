using System.Collections.Generic;

namespace DAL.models
{
    public class BlogComment
    {
        public BlogComment()
        {
            this.Comments = new HashSet<BlogComment>();   
        }

        public long Id { get; set; }

        public int OldId { get; set; }

        public long MaterialId { get; set; }

        public bool Pending { get; set; }

        public long AdditionTime { get; set; }

        public virtual User Author { get; set; }

        public string Message { get; set; }

        public string Answer { get; set; }

        public virtual ICollection<BlogComment> Comments { get; set; } 

        public long ParentCommentId { get; set; }

        public virtual BlogItem BlogItem { get; set; }
    }
}
