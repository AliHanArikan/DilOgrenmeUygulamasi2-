using BusinessLayer.Abstract.Spanish;
using DataAccessLayer.Abstract.Spanish;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete.Spanish
{
    public class SpanishExamManager : ISpanishExamService
    {
        private readonly ISpanishExamDal _spanishExamDal;

        public SpanishExamManager(ISpanishExamDal spanishExamDal)
        {
            _spanishExamDal = spanishExamDal;
        }

        public List<SpanishExamContent> GetAll()
        {
            return _spanishExamDal.GetAll();
        }

        public void TDelete(SpanishExamContent t)
        {
            _spanishExamDal.Delete(t);
        }

        public SpanishExamContent TGetByID(int id)
        {
            return _spanishExamDal.GetByID(id);
        }

        public void TInsert(SpanishExamContent t)
        {
             _spanishExamDal.Insert(t);
        }

        public void TUpdate(SpanishExamContent t)
        {
           _spanishExamDal.Update(t);
        }
    }
}
