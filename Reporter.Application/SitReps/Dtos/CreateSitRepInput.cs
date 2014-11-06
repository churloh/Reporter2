using System.ComponentModel.DataAnnotations;
using Abp.Application.Services.Dto;

namespace Reporter.SitReps.Dtos
{
    public class CreateSitRepInput : IInputDto
    {
        public int? ReporterId { get; set; }

        [Required]
        public string Description { get; set; }

        public override string ToString()
        {
            return string.Format("[CreateSitRepInput > ReporterId = {0}, Description = {1}]", ReporterId, Description);
        }
    }
}