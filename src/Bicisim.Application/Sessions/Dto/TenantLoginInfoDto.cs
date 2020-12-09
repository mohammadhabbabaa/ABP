using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Bicisim.MultiTenancy;

namespace Bicisim.Sessions.Dto
{
    [AutoMapFrom(typeof(Tenant))]
    public class TenantLoginInfoDto : EntityDto
    {
        public string TenancyName { get; set; }

        public string Name { get; set; }
    }
}
