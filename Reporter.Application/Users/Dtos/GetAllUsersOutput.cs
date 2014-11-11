using System.Collections.Generic;
using Abp.Application.Services.Dto;

namespace Reporter.Users.Dtos
{
    public class GetAllUsersOutput : IOutputDto
    {
        public List<UserDto> Users { get; set; }
    }
}