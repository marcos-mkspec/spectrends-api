using System.Collections.Generic;

namespace Mkspec.Spectrends.Authentication.External
{
    public interface IExternalAuthConfiguration
    {
        List<ExternalLoginProviderInfo> Providers { get; }
    }
}
