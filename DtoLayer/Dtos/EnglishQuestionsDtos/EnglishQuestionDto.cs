﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DtoLayer.Dtos.EnglishQuestionsDtos
{
    public class EnglishQuestionDto
    {
       

        public string EnglishStoryName { get; set; }
        public string EnglishExamDescription { get; set; }
        public string EnglishExamOptionA { get; set; }
        public string EnglishExamOptionB { get; set; }
        public string EnglishExamOptionC { get; set; }
        public string EnglishExamOptionD { get; set; }
        public string EnglishExamCorrect { get; set; }
    }
}
