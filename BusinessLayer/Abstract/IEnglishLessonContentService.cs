using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IEnglishLessonContentService : IGenericService<EnglishLessonContent>
    {
       public EnglishLessonContent TGetEnglishLessonWithEnglishLessonName(string name);
    }
}
