using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace TRPO_8.ValidationRules
{
    class EmptyRules:ValidationRule
    {
        public override ValidationResult Validate(object? value, CultureInfo cultureInfo)
        {
            if (value == null)
                return new ValidationResult(false, "Не может быть пустым");
            var input = value?.ToString().Trim();

            if(input.Length==0)
                return new ValidationResult(false, "Не может быть пустым");

            return ValidationResult.ValidResult;
        }
    }
}
