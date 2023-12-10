using EntityLayer.Concrete;
using EntityLayer.RequestFeatures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IEnglishStoryService: IGenericService<EnglishStory>
    {
        public IEnumerable<EnglishStory> TGetAllBooksWithPaged(EnglishStoriesParameters englishStoriesParameters);

    }
}
