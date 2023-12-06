using BusinessLayer.Abstract.Spanish;
using DataAccessLayer.Abstract.Spanish;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete.Spanish
{
    public class SpanishStoryDetailManager : ISpanishStoryDetailService
    {
        private readonly ISpanishStoryDetailDal _spanishStoryDetailDal;

        public SpanishStoryDetailManager(ISpanishStoryDetailDal spanishStoryDetailDal)
        {
            _spanishStoryDetailDal = spanishStoryDetailDal;
        }

        public List<SpanishStoryDetail> GetAll()
        {
            return _spanishStoryDetailDal.GetAll();
        }

        public void TDelete(SpanishStoryDetail t)
        {
             _spanishStoryDetailDal.Delete(t);
        }

        public SpanishStoryDetail TGetByID(int id)
        {
            return _spanishStoryDetailDal.GetByID(id);
        }

        public SpanishStoryDetail TGetSpanishStoryWithStoryName(string storyName)
        {
            return _spanishStoryDetailDal.GetSpanishStoryWithStoryName(storyName);
        }

        public void TInsert(SpanishStoryDetail t)
        {
            _spanishStoryDetailDal.Insert(t);
        }

        public void TUpdate(SpanishStoryDetail t)
        {
           _spanishStoryDetailDal.Update(t);
        }
    }
}
