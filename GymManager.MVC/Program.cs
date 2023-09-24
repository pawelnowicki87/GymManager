using GymManager.Application;
using GymManager.Application.Common.Interfaces;
using GymManager.Infrastructure;
using GymManager.MVC.Extensions;
using GymManager.MVC.Middewares;
using Microsoft.AspNetCore.Mvc.Razor;
using NLog.Extensions.Logging;
using NLog.Web;
using System.Globalization;

var builder = WebApplication.CreateBuilder(args);

builder.Logging.ClearProviders();
builder.Logging.SetMinimumLevel(LogLevel.Information);
builder.Logging.AddNLogWeb();





builder.Services.AddApplication();
builder.Services.AddInfrastructure(builder.Configuration);
builder.Services.DefineViewLocation(builder.Configuration);
builder.Services.AddCulture();



    // Add services to the container.
    builder.Services.AddControllersWithViews();

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    app.UseInfrastructure(scope.ServiceProvider.GetRequiredService<IApplicationDbContext>(), app.Services.GetService<IAppSettingsService>(),
        app.Services.GetService<IEmail>());
}



// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseMiddleware<ExceptionHandlerMiddleware>();

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
