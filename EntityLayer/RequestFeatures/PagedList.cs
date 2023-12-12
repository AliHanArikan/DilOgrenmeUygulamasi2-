using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.RequestFeatures
{
    //Generic class
    public class PagedList<T> : List<T> 
    {
        //instance member
        public MetaData MetaData { get; set; }
        public PagedList(List<T> items, int count,int pageNumber,int pageSize)
        {
            MetaData = new MetaData()
            {
                TotalCount = count,
                PageSize = pageSize,
                CurrentPage = pageNumber,
                TotalPage = (int)Math.Ceiling(count/(double)pageSize),

            };

            AddRange(items);
        }
        //burayı List<t> olarak düşünebilirsin
        //biz sadece buraya MetaData özelliği kazandırdık

        public static PagedList<T> ToPagedList(IEnumerable<T> source,int pageNumber,int pageSize)
        {
            var count = source.Count();
            var items = source.Skip((pageNumber-1)* pageSize)
                .Take(pageSize)
                .ToList();

            return new PagedList<T>(items, count, pageNumber, pageSize);
        }
    }
        
}
