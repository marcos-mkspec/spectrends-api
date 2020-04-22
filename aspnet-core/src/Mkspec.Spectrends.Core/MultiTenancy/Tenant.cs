using Abp.MultiTenancy;
using Mkspec.Spectrends.Authorization.Users;

namespace Mkspec.Spectrends.MultiTenancy
{
    public class Tenant : AbpTenant<User>
    {
        public Tenant()
        {            
        }

        public Tenant(string tenancyName, string name)
            : base(tenancyName, name)
        {
        }
    }
}
