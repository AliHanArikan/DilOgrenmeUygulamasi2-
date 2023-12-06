using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EnttiyFramework
{
    public class EfEnglishExamContentDal : GenericRepository<EnglishExamContent> , IEnglishExamContentDal
    {
        public EnglishExamContent GetEnglishExamContentWithStoryName(string storyName)
        {
            using(var contex = new Context())
            {
                return contex.EnglishExamContents.Where(x => x.EnglishStoryName == storyName).FirstOrDefault();
            }
        }

        public List<EnglishExamContent> GetEnglishExamListContentWithStoryName(string storyName)
        {
           using(var contex = new Context())
            {
                return contex.EnglishExamContents.Where(x => x.EnglishStoryName == storyName).ToList();
            }
        }

        public void UpdateEnglishExamWithStoryName(List<EnglishExamContent> listContent,string englishStoryName)
        {
           
        }
    }
}
