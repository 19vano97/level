using System.Formats.Asn1;
using _20240503_HW17;

internal class Program
{
    private static void Main(string[] args)
    {
        Weather[,][] weatherCalendar = BL.InitWeatherCalendar();

        UI.GetMainInterface(weatherCalendar);

        // BL.GetAvarageOfKindsOfWeather(weatherCalendar, Weather.Sun, sourceYear: 3);
        // UI.PrintWeatherByDate(weatherCalendar, 4, 1);
        // UI.PrintWeatherByDate(weatherCalendar, 4, 5, 5);
        
        // BL.GetMaxWeatherKinds(weatherCalendar, Weather.Sun, 0);
        // System.Console.WriteLine();
        // BL.GetMaxWeatherKinds(weatherCalendar, Weather.Rainy);
        // UI.PrintWeatherByDate(weatherCalendar, 5, 3);
        // float value = BL.GetAvarageOfKindsOfWeather(weatherCalendar, Weather.Snow, 5 ,3);
        // System.Console.WriteLine(value);

        // Weather test = UI.ChooseWeather();

        // UI.PrintCompareOfTwoYearsOrMonths(weatherCalendar);
    }
}
