using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IEnglishVocabularyDal: IGenericDal<EnglishVocabulary>
    {
        public EnglishVocabulary GetEnglishVocabularyWithEnglishName(string name);
        public EnglishVocabulary GetEnglishVocabularyWithTurkishName(string name);

        public List<EnglishVocabulary> GetEnglishVocabularyWithWordLevel(string name);

    }
}
