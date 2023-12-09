using BusinessLayer.Abstract;
using BusinessLayer.Abstract.Spanish;
using BusinessLayer.Concrete;
using BusinessLayer.Concrete.Spanish;
using DataAccessLayer.Abstract;
using DataAccessLayer.Abstract.French;
using DataAccessLayer.Abstract.Spanish;
using DataAccessLayer.EnttiyFramework;
using DataAccessLayer.EnttiyFramework.EfSpanish;
using DataAccessLayer.EnttiyFramework.French;
using FluentValidation.AspNetCore;
using PresentationLayer.Extensions;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddAutoMapper(typeof(Program));


builder.Services.ConfigureService();

var app = builder.Build();

var logger = app.Services.GetRequiredService<ILoggerService>(); // ihtiyaç duyduðumuz servisi alýyoruz
app.ConfigureExceptionHandler(logger);

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

if (app.Environment.IsProduction())
{
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
