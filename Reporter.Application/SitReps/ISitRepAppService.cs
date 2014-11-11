using Abp.Application.Services;
using Reporter.SitReps.Dtos;

namespace Reporter.SitReps
{
    /// <summary>
    /// Defines an application service for <see cref="SitRep"/> operations.
    /// 
    /// It extends <see cref="IApplicationService"/>.
    /// Thus, ABP enables automatic dependency injection, validation and other benefits for it.
    /// 
    /// Application services works with DTOs (Data Transfer Objects).
    /// Service methods gets and returns DTOs.
    /// </summary>
    public interface ISitRepAppService : IApplicationService
    {
        GetSitRepsOutput GetSitReps(GetSitRepsInput input);

        void UpdateSitRep(UpdateSitRepInput input);

        void CreateSitRep(CreateSitRepInput input);
    }
}
