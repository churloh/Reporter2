using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Abp.Application.Services.Dto;
using Abp.Runtime.Validation;

namespace Reporter.SitReps.Dtos
{
    /// <summary>
    /// This DTO class is used to send needed data to <see cref="ISitRepAppService.UpdateSitRep"/> method.
    /// 
    /// Implements <see cref="IInputDto"/>, thus ABP applies standard input process (like automatic validation) for it. 
    /// Implements <see cref="ICustomValidate"/> for additional custom validation.
    /// </summary>
    public class UpdateSitRepInput : IInputDto, ICustomValidate
    {
        [Range(1, int.MaxValue)] //Data annotation attributes work as expected.
        public int SitRepId { get; set; }

        public int? ReporterId { get; set; }

        //Custom validation method. It's valled by ABP after data annotation validations.
        public void AddValidationErrors(List<ValidationResult> results)
        {
            if (ReporterId == null)
            {
                results.Add(new ValidationResult("ReporterId cannot be null in order to update a Sit-Rep!", new[] { "ReporterId" }));
            }
        }

        public override string ToString()
        {
            return string.Format("[UpdateSitRepInput > SitRepId = {0}, ReporterId = {1}]", SitRepId, ReporterId);
        }
    }
}