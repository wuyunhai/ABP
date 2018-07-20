using System.Threading.Tasks;
using Abp.Application.Services;
using SecondABP.Authorization.Accounts.Dto;

namespace SecondABP.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
