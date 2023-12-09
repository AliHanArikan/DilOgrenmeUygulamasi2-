using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Exceptions
{
    // sealed olması demek kalıtılması mümkün olmayacak demek
    public sealed class EnglishStoryDetailsNotFound : NotFoundException
    {
        public EnglishStoryDetailsNotFound(int id) : base($"The english story id: {id} could not found")//interpolasyon
        {
        }
    }
}
