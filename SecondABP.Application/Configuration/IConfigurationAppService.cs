using System.Threading.Tasks;
using Abp.Application.Services;
using SecondABP.Configuration.Dto;

namespace SecondABP.Configuration
{
    public interface IConfigurationAppService: IApplicationService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}