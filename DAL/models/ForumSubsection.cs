using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.models
{
    public class ForumSubsection
    {
        public long Id { get; set; }

        public long IdOld { get; set; }

        public long SectionId { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public int ThemesCount { get; set; }

        public int AnswersCount { get; set; }

        public int Answers { get; set; }

        public int Views { get; set; }

      //  public long LastMessageAdditionTime { get; set; }


        //public bool IsPool { get; set; }

       // public bool OnTop { get; set; }

     //   public string LastPost { get; set; }
    }
}
