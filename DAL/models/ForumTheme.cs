using System.Collections.Generic;

namespace DAL.models
{
    public class ForumTheme
    {
        public long Id { get; set; }

        public long IdOld { get; set; }

        public long SectionId { get; set; }

        public ForumSubsection ForumSubsection { get; set; }

        public bool IsPool { get; set; }

        public bool OnTop { get; set; }

        public long LastMessageAdditionTime { get; set; }

        public bool IsClosed { get; set; }

        public int Answers { get; set; }

        public int Views { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public User Author { get; set; }

        public User LastAnswerUser { get; set; }

        public List<ForumMessage> ForumMessages { get; set; }
    }
}
