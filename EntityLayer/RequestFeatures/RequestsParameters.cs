using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.RequestFeatures
{
    //base olacağı için bunu abstarct tanımlıyoruz.
    //burdan bir nesne üretilmesini istemiyoruz
    //yarım bırakılmış bir sınıf gibi düşünülür
    public abstract class RequestsParameters
    {
        const int maxPageSize = 50;


        //Auto-implementet property
        public int PageNumber { get; set; }


        //propfull bir alana ihtiyacımız var
        //burada bir lojik işleteceğiz
        private int _pagesSize;

        public int PagesSize
        {
            get { return _pagesSize; }
            set { _pagesSize = value > maxPageSize ? maxPageSize : value; }
            //burada value maxPageSizeden büyükse maxPageSize dönüyoruz
        }

    }
}
