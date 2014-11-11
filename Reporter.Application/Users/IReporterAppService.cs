using Abp.Application.Services;
using Reporter.Users.Dtos;

namespace Reporter.Users
{
    public interface IReporterAppService : IApplicationService
    {
        GetAllUsersOutput GetAllUsers();
    }
}
