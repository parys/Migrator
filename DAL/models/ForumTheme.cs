using System.Collections.Generic;

namespace DAL.models
{
    public class ForumTheme
    {
        public ForumTheme()
        {
            this.ForumMessages = new HashSet<ForumMessage>();
        }

        public long Id { get; set; }

        public long IdOld { get; set; }

        public long SectionId { get; set; }

        public virtual ForumSubsection ForumSubsection { get; set; }

        public bool IsPool { get; set; }

        public bool OnTop { get; set; }

        public long LastMessageAdditionTime { get; set; }

        public bool IsClosed { get; set; }

        public int Answers { get; set; }

        public int Views { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public virtual User Author { get; set; }

        public virtual User LastAnswerUser { get; set; }

        public virtual ICollection<ForumMessage> ForumMessages { get; set; }
    }
}
