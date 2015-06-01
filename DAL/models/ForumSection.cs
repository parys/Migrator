using System.Collections.Generic;

namespace DAL.models
{
    public class ForumSection
    {
        public ForumSection()
        {
            this.ForumSubsections = new HashSet<ForumSubsection>();
        }

        public long Id { get; set; }

        public long IdOld { get; set; }

        public string Name { get; set; }

        public virtual ICollection<ForumSubsection> ForumSubsections { get; set; }

    }
}
