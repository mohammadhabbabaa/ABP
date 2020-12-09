using Abp.Application.Services;
using Bicisim.MultiTenancy.Dto;

namespace Bicisim.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

