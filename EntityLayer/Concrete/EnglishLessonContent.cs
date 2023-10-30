using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class EnglishLessonContent
    {
        public int EnglishLessonContentID { get; set; }
        public string EnglishTopicName { get; set; }
        public string? EnglishLessonImagUrl { get; set; }
        public string EnglishLessonTitleFirst { get; set; }
        public string EnglishLessonContentFirst { get; set; }
        public string? EnglishLessonTitleSecond { get; set; }
        public string? EnglishLessonContentSecond { get; set; }
        public string? EnglishLessonTitleThird { get; set; }
        public string? EnglishLessonContentThird { get; set; }



    }
}
