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
    public class EfEnglishVocabularyDal : GenericRepository<EnglishVocabulary>, IEnglishVocabularyDal
    {
        public EnglishVocabulary GetEnglishVocabularyWithEnglishName(string name)
        {
            using(var context = new Context())
            {
                return context.EnglishVocabularies.Where(x => x.EnglishWord == name).FirstOrDefault();
            }
        }

        public EnglishVocabulary GetEnglishVocabularyWithTurkishName(string name)
        {
            using (var context = new Context())
            {
                return context.EnglishVocabularies.Where(x => x.TurkishWord == name).FirstOrDefault();
            }
        }

        public List<EnglishVocabulary> GetEnglishVocabularyWithWordLevel(string level)
        {
            using(var context = new Context())
            {
                return context.EnglishVocabularies.Where(x => x.WordLevel == level).ToList();
            }
        }
    }
}
