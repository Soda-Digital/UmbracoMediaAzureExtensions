using ImageProcessor.Web.Plugins.AzureBlobCache;
using System.Collections.Generic;

namespace SodaDigital.UmbracoMediaAzureExtensions
{
    public class AppSettingsAwareAzureBlobCache : AzureBlobCache
    {
        public AppSettingsAwareAzureBlobCache(string requestPath, string fullPath, string querystring) : base(requestPath, fullPath, querystring)
        {
        }

        protected override void AugmentSettings(Dictionary<string, string> settings)
        {
            var prefix = $"{nameof(AppSettingsAwareAzureBlobCache)}:";
            AppSettingsToImageProcessorSettings.Map(prefix, settings);
        }
    }
}
