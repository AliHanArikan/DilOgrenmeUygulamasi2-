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
    public class EfEnglishStoryDetailsDal : GenericRepository<EnglishStoryDetails>, IEnglishStoryDetailsDal
    {
        public EnglishStoryDetails GetEnglishStoryDetailsWithStoryName(string name)
        {
            using(var context = new Context())
            {
                return context.EnglishStoryDetails.Where(y => y.EnglishStoryDetailsName == name).FirstOrDefault();
            }
        }
    }
}
