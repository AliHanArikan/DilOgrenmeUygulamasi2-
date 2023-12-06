using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract.Spanish
{
    public interface ISpanishStoryDetailService : IGenericService<SpanishStoryDetail>
    {
        public SpanishStoryDetail TGetSpanishStoryWithStoryName(string storyName);
    }
}
