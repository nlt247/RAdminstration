using System.Threading.Tasks;
using Abp.Application.Services;
using RAdminstration.Authorization.Accounts.Dto;

namespace RAdminstration.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
