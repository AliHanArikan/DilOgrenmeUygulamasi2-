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
    public class EnglishTopicNameManager : IEnglishTopicNameService
    {
        private readonly IEnglishTopicNameDal _englishTopicNameDal;

        public EnglishTopicNameManager(IEnglishTopicNameDal englishTopicNameDal)
        {
            _englishTopicNameDal = englishTopicNameDal;
        }

        public List<EnglishTopic> GetAll()
        {
            return _englishTopicNameDal.GetAll();
        }

        public void TDelete(EnglishTopic t)
        {
            _englishTopicNameDal.Delete(t);
        }

        public EnglishTopic TGetByID(int id)
        {
            return _englishTopicNameDal.GetByID(id);
        }

        public void TInsert(EnglishTopic t)
        {
            _englishTopicNameDal.Insert(t);
        }

        public void TUpdate(EnglishTopic t)
        {
            _englishTopicNameDal.Update(t);
        }
    }
}
