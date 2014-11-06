using Abp.Application.Services.Dto;

namespace Reporter.SitReps.Dtos
{
    public class GetSitRepsInput : IInputDto
    {
        public int? ReporterId { get; set; }
    }
}