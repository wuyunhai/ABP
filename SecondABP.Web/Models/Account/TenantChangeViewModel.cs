using Abp.AutoMapper;
using SecondABP.Sessions.Dto;

namespace SecondABP.Web.Models.Account
{
    [AutoMapFrom(typeof(GetCurrentLoginInformationsOutput))]
    public class TenantChangeViewModel
    {
        public TenantLoginInfoDto Tenant { get; set; }
    }
}