using System.Globalization;
using System.Windows.Controls;

namespace TRPO_8.ValidationRules;

public class PasswordRules:ValidationRule
{
    private char[] specsimbol = new[] { '@', '_' };
    
    public override ValidationResult Validate(object? value, CultureInfo cultureInfo)
    {
        var input = (value ?? "").ToString().Trim();
        
        if(string.IsNullOrEmpty(input))  return new ValidationResult(false, "Заполните поле");

        if (input.Length < 8) return new ValidationResult(false, "Слишком короткий пароль");

        if (!input.Any(char.IsUpper))
            return new ValidationResult(false, "В пароле должна быть заглавная буква");

        if (!input.Any(c => specsimbol.Contains(c))) return new ValidationResult(false, "Пароль должен содержать @/_");
        
        return ValidationResult.ValidResult;
    }
}