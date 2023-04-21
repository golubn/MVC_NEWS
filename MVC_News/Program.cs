global using Microsoft.EntityFrameworkCore;
using FluentAssertions.Common;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.AspNetCore.Localization;
using MVC_News.Data;
using System.Globalization;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddLocalization(options => options.ResourcesPath = "Resorces");
builder.Services.AddControllersWithViews().AddDataAnnotationsLocalization().AddViewLocalization(LanguageViewLocationExpanderFormat.Suffix);

builder.Services.AddLocalization(options =>
{
    options.ResourcesPath = "Resorses";
});

builder.Services.Configure<RequestLocalizationOptions>(options =>
{
    var supportetdCulutes = new[]
    {
        new CultureInfo("en-Us"),
        new CultureInfo("ru-Ru")
    };
    options.DefaultRequestCulture = new RequestCulture("en-Us");
    options.SupportedCultures = supportetdCulutes;
    options.SupportedUICultures = supportetdCulutes;
});

builder.Services.AddDbContext<NewsContext>(
        options => options.UseSqlServer("name=ConnectionString:DefaultConnectionString"));

builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
                .AddCookie(options =>
                {
                    options.LoginPath = new PathString("/Account/Login");
                    options.AccessDeniedPath = new PathString("/Account/Login");
                });
var app = builder.Build();
app.UseRequestLocalization();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=News}/{action=LastFive}/{id?}");

AppDbInit.Seed(app);
app.Run();

