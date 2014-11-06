using System;
using Abp.Application.Services.Dto;

namespace Reporter.SitReps.Dtos
{
    /// <summary>
    /// A DTO class that can be used in various application service methods when needed to send/receive SitRep objects.
    /// </summary>
    public class SitRepDto : EntityDto<int>
    {
        public int? ReporterId { get; set; }

        public string ReporterName { get; set; }

        public string Description { get; set; }

        public DateTime CreationTime { get; set; }
    }
}