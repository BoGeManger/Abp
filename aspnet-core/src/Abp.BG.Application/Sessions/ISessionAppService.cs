using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.BG.Sessions.Dto;

namespace Abp.BG.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
