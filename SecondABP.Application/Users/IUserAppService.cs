using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using SecondABP.Roles.Dto;
using SecondABP.Users.Dto;

namespace SecondABP.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedResultRequestDto, CreateUserDto, UpdateUserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();
    }
}