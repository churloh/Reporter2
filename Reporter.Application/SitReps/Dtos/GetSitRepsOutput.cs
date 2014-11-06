using System.Collections.Generic;
using Abp.Application.Services.Dto;

namespace Reporter.SitReps.Dtos
{
    public class GetTasksOutput : IOutputDto
    {
        public List<SitRepDto> SitReps { get; set; }
    }
}