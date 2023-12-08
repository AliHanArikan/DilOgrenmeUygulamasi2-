using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class Context : IdentityDbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            
            optionsBuilder.UseSqlServer("");
        }

        public DbSet<EnglishLessonContent> EnglishLessonContents { get; set; }

        public DbSet<EnglishTopic> EnglishTopics { get; set; }

        public DbSet<SpanishTopic> SpanishTopics { get; set; }
        public DbSet<EnglishVocabulary> EnglishVocabularies { get; set;}
        public DbSet<EnglishStory> EnglishStroies { get; set;}
        public DbSet<EnglishStoryDetails> EnglishStoryDetails { get; set;}
        public DbSet<EnglishExamContent> EnglishExamContents { get;set; }

        public DbSet<FrenchStory> FrenchStories { get; set; }

        public DbSet<SpanishWords> SpanishWords { get; set; }

        public DbSet<SpanishStory> SpanishStories { get; set;}

        public DbSet<SpanishStoryDetail> spanishStoryDetails { get; set; }
        public DbSet<SpanishExamContent> SpanishExamContents { get; set; }
       
    }
}
