namespace _20240503_HW17;

public class BL
{
     public static int EnterIntValue(string message)
    {
        System.Console.Write("Enter {0}: ", message);
        int value = int.Parse(Console.ReadLine());

        return value;
    }

    public static Weather[,][] InitWeatherCalendar()
    {
        Weather[,][] weatherCalendar = new Weather[10, 12][];

        for (int year = 0; year < weatherCalendar.GetLength(0); year++)
        {
            for (int month = 0; month < weatherCalendar.GetLength(1); month++)
            {
                if ((month % 2 == 0 & month < 7) | (month >= 7 & month % 2 != 0))
                {
                    weatherCalendar[year, month] = new Weather[31];
                }
                else if (month == 1)
                {
                    weatherCalendar[year, month] = new Weather[28];
                }
                else
                {
                    weatherCalendar[year, month] = new Weather[30];
                }

                for (int day = 0; day < weatherCalendar[year, month].Length; day++)
                {
                    weatherCalendar[year, month][day] = GetRandomWeather(month);
                }
            }
        }

        return weatherCalendar;
    }

    public static Weather GetRandomWeather(int sourceMonth = 0)
    {
        int shift = GetRandomInt(0, 6),
            shift1 = GetRandomInt(0, 6);

        byte value1 = (byte)Weather.Sun;
        value1 = (byte)(value1 << shift);

        byte value2 = (byte)Weather.Sun;
        value2 = (byte)(value2 << shift1);

        Weather value = (Weather)(value1 ^ value2);

        if (value.HasFlag(Weather.Snow) & sourceMonth + 1 >= (int)MonthsName.March 
                                        & sourceMonth + 1 < (int)MonthsName.December)
        {
            value = GetRandomWeather(sourceMonth);
        }
        
        if (value1 == value2)
        {
            value = GetRandomWeather(sourceMonth);
        }

        return value;
    }

    private static int GetRandomInt(int min = 0, int max = int.MaxValue)
    {
        Random rnd = new Random();

        int rndValue = rnd.Next(min, max);

        return rndValue;
    }

    public static float GetAvarageOfKindsOfWeather(Weather[,][] sourceArray, Weather kind, 
                                                    int sourceYear = -1, int sourceMonth = -1)
    {
        int weatherIndex = 0;
        int daysCount = 0;

        if (sourceYear == -1 && sourceMonth == -1)
        {
            for (int year = 0; year < sourceArray.GetLength(0); year++)
            {
                for (int month = 0; month < sourceArray.GetLength(1); month++)
                {
                    for (int day = 0; day < sourceArray[year, month].Length; day++)
                    {
                        if (sourceArray[year, month][day].HasFlag(kind))
                        {
                            weatherIndex++;
                        }

                        daysCount++;
                    }
                }
            }
        }
        else if (sourceYear >= 0 && sourceMonth == -1)
        {
            for (int month = 0; month < sourceArray.GetLength(1); month++)
            {
                for (int day = 0; day < sourceArray[sourceYear, month].Length; day++)
                {
                    if (sourceArray[sourceYear, month][day].HasFlag(kind))
                    {
                        weatherIndex++;
                    }

                    daysCount++;
                }
            }
        }
        else
        {
            for (int day = 0; day < sourceArray[sourceYear, sourceMonth].Length; day++)
            {
                if (sourceArray[sourceYear, sourceMonth][day].HasFlag(kind))
                {
                    weatherIndex++;
                }

                daysCount++;
            }
        }

        float result = (float)weatherIndex / (float)daysCount;

        return result;
    }

    public static int[] GetMinWeatherKinds(Weather[,][] sourceArray, Weather kind, 
                                            int sourceYear = -1, int sourceMonth = -1)
    {
        if (sourceYear == -1)
        {
            int minValue = int.MaxValue;
            int currentYear = 0;

            for (int year = 0; year < sourceArray.GetLength(0); year++)
            {
                int weatherCounterByKind = 0;

                for (int month = 0; month < sourceArray.GetLength(1); month++)
                {
                    for (int day = 0; day < sourceArray[year, month].Length; day++)
                    {
                        if (sourceArray[year, month][day].HasFlag(kind))
                        {
                            weatherCounterByKind++;
                        }
                    }
                }

                if (minValue > weatherCounterByKind)
                {
                    minValue = weatherCounterByKind;
                    currentYear = year;
                }
            }

            return [currentYear, minValue];
        }
        else if (sourceMonth == -1)
        {
            int minValue = int.MaxValue;
            int currentMonth = 0;

            for (int month = 0; month < sourceArray.GetLength(1); month++)
            {
                int weatherCounterByKind = 0;

                for (int day = 0; day < sourceArray[sourceYear, month].Length; day++)
                {
                    if (sourceArray[sourceYear, month][day].HasFlag(kind))
                    {
                        weatherCounterByKind++;
                    }
                }

                if (minValue > weatherCounterByKind)
                {
                    minValue = weatherCounterByKind;
                    currentMonth = month;
                }
            }

            return [currentMonth, minValue];
        }

        return null;
    }

