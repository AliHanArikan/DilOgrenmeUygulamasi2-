using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IMailService
    {
        // gençay Yıldız
        Task SendMessageAsync(string to,string subject,string body,bool isBodyHtml = true);
        Task SendMessageAsync(string[] tos,string subject,string body,bool isBodyHtml = true);
    }
}
