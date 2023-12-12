using BusinessLayer.Abstract.Spanish;
using DataAccessLayer.Abstract.Spanish;
using EntityLayer.Concrete;
using EntityLayer.RequestFeatures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete.Spanish
{
    public class SpanishStoryManager : ISpanishStoryService
    {
        private readonly ISpanishStoryDal _spanishStoryDal;

        public SpanishStoryManager(ISpanishStoryDal spanishStoryDal)
        {
            _spanishStoryDal = spanishStoryDal;
        }

        public List<SpanishStory> GetAll()
        {
           return _spanishStoryDal.GetAll();
        }

        public void TDelete(SpanishStory t)
        {
            _spanishStoryDal.Delete(t);
        }

        public PagedList<SpanishStory> TGetAllBooksWithPaged(SpanishStoriesParameters spanishStoriesParameters)
        {
            return _spanishStoryDal.GetAllBooksWithPaged(spanishStoriesParameters);
        }

        public SpanishStory TGetByID(int id)
        {
           return _spanishStoryDal.GetByID(id);
        }

        public void TInsert(SpanishStory t)
        {
            _spanishStoryDal.Insert(t);
        }

        public void TUpdate(SpanishStory t)
        {
            _spanishStoryDal.Update(t);
        }
    }
}
