using System.Threading.Tasks;
using Abp.Application.Services;
using Bicisim.Sessions.Dto;

namespace Bicisim.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
