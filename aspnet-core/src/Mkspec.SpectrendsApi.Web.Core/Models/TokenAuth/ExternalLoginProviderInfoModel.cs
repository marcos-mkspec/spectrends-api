using Abp.AutoMapper;
using Mkspec.SpectrendsApi.Authentication.External;

namespace Mkspec.SpectrendsApi.Models.TokenAuth
{
    [AutoMapFrom(typeof(ExternalLoginProviderInfo))]
    public class ExternalLoginProviderInfoModel
    {
        public string Name { get; set; }

        public string ClientId { get; set; }
    }
}
