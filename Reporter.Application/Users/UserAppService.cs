using System.Collections.Generic;
using Abp.Domain.Repositories;
using AutoMapper;
using Reporter.Users.Dtos;

namespace Reporter.Users
{
    public class UserAppService : ReporterAppServiceBase, IUserAppService
    {
        private readonly IRepository<User> userRepository;

        // ABP provides that we can directly inject IRepository<User> (without creating any repository class)
        public UserAppService(IRepository<User> userRepository)
        {
            this.userRepository = userRepository;
        }

        public GetAllUsersOutput GetAllUsers()
        {
            return new GetAllUsersOutput
            {
                Users = Mapper.Map<List<UserDto>>(userRepository.GetAllList())
            };
        }
    }
}