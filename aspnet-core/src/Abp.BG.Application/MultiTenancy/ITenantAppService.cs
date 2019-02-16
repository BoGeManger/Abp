using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.BG.MultiTenancy.Dto;

namespace Abp.BG.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