    public static int[] GetMaxWeatherKinds(Weather[,][] sourceArray, Weather kind, 
                                            int sourceYear = -1, int sourceMonth = -1)
    {
        if (sourceYear == -1)
        {
            int maxValue = int.MinValue;
            int currentYear = 0;

            for (int year = 0; year < sourceArray.GetLength(0); year++)
            {
                int weatherCounterByKind = 0;
                int weatherIndex = 0;

                for (int month = 0; month < sourceArray.GetLength(1); month++)
                {
                    for (int day = 0; day < sourceArray[year, month].Length; day++)
                    {
                        if (sourceArray[year, month][day].HasFlag(kind))
                        {
                            weatherCounterByKind++;
                            weatherIndex++;
                        }
                    }
                }

                if (maxValue < weatherCounterByKind)
                {
                    maxValue = weatherCounterByKind;
                    currentYear = year;
                }
            }

            return [currentYear, maxValue];
        }
        else if (sourceMonth == -1)
        {
            int maxValue = int.MinValue;
            int currentMonth = 0;

            for (int month = 0; month < sourceArray.GetLength(1); month++)
            {
                int weatherCounterByKind = 0;

                for (int day = 0; day < sourceArray[sourceYear, month].Length; day++)
                {
                    if (sourceArray[sourceYear, month][day].HasFlag(kind))
                    {
                        weatherCounterByKind++;
                    }
                }

                if (maxValue < weatherCounterByKind)
                {
                    maxValue = weatherCounterByKind;
                    currentMonth = month;
                }
            }

            return [currentMonth, maxValue];
        }

        return null;
    }

    public static int CompareTwoYearsOrMonths(Weather[,][] sourceArray, int year1 = 0, int month1 = -1, int year2 = 0, 
                                                int month2 = -1, Weather kind = Weather.None)
    {
        if (month1 == -1 || month2 == -1)
        {
            int weatherValues1 = 0;
            int weatherValues2 = 0;

            for (int month = 0; month < sourceArray.GetLength(1); month++)
            {
                for (int day = 0; day < sourceArray[year1, month].Length; day++)
                {
                    if (sourceArray[year1, month][day].HasFlag(kind))
                    {
                        weatherValues1++;
                    }
                }
            }

            for (int month = 0; month < sourceArray.GetLength(1); month++)
            {
                for (int day = 0; day < sourceArray[year2, month].Length; day++)
                {
                    if (sourceArray[year2, month][day].HasFlag(kind))
                    {
                        weatherValues2++;
                    }
                }
            }

            int difference = weatherValues1 - weatherValues2;

            return difference;
        }
        else if (month1 >= 0 & month2 >= 0)
        {
            int weatherValues1 = 0;
            int weatherValues2 = 0;

            for (int day = 0; day < sourceArray[year1, month1].Length; day++)
                {
                    if (sourceArray[year1, month1][day].HasFlag(kind))
                    {
                        weatherValues1++;
                    }
                }

            for (int day = 0; day < sourceArray[year2, month2].Length; day++)
            {
                if (sourceArray[year2, month2][day].HasFlag(kind))
                {
                    weatherValues2++;
                }
            }

            int difference = weatherValues1 - weatherValues2;

            return difference; 
        }

        return int.MinValue;
    }

    public static int GetNumberOfWeather(Weather[,][] sourceArray, int year1 = 0, int month = -1, 
                                                Weather kind = Weather.None)
    {
        if (month == -1)
        {
            int weatherValues = 0;

            for (int monthFor = 0; monthFor < sourceArray.GetLength(1); monthFor++)
            {
                for (int day = 0; day < sourceArray[year1, monthFor].Length; day++)
                {
                    if (sourceArray[year1, monthFor][day].HasFlag(kind))
                    {
                        weatherValues++;
                    }
                }
            }

            return weatherValues;
        }
        else if (month >= 0)
        {
            int weatherValues = 0;

            for (int day = 0; day < sourceArray[year1, month].Length; day++)
                {
                    if (sourceArray[year1, month][day].HasFlag(kind))
                    {
                        weatherValues++;
                    }
                }

            return weatherValues; 
        }

        return -1;
    }
}
