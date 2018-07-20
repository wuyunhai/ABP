using Abp.Application.Services;
using Abp.Application.Services.Dto;
using SecondABP.MultiTenancy.Dto;

namespace SecondABP.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
