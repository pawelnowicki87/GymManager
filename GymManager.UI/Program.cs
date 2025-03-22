using GymManager.Application;
using GymManager.Infrastructure;
using GymManager.UI.Extensions;
using GymManager.UI.Middlewares;
using Microsoft.AspNetCore.Mvc.Razor;
using NLog.Web;
using System.Globalization;


var builder = WebApplication.CreateBuilder(args);

builder.Logging.ClearProviders();
builder.Logging.SetMinimumLevel(LogLevel.Information);
builder.Logging.AddNLogWeb();

builder.Services.AddCulture();


builder.Services.AddApplication();
builder.Services.AddInfrastructure(builder.Configuration);

builder.Services.DefineViewLocation(builder.Configuration);


builder.Services.AddControllersWithViews();


var app = builder.Build();

app.UseInfrastructure();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseMiddleware<ExceptionHandlerMiddleware>();

var logger = app.Services.GetService<ILogger<Program>>();


if (app.Environment.IsDevelopment())
{
    logger.LogInformation("Development MODE!!!");
}
else
{
    logger.LogInformation("PRODUCTION MODE");

}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
