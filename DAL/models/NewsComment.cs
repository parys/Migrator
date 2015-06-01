using System.Collections.Generic;

namespace DAL.models
{
    public class NewsComment
    {
        public NewsComment()
        {
            this.Comments = new HashSet<NewsComment>();
        }

        public long Id { get; set; }

        public int OldId { get; set; }

        public long MaterialId { get; set; }

        public bool Pending { get; set; }

        public long AdditionTime { get; set; }

        public virtual User Author { get; set; }

        public string Message { get; set; }

        public string Answer { get; set; }

        public virtual ICollection<NewsComment> Comments { get; set; } 

        public long ParentCommentId { get; set; }

        public virtual NewsItem NewsItem { get; set; }

    }
}
