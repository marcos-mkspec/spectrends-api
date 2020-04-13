using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace Mkspec.SpectrendsApi.Localization
{
    public static class SpectrendsApiLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(SpectrendsApiConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(SpectrendsApiLocalizationConfigurer).GetAssembly(),
                        "Mkspec.SpectrendsApi.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
