using System.Globalization;
using System.Windows.Controls;

namespace TRPO_8.ValidationRules;

public class TextRules : ValidationRule
{
    char[] specsimbol=new []{'@',')'};
    
    public override ValidationResult Validate(object? value, CultureInfo cultureInfo)
    {
        var input = value?.ToString().Trim();

        if (string.IsNullOrEmpty(input)) return new ValidationResult(false, "Заполните поле");

        if (input.Any(c => !char.IsLetter(c))) return new ValidationResult(false, "Не должен содержать цифры");
        
        /*if(input.Any(c => specsimbol.Contains(c))) return new ValidationResult(false,)*/
        
        return ValidationResult.ValidResult;
    }
}