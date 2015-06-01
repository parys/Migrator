using System.Collections.Generic;

namespace DAL.models
{
    public class NewsItem
    {
        public NewsItem()
        {
            this.Comments = new HashSet<NewsComment>();
        }

        public int Id { get; set; }

        public int OldId { get; set; }

        public int CategoryId { get; set; }

        public virtual NewsCategory NewsCategory { get; set; }

        public int Year { get; set; }

        public int Month { get; set; }

        public int Day { get; set; }

        public bool Pending { get; set; }

        public bool OnTop { get; set; }

        public bool CanCommentary { get; set; }

        public long AdditionTime { get; set; }

        public int NumberCommentaries { get; set; }

        public virtual User User { get; set; }

        public string Title { get; set; }

        public string Brief { get; set; }

        public string Message { get; set; }

        public int Reads { get; set; }

        public string Source { get; set; }

        public float Rating { get; set; }

        public int RatingNumbers { get; set; }

        public int RatingSumm { get; set; }

        public string PhotoPath { get; set; }

        public long LastModifiedUTC { get; set; }

        public virtual ICollection<NewsComment> Comments { get; set; } 
    }
}
