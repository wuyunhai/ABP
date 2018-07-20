using System.Threading.Tasks;
using Abp.Application.Services;
using SecondABP.Sessions.Dto;

namespace SecondABP.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
