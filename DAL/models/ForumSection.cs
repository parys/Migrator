using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.models
{
    public class ForumSection
    {
        public long Id { get; set; }

        public long IdOld { get; set; }

        public long ForumId { get; set; }

        public bool IsPool { get; set; }

        public bool OnTop { get; set; }

        public bool LastPost { get; set; }
    }
}
