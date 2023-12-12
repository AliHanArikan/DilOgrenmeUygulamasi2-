using EntityLayer.Concrete;
using EntityLayer.RequestFeatures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract.Spanish
{
    public interface ISpanishStoryService :IGenericService<SpanishStory>
    {
        public PagedList<SpanishStory> TGetAllBooksWithPaged(SpanishStoriesParameters SpanishStoriesParameters);


    }
}
