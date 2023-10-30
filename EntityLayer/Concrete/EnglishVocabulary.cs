using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class EnglishVocabulary
    {
        public int EnglishVocabularyID {  get; set; }

        public string EnglishWord { get; set;}

        public string? TurkishWord { get; set;}

        public string? EnglishPronunciation { get; set;}

        public string? WordLevel { get; set; }
    }
}
