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
    public class EfEnglishLessonContentDal : GenericRepository<EnglishLessonContent>, IEnglishLessonContentDal
    {
        public EnglishLessonContent GetEnglishLessonWithEnglishLessonName(string name)
        {
            using(var contex = new Context())
            {
                return contex.EnglishLessonContents.Where(y => y.EnglishTopicName == name).FirstOrDefault();
            }
        }
    }
}
