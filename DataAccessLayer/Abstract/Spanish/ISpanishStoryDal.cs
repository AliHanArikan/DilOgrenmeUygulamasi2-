using DataAccessLayer.Concrete;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using EntityLayer.RequestFeatures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract.Spanish
{
    public interface ISpanishStoryDal : IGenericDal<SpanishStory>
    {
        public PagedList<SpanishStory> GetAllBooksWithPaged(SpanishStoriesParameters spanishStoriesParameters);
        
    }
}
