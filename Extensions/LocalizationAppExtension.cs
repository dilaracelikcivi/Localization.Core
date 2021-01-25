using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Localization.Routing;

namespace Localization.Core.Extensions
{
    public static class LocalizationAppExtension
    {
        public static void UseLocalization(this IApplicationBuilder app)
        {
            var supportedCultures = new[] { "en-US", "tr-TR", "ar", "az"};
            
            var localizationOptions = new RequestLocalizationOptions()
                .SetDefaultCulture(supportedCultures[0])
                .AddSupportedCultures(supportedCultures)
                .AddSupportedUICultures(supportedCultures);
            
            var requestProvider = new RouteDataRequestCultureProvider();
            localizationOptions.RequestCultureProviders.Insert(0, requestProvider);
            
            app.UseRequestLocalization(localizationOptions);
        }
    }
}