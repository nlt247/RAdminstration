using System.Threading.Tasks;
using RAdminstration.Configuration.Dto;

namespace RAdminstration.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
