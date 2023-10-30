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
    public class EnglishLessonContentManager : IEnglishLessonContentService
    {
        private readonly IEnglishLessonContentDal _englishLessonContentDal;

        public EnglishLessonContentManager(IEnglishLessonContentDal englishLessonContentDal)
        {
            _englishLessonContentDal = englishLessonContentDal;
        }

        public List<EnglishLessonContent> GetAll()
        {
            return _englishLessonContentDal.GetAll();
        }

        public void TDelete(EnglishLessonContent t)
        {
            _englishLessonContentDal.Delete(t);
        }

        public EnglishLessonContent TGetByID(int id)
        {
           return _englishLessonContentDal.GetByID(id);
        }

        public EnglishLessonContent TGetEnglishLessonWithEnglishLessonName(string name)
        {
            return _englishLessonContentDal.GetEnglishLessonWithEnglishLessonName(name);
        }

        public void TInsert(EnglishLessonContent t)
        {
           _englishLessonContentDal.Insert(t);
        }

        public void TUpdate(EnglishLessonContent t)
        {
           _englishLessonContentDal.Update(t);
        }
    }
}
