﻿using BusinessLayer.Abstract;
using BusinessLayer.Abstract.Spanish;
using BusinessLayer.Concrete;
using BusinessLayer.Concrete.Spanish;
using DataAccessLayer.Abstract;
using DataAccessLayer.Abstract.French;
using DataAccessLayer.Abstract.Spanish;
using DataAccessLayer.EnttiyFramework;
using DataAccessLayer.EnttiyFramework.EfSpanish;
using DataAccessLayer.EnttiyFramework.French;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace PresentationLayer.Extensions
{
    public static class ServiceExtensions
    {
       

        public static void ConfigureService(this IServiceCollection services)
        {
            services.AddScoped<IEnglishVocabularyDal, EfEnglishVocabularyDal>();
            services.AddScoped<IEnglishVocabularyService, EnglishVocabularyManager>();


            services.AddScoped<IEnglishStoryDal, EfEnglishStoryDal>();
            services.AddScoped<IEnglishStoryService, EnglishStoryManager>();

            services.AddScoped<IEnglishStoryDetailsDal, EfEnglishStoryDetailsDal>();
            services.AddScoped<IEnglishStoryDetailsService, EnglishStoryDetailsManager>();

            services.AddScoped<IEnglishExamContentDal, EfEnglishExamContentDal>();
            services.AddScoped<IEnglishExamContentService, EnglishExamContentManager>();

            services.AddScoped<IFrenchStoryDal, EfFrenchStoryDal>();
            services.AddScoped<IFrenchStoryService, FrenchStoryManager>();

            services.AddScoped<IEnglishTopicNameDal, EfEnglishTopicNameDal>();
            services.AddScoped<IEnglishTopicNameService, EnglishTopicNameManager>();

            services.AddScoped<IEnglishLessonContentDal, EfEnglishLessonContentDal>();
            services.AddScoped<IEnglishLessonContentService, EnglishLessonContentManager>();

            services.AddScoped<ISpanishStoryDal, EfSpanishStoryDal>();
            services.AddScoped<ISpanishStoryService, SpanishStoryManager>();

            services.AddScoped<ISpanishStoryDetailDal, EfSpanishStoryDetailDal>();
            services.AddScoped<ISpanishStoryDetailService, SpanishStoryDetailManager>();

            services.AddScoped<ISpanishExamDal, EfSpanishExamDal>();
            services.AddScoped<ISpanishExamService, SpanishExamManager>();

            services.AddScoped<IMailService,MailManager>();

            services.AddSingleton<ILoggerService, LoggerManager>();
        }
    }
}
