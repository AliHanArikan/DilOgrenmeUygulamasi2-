using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IEnglishExamContentService : IGenericService<EnglishExamContent>
    {
        public EnglishExamContent  TGetEnglishExamContentWithStoryName(string storyName);
        public List<EnglishExamContent> TGetEnglishExamContentListWithStoryName(string storyName);
    }
}
