using BusinessLayer.Abstract;
using DataAccessLayer.Abstract.French;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class FrenchStoryManager : IFrenchStoryService
    {
        private readonly IFrenchStoryDal _frenchStoryDal;

        public FrenchStoryManager(IFrenchStoryDal frenchStoryDal)
        {
            _frenchStoryDal = frenchStoryDal;
        }

        public List<FrenchStory> GetAll()
        {
           return _frenchStoryDal.GetAll();
        }

        public void TDelete(FrenchStory t)
        {
            _frenchStoryDal.Delete(t);
        }

        public FrenchStory TGetByID(int id)
        {
            return _frenchStoryDal.GetByID(id);
        }

        public void TInsert(FrenchStory t)
        {
            _frenchStoryDal.Insert(t);
        }

        public void TUpdate(FrenchStory t)
        {
           _frenchStoryDal.Update(t);
        }
    }
}
