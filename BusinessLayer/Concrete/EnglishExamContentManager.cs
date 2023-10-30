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
    public class EnglishExamContentManager : IEnglishExamContentService
    {
        private readonly IEnglishExamContentDal _englishExamContentDal;

        public EnglishExamContentManager(IEnglishExamContentDal englishExamContentDal)
        {
            _englishExamContentDal = englishExamContentDal;
        }

        public List<EnglishExamContent> GetAll()
        {
            return _englishExamContentDal.GetAll();
        }

        public void TDelete(EnglishExamContent t)
        {
             _englishExamContentDal.Delete(t);
        }

        public EnglishExamContent TGetByID(int id)
        {
            return _englishExamContentDal.GetByID(id);
        }

        public List<EnglishExamContent> TGetEnglishExamContentListWithStoryName(string storyName)
        {
            return _englishExamContentDal.GetEnglishExamListContentWithStoryName(storyName);
        }

        public EnglishExamContent TGetEnglishExamContentWithStoryName(string storyName)
        {
            return _englishExamContentDal.GetEnglishExamContentWithStoryName(storyName);
        }

        public void TInsert(EnglishExamContent t)
        {
            _englishExamContentDal.Insert(t);
        }

        public void TUpdate(EnglishExamContent t)
        {
            _englishExamContentDal.Update(t);
        }
    }
}
