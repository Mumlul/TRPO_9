using System.Globalization;
using System.Windows.Data;

namespace TRPO_8.Converters;

public class AgeConverter : IValueConverter
{
    public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        if (value == null)
            return "Дата не указана";
        
        if (value is DateTime birthDate)
        {
            int age = CalculateAge(birthDate);
            
            
            if (age < 18)
                return $"Нет ({age} лет)";
            else
                return $"Да ({age} лет)";
        }
        
        return "Неверный формат даты";
    }

    public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
    
    private int CalculateAge(DateTime birthDate)
    {
        DateTime today = DateTime.Today;
        int age = today.Year - birthDate.Year;
        
        if (birthDate.Date > today.AddYears(-age))
            age--;
            
        return age;
    }
}