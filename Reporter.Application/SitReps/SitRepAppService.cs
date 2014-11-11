using System.Collections.Generic;
using Abp.Application.Services;
using Abp.Domain.Repositories;
using AutoMapper;
using Reporter.Users;
using Reporter.SitReps.Dtos;

namespace Reporter.SitReps
{
    /// <summary>
    /// Implements <see cref="ISitRepAppService"/> to perform sit-rep related application functionality.
    /// 
    /// Inherits from <see cref="ApplicationService"/>.
    /// <see cref="ApplicationService"/> contains some basic functionality common for application services (such as logging and localization).
    /// </summary>
    public class SitRepAppService : ReporterAppServiceBase, ISitRepAppService
    {
        //These members set in constructor using constructor injection.

        private readonly ISitRepRepository sitRepRepository;
        private readonly IRepository<User> userRepository;

        /// <summary>
        /// In constructor, we can get needed classes/interfaces.
        /// They are sent here by dependency injection system automatically.
        /// </summary>
        public SitRepAppService(ISitRepRepository sitRepRepository, IRepository<User> userRepository)
        {
            this.sitRepRepository = sitRepRepository;
            this.userRepository = userRepository;
        }

        public GetSitRepsOutput GetSitReps(GetSitRepsInput input)
        {
            // Called specific GetAllWithReporters method of sit-rep repository.
            var sitReps = sitRepRepository.GetAllWithReporters(input.ReporterId);

            // Used AutoMapper to automatically convert List<SitRep> to List<SitRepDto>.
            return new GetSitRepsOutput
            {
                SitReps = Mapper.Map<List<SitRepDto>>(sitReps)
            };
        }

        public void UpdateSitRep(UpdateSitRepInput input)
        {
            //We can use Logger, it's defined in ApplicationService base class.
            Logger.Info("Updating a sit-rep for input: " + input);

            //Retrieving a sit-rep entity with given id using standard Get method of repositories.
            var sitRep = sitRepRepository.Get(input.SitRepId);

            if (input.ReporterId.HasValue)
            {
                sitRep.Reporter = userRepository.Load(input.ReporterId.Value);
            }

            //We even do not call Update method of the repository.
            //Because an application service method is a 'unit of work' scope as default.
            //ABP automatically saves all changes when a 'unit of work' scope ends (without any exception).
        }

        public void CreateSitRep(CreateSitRepInput input)
        {
            //We can use Logger, it's defined in ApplicationService class.
            Logger.Info("Creating a sit-rep for input: " + input);

            //Creating a new sit-rep entity with given input's properties
            var sitRep = new SitRep { Description = input.Description };

            if (input.ReporterId.HasValue)
            {
                sitRep.Reporter = userRepository.Load(input.ReporterId.Value);
            }

            //Saving entity with standard Insert method of repositories.
            sitRepRepository.Insert(sitRep);
        }
    }
}