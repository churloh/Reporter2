using Abp.Application.Services.Dto;

namespace Reporter.Users.Dtos
{
    public class UserDto : EntityDto
    {
        public string Name { get; set; }
    }
}