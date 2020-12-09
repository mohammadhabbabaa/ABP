using System.Threading.Tasks;
using Bicisim.Configuration.Dto;

namespace Bicisim.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
