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
    public class EnglishStoryManager : IEnglishStoryService
    {
        private readonly IEnglishStoryDal _englishStoryDal;

        public EnglishStoryManager(IEnglishStoryDal englishStoryDal)
        {
            _englishStoryDal = englishStoryDal;
        }

        public List<EnglishStory> GetAll()
        {
           return _englishStoryDal.GetAll();
        }

        public void TDelete(EnglishStory t)
        {
            _englishStoryDal.Delete(t);
        }

        public EnglishStory TGetByID(int id)
        {
            return _englishStoryDal.GetByID(id);
        }

        public void TInsert(EnglishStory t)
        {
            _englishStoryDal.Insert(t);
        }

        public void TUpdate(EnglishStory t)
        {
            _englishStoryDal.Update(t);
        }
    }
}
