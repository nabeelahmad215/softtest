using System.Threading.Tasks;
using softtest.Configuration.Dto;

namespace softtest.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
