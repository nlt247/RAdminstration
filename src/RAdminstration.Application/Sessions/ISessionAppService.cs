using System.Threading.Tasks;
using Abp.Application.Services;
using RAdminstration.Sessions.Dto;

namespace RAdminstration.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
