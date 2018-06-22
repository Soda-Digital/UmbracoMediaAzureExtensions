using ImageProcessor.Web.Services;

namespace SodaDigital.UmbracoMediaAzureExtensions
{
    public class AppSettingsAwareCloudImageService : CloudImageService
    {
        public AppSettingsAwareCloudImageService()
        {
            var prefix = $"{nameof(AppSettingsAwareCloudImageService)}:";
            AppSettingsToImageProcessorSettings.Map(prefix, base.Settings);
        }
    }
}
