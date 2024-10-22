using System.Threading.Tasks;
using Abp.Application.Services;
using softtest.Sessions.Dto;

namespace softtest.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
