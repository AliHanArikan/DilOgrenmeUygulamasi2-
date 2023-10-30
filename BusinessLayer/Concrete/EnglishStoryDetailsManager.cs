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
    public class EnglishStoryDetailsManager : IEnglishStoryDetailsService
    {
        private readonly IEnglishStoryDetailsDal _englishStoryDetailsDal;

        public EnglishStoryDetailsManager(IEnglishStoryDetailsDal englishStoryDetailsDal)
        {
            _englishStoryDetailsDal = englishStoryDetailsDal;
        }

        public List<EnglishStoryDetails> GetAll()
        {
            return _englishStoryDetailsDal.GetAll();
        }

        public void TDelete(EnglishStoryDetails t)
        {
            _englishStoryDetailsDal.Delete(t);
        }

        public EnglishStoryDetails TGetByID(int id)
        {
           return _englishStoryDetailsDal.GetByID(id);
        }

        public EnglishStoryDetails TGetEnglishStoryDetailsWithStoryName(string name)
        {
            return _englishStoryDetailsDal.GetEnglishStoryDetailsWithStoryName(name);
        }

        public void TInsert(EnglishStoryDetails t)
        {
            _englishStoryDetailsDal.Insert(t);
        }

        public void TUpdate(EnglishStoryDetails t)
        {
            _englishStoryDetailsDal.Update(t);
        }
    }
}
