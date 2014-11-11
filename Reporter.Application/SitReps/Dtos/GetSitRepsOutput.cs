using System.Collections.Generic;
using Abp.Application.Services.Dto;

namespace Reporter.SitReps.Dtos
{
    public class GetSitRepsOutput : IOutputDto
    {
        public List<SitRepDto> SitReps { get; set; }
    }
}