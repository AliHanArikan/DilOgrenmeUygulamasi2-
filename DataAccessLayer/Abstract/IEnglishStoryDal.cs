﻿using EntityLayer.Concrete;
using EntityLayer.RequestFeatures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IEnglishStoryDal : IGenericDal<EnglishStory>
    {
        public void UpdateImageUrlAndStoyNameWithStoryName(string name);

        public  IEnumerable<EnglishStory> GetAllBooksWithPaged(EnglishStoriesParameters englishStoriesParameters);

    }
}
