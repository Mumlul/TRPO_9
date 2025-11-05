using System.Globalization;
using System.Windows.Data;
using System.Windows.Controls;

namespace TRPO_8.ValidationRules;

public class NumberRules : ValidationRule
{
    public override ValidationResult Validate(object? value, CultureInfo cultureInfo)
    {
        var input = (value ?? "").ToString().Trim();

        if (string.IsNullOrEmpty(input)) return new ValidationResult(false, "Строка не может быть пустой");

        if (input.Any(char.IsLetter)) return new ValidationResult(false, "Строка не может содержать буквы");

        if (input.Length != 5) return new ValidationResult(false, "Длина Id должна соответсововать 5");
        
        return ValidationResult.ValidResult;
    }
}