using System.Threading.Tasks;
using Abp.BG.Configuration.Dto;

namespace Abp.BG.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
