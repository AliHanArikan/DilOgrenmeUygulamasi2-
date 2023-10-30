using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DtoLayer.Dtos.EnglishVocabularyDtos
{
    public class EnglishVocabularyDto
    {
        public string EnglishWord { get; set; }

        public string? TurkishWord { get; set; }

        public string? WordLevel { get; set; }

        public string? EnglishPronunciation { get; set; }
    }
}
