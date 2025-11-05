using System.Globalization;
using System.Windows.Controls;

namespace TRPO_8.ValidationRules;

public class DataRules : ValidationRule
{
    public override ValidationResult Validate(object? value, CultureInfo cultureInfo)
    {
        if (value == null)
            return new ValidationResult(false, "Выберите дату");

        if (value is DateTime selectedDate)
        {
            if (selectedDate > DateTime.Today)
                return new ValidationResult(false, "Дата не может быть больше сегодняшней");

            if (selectedDate.Year < 1900)
                return new ValidationResult(false, "Дата слишком ранняя");
        }
        else
        {
            return new ValidationResult(false, "Неверный формат даты");
        }

        return ValidationResult.ValidResult;
    }
}