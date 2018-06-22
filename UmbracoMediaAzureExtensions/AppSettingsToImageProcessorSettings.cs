using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;

namespace SodaDigital.UmbracoMediaAzureExtensions
{
    internal static class AppSettingsToImageProcessorSettings
    {
        internal static void Map(string prefix, IDictionary<string, string> settings)
        {
            var removePrefix = new Func<string, string>(key => key.Replace(prefix, string.Empty));

            var matchingKeys = ConfigurationManager
                .AppSettings
                .AllKeys
                .Where(key => key.StartsWith(prefix, StringComparison.OrdinalIgnoreCase));

            foreach (var key in matchingKeys)
            {
                settings[removePrefix(key)] = ConfigurationManager.AppSettings[key];
            }
        }
    }
}
