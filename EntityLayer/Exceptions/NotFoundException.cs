using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Exceptions
{
    // We define this method as an abstract method because we don't want this class to be refreshed.
    public abstract class NotFoundException : Exception
    {
        protected NotFoundException(string message): base(message)
        {
                
        }
    }

   
}
