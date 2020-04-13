using System.Collections.Generic;

namespace Mkspec.SpectrendsApi.Authentication.External
{
    public interface IExternalAuthConfiguration
    {
        List<ExternalLoginProviderInfo> Providers { get; }
    }
}
