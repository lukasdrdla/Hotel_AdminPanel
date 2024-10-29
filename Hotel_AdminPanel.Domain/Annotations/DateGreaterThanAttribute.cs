using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_AdminPanel.Domain.Annotations
{
    public class DateGreaterThanAttribute : ValidationAttribute
    {
        private readonly string _comparisonProperty;

        public DateGreaterThanAttribute(string comparisonProperty)
        {
            _comparisonProperty = comparisonProperty;
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var comparisonValue = validationContext.ObjectType.GetProperty(_comparisonProperty)
                .GetValue(validationContext.ObjectInstance);

            if (value is DateTime dateTimeValue && comparisonValue is DateTime dateTimeComparison)
            {
                if (dateTimeValue <= dateTimeComparison)
                {
                    return new ValidationResult(ErrorMessage);
                }
            }

            return ValidationResult.Success;
        }
    }
}
