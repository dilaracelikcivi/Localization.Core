using Microsoft.AspNetCore.Builder;

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

            app.UseRequestLocalization(localizationOptions);
        }
    }
}