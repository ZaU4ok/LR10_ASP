using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace LR10_ASP
{
    public class NotMondayAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var model = (ConsultationRegistrationViewModel)validationContext.ObjectInstance;

            if (model.SelectedProduct == "Основи" && value is DateTime dt && dt.DayOfWeek == DayOfWeek.Monday)
            {
                return new ValidationResult(ErrorMessage);
            }

            return ValidationResult.Success;
        }
    }
}
