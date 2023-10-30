using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class SpanishWords
    {
        public int SpanishWordsID { get; set; }
        public string SpanishWord { get; set; }

        public string TurkishWord { get; set; }
        public string? EnglishWord { get; set; }

    }
}
