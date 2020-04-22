using Abp.AutoMapper;
using Mkspec.Spectrends.Authentication.External;

namespace Mkspec.Spectrends.Models.TokenAuth
{
    [AutoMapFrom(typeof(ExternalLoginProviderInfo))]
    public class ExternalLoginProviderInfoModel
    {
        public string Name { get; set; }

        public string ClientId { get; set; }
    }
}
