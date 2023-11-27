using DataAccessLayer.Abstract.Spanish;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EnttiyFramework.EfSpanish
{
    public class EfSpanishStoryDal : GenericRepository<SpanishStory> , ISpanishStoryDal
    {
    }
}
