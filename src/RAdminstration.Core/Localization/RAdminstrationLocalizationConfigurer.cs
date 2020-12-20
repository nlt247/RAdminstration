using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace RAdminstration.Localization
{
    public static class RAdminstrationLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(RAdminstrationConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(RAdminstrationLocalizationConfigurer).GetAssembly(),
                        "RAdminstration.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
