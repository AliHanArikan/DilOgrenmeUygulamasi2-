﻿using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using EntityLayer.RequestFeatures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EnttiyFramework
{
    public class EfEnglishStoryDal : GenericRepository<EnglishStory>, IEnglishStoryDal
    {
        public PagedList<EnglishStory> GetAllBooksWithPaged(EnglishStoriesParameters englishStoriesParameters)
        {
            using(var context = new Context())
            {
                var values = context.EnglishStroies.ToList();
                   // .OrderBy(b => b.EnglishStoryID)
                   
                return PagedList<EnglishStory>.ToPagedList(values, englishStoriesParameters.PageNumber, englishStoriesParameters.PagesSize);

            }
        }

        public void UpdateImageUrlAndStoyNameWithStoryName(string name)
        {
            using (var context = new Context())
            {
              var value=  context.EnglishStroies.Where(y => y.EnglishStoryName == name).FirstOrDefault();
                
            }
        }
    }
}
