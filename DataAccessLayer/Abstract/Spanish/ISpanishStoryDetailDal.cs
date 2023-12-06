using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract.Spanish
{
    public interface ISpanishStoryDetailDal : IGenericDal<SpanishStoryDetail>
    {
        public SpanishStoryDetail GetSpanishStoryWithStoryName (string storyName);
    }
}
