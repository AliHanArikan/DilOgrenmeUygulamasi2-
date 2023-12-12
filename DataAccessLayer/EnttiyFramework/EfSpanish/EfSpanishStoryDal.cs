using DataAccessLayer.Abstract.Spanish;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using EntityLayer.RequestFeatures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EnttiyFramework.EfSpanish
{
    public class EfSpanishStoryDal : GenericRepository<SpanishStory>, ISpanishStoryDal
    {
        public PagedList<SpanishStory> GetAllBooksWithPaged(SpanishStoriesParameters spanishStoriesParameters)
        {
           using(var context = new Context())
            {
                var values = context.SpanishStories.ToList();
                return PagedList<SpanishStory>.ToPagedList(values, spanishStoriesParameters.PageNumber,spanishStoriesParameters.PagesSize);
                
            }
        }

        
    }
}
