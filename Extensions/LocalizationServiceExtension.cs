using System.Globalization;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Localization;
using Microsoft.Extensions.DependencyInjection;

namespace Localization.Core.Extensions
{
    public static class LocalizationServiceExtension
    {
        public static void AddLocalizationService(this IServiceCollection services)
        {
            var cultures = new[]
            {
                new CultureInfo("tr-TR"),
                new CultureInfo("en-US"),
                new CultureInfo("ar"),
                new CultureInfo("az")
            };

            services.Configure<RequestLocalizationOptions>(options =>
            {
                options.SupportedCultures = cultures;
                options.SupportedUICultures = cultures;
                options.DefaultRequestCulture = new RequestCulture("en-US");
            });
        }
    }
}