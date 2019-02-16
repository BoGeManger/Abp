using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.BG.Authorization.Accounts.Dto;

namespace Abp.BG.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
