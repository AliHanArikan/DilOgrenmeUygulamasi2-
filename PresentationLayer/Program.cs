using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.Abstract;
using DataAccessLayer.Abstract.French;
using DataAccessLayer.EnttiyFramework;
using DataAccessLayer.EnttiyFramework.French;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddScoped<IEnglishVocabularyDal,EfEnglishVocabularyDal>();
builder.Services.AddScoped<IEnglishVocabularyService,EnglishVocabularyManager>();

builder.Services.AddScoped<IEnglishStoryDal,EfEnglishStoryDal>();
builder.Services.AddScoped<IEnglishStoryService,EnglishStoryManager>();

builder.Services.AddScoped<IEnglishStoryDetailsDal, EfEnglishStoryDetailsDal>();
builder.Services.AddScoped<IEnglishStoryDetailsService, EnglishStoryDetailsManager>();

builder.Services.AddScoped<IEnglishExamContentDal, EfEnglishExamContentDal>();
builder.Services.AddScoped<IEnglishExamContentService,EnglishExamContentManager>();

builder.Services.AddScoped<IFrenchStoryDal, EfFrenchStoryDal>();
builder.Services.AddScoped<IFrenchStoryService, FrenchStoryManager>();

builder.Services.AddScoped<IEnglishTopicNameDal, EfEnglishTopicNameDal>();
builder.Services.AddScoped<IEnglishTopicNameService, EnglishTopicNameManager>();

builder.Services.AddScoped<IEnglishLessonContentDal, EfEnglishLessonContentDal>();
builder.Services.AddScoped<IEnglishLessonContentService, EnglishLessonContentManager>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();



app.MapControllerRoute(
    name: "default",
    pattern: "{controller=EnglishStroy}/{action=Index}/{id?}");

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
      name: "areas",
      pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
    );
});

app.Run();
