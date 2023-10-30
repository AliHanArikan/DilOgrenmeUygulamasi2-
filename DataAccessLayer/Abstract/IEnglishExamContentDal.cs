using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IEnglishExamContentDal : IGenericDal<EnglishExamContent>
    {
        public EnglishExamContent GetEnglishExamContentWithStoryName(string storyName);
        public List<EnglishExamContent> GetEnglishExamListContentWithStoryName(string storyName);
    }
}
