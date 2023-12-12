using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using EntityLayer.RequestFeatures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class EnglishStoryManager : IEnglishStoryService
    {
        private readonly IEnglishStoryDal _englishStoryDal;
        private readonly ILoggerService _loggerService;

        public EnglishStoryManager(IEnglishStoryDal englishStoryDal, ILoggerService loggerService)
        {
            _englishStoryDal = englishStoryDal;
            _loggerService = loggerService;
        }

        public List<EnglishStory> GetAll()
        {
            
            
           return _englishStoryDal.GetAll();
        }

        public void TDelete(EnglishStory t)
        {

            if(t == null)
            {
                string message = "This value is null";
                _loggerService.LogInfo(message);
            }
            _englishStoryDal.Delete(t);
        }

        public async Task<(IEnumerable<EnglishStory>, MetaData metaData)> TGetAllBooksWithPaged(EnglishStoriesParameters englishStoriesParameters)
        {
          
            var englishStoriesWithMetaData =  _englishStoryDal.GetAllBooksWithPaged(englishStoriesParameters);
            return (englishStoriesWithMetaData, englishStoriesWithMetaData.MetaData);
        }

        public EnglishStory TGetByID(int id)
        {
            return _englishStoryDal.GetByID(id);
        }

        public void TInsert(EnglishStory t)
        {
            _englishStoryDal.Insert(t);
        }

        public void TUpdate(EnglishStory t)
        {
            if (t == null)
            {
                string message = "This value is null";
                _loggerService.LogInfo(message);
            }
            _englishStoryDal.Update(t);
        }
    }
}
