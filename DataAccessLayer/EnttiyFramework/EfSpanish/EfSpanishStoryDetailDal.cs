using DataAccessLayer.Abstract.Spanish;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EnttiyFramework.EfSpanish
{
    public class EfSpanishStoryDetailDal : GenericRepository<SpanishStoryDetail>, ISpanishStoryDetailDal
    {
        public SpanishStoryDetail GetSpanishStoryWithStoryName(string storyName)
        {
            using (var contex = new Context())
            {
               
                    return contex.spanishStoryDetails.Where(x => x.SpanishStoryDetailsName == storyName).SingleOrDefault();

                
            }
        }
    }
}
