using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace Mkspec.Spectrends.Localization
{
    public static class SpectrendsLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(SpectrendsConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(SpectrendsLocalizationConfigurer).GetAssembly(),
                        "Mkspec.Spectrends.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
