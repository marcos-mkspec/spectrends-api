using Abp.MultiTenancy;
using Mkspec.SpectrendsApi.Authorization.Users;

namespace Mkspec.SpectrendsApi.MultiTenancy
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
