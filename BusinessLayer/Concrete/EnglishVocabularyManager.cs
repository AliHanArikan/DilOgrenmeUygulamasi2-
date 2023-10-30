using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class EnglishVocabularyManager : IEnglishVocabularyService
    {
        private readonly IEnglishVocabularyDal _englishVocabularyDal;

        public EnglishVocabularyManager(IEnglishVocabularyDal englishVocabularyDal)
        {
            _englishVocabularyDal = englishVocabularyDal;
        }

        public List<EnglishVocabulary> GetAll()
        {
            return _englishVocabularyDal.GetAll();
        }

        public void TDelete(EnglishVocabulary t)
        {
            _englishVocabularyDal.Delete(t);
        }

        public EnglishVocabulary TGetByID(int id)
        {
            return _englishVocabularyDal.GetByID(id);
        }

        public List<EnglishVocabulary> TGetEnglishVocabularyWithWordLevel(string level)
        {
            return _englishVocabularyDal.GetEnglishVocabularyWithWordLevel(level);
        }

        public void TInsert(EnglishVocabulary t)
        {
            _englishVocabularyDal.Insert(t);
        }

        public void TUpdate(EnglishVocabulary t)
        {
            _englishVocabularyDal.Update(t);
        }
    }
}
