using Microsoft.AspNetCore.Mvc.Razor;
using System.Globalization;

namespace GymManager.UI.Extensions;

public static class IServiceCollectionExtensions
{
    public static void DefineViewLocation(this IServiceCollection service, IConfiguration configuration)
    {
        var templateKey = configuration.GetSection("TemplateKey").Value;
        service.Configure<RazorViewEngineOptions>(x =>
        {
            x.ViewLocationFormats.Clear();

            if (templateKey != "Basic")
            {
                x.ViewLocationFormats.Add("Views/" + templateKey + "/{1}/{0}" + RazorViewEngine.ViewExtension);
                x.ViewLocationFormats.Add("Views/" + templateKey + "/Shared/{0}" + RazorViewEngine.ViewExtension);
            }
            x.ViewLocationFormats.Add("Views/Basic/{1}/{0}" + RazorViewEngine.ViewExtension);
            x.ViewLocationFormats.Add("Views/Basic/Shared/{0}" + RazorViewEngine.ViewExtension);
        });
    }

    public static void AddCulture(this IServiceCollection service)
    {
        var suportedCulture = new List<CultureInfo>
        {
            new CultureInfo("pl"),
            new CultureInfo("en"),
        };

        CultureInfo.DefaultThreadCurrentCulture = suportedCulture[0];
        CultureInfo.DefaultThreadCurrentUICulture = suportedCulture[0];

        service.Configure<RequestLocalizationOptions>(options =>
        {
            options.DefaultRequestCulture = new Microsoft.AspNetCore.Localization.RequestCulture(suportedCulture[0]);
            options.SupportedCultures = suportedCulture;
            options.SupportedUICultures = suportedCulture;

        });
    }
}
