namespace _20240503_HW17;

public class UI
{
    public static void GetMainInterface(Weather[,][] sourceArray)
    {
        Console.Clear();

        Console.WriteLine("Menu");
        Console.WriteLine("<S>. Get weather by specific parameter");
        Console.WriteLine("<A>. Get avarage statistics");
        Console.WriteLine("<M>. Get min weather kinds");
        Console.WriteLine("<X>. Get max weather kinds");
        Console.WriteLine("Your choice: ");

        ConsoleKey userChoice;

        do
        {
            Console.SetCursorPosition(13, 5);

            userChoice = Console.ReadKey().Key;
            Console.WriteLine();

            switch (userChoice)
            {
                case ConsoleKey.S:
                    PrintMenuWeatherBySpecParam(sourceArray);
                    break;
                case ConsoleKey.A:
                    PrintAvarageWeatherStats(sourceArray);
                    break;
                case ConsoleKey.M:
                    PrintMinWeatherStats(sourceArray);
                    break;
                case ConsoleKey.X:
                    PrintMaxWeatherStats(sourceArray);
                    break;
                default:
                    break;
            }

        } while (userChoice != ConsoleKey.Escape && userChoice != ConsoleKey.D);
    }

    public static void PrintMenuWeatherBySpecParam(Weather[,][] sourceArray)
    {
        Console.Clear();

        Console.WriteLine("Menu");
        Console.WriteLine("<Y>. Get weather by specific year");
        Console.WriteLine("<M>. Get weather by specific month");
        Console.WriteLine("<D>. Get weather by specific day");
        Console.WriteLine("<Backspace>. Back");
        Console.WriteLine("Your choice: ");

        ConsoleKey userChoice;

        do
        {
            Console.SetCursorPosition(13, 5);

            userChoice = Console.ReadKey().Key;
            Console.WriteLine();

            switch (userChoice)
            {
                case ConsoleKey.Y:
                    int year = BL.EnterIntValue("year");
                    PrintWeatherByDate(sourceArray, year);
                    break;
                case ConsoleKey.M:
                    year = BL.EnterIntValue("year");
                    int month = GetMonth();
                    PrintWeatherByDate(sourceArray, year, month);
                    break;
                case ConsoleKey.D:
                    year = BL.EnterIntValue("year");
                    month = GetMonth();
                    int day = BL.EnterIntValue("day");
                    PrintWeatherByDate(sourceArray, year, month, day);
                    break;
                case ConsoleKey.Backspace:
                    GetMainInterface(sourceArray);
                    break;
                default:
                    Console.SetCursorPosition(13, 7);
                    break;
            }

        } while (userChoice != ConsoleKey.Escape);
    }

    public static void PrintAvarageWeatherStats(Weather[,][] sourceArray)
    {
        Console.Clear();

        Console.WriteLine("Menu");
        Console.WriteLine("<Y>. Get weather statistics by specific year");
        Console.WriteLine("<M>. Get weather statistics by specific month");
        Console.WriteLine("<Backspace>. Back");
        Console.WriteLine("Your choice: ");

        ConsoleKey userChoice;

        do
        {
            Console.SetCursorPosition(13, 4);

            userChoice = Console.ReadKey().Key;
            Console.WriteLine();

            switch (userChoice)
            {
                case ConsoleKey.Y:
                    int year = BL.EnterIntValue("year");

                    for (int i = 0; i < Enum.GetNames(typeof(Weather)).Length - 1; i++)
                    {
                        byte currentWeather = 0b0000000000000001;

                        currentWeather = (byte)(currentWeather << i);

                        float value = BL.GetAvarageOfKindsOfWeather(sourceArray, (Weather)currentWeather, year);

                        OutputWeatherInfoByYearMonthDay(year, floatValue: value, 
                                                        message: $"Avarage {(Weather)currentWeather} days");
                    }
                    break;
                case ConsoleKey.M:
                    year = BL.EnterIntValue("year");
                    int month = GetMonth();
   
                    for (int i = 0; i < Enum.GetNames(typeof(Weather)).Length - 1; i++)
                    {
                        byte currentWeather = 0b0000000000000001;

                        currentWeather = (byte)(currentWeather << i);

                        float value = BL.GetAvarageOfKindsOfWeather(sourceArray, (Weather)currentWeather, year);

                        OutputWeatherInfoByYearMonthDay(year, month, floatValue: value, 
                                                        message: $"Avarage {(Weather)currentWeather} days");
                    }
                    break;

                case ConsoleKey.Backspace:
                    GetMainInterface(sourceArray);
                    break;
                default:
                    Console.SetCursorPosition(13, 6);
                    break;
            }

        } while (userChoice != ConsoleKey.Escape);
    }

    public static void PrintMinWeatherStats(Weather[,][] sourceArray)
    {
        Console.Clear();

        Console.WriteLine("Menu");
        Console.WriteLine("<Y>. Get min weather statistics by all years");
        Console.WriteLine("<U>. Get min weather statistics by specific year");
        Console.WriteLine("<Backspace>. Back");
        Console.WriteLine("Your choice: ");

        ConsoleKey userChoice;

        do
        {
            Console.SetCursorPosition(13, 4);

            userChoice = Console.ReadKey().Key;
            Console.WriteLine();

            switch (userChoice)
            {
                case ConsoleKey.Y:
                    int[] minValue = new int[2];
                    
                    for (int i = 0; i < Enum.GetNames(typeof(Weather)).Length - 1; i++)
                    {
                        byte currentWeather = 0b0000000000000001;

                        currentWeather = (byte)(currentWeather << i);

                        minValue = BL.GetMinWeatherKinds(sourceArray, (Weather)currentWeather);

                        OutputWeatherInfoByYearMonthDay(minValue[0], kind: (Weather)currentWeather, 
                                                        value: minValue[1], message: "minValue");
                    }
                    break;
                case ConsoleKey.U:
                    int year = BL.EnterIntValue("year");

                    for (int i = 0; i < Enum.GetNames(typeof(Weather)).Length - 1; i++)
                    {
                        byte currentWeather = 0b0000000000000001;

                        currentWeather = (byte)(currentWeather << i);

                        minValue = BL.GetMinWeatherKinds(sourceArray, (Weather)currentWeather, year);

                        OutputWeatherInfoByYearMonthDay(year, minValue[0], kind: (Weather)currentWeather, 
                                                        value: minValue[1], message: "minValue");
                    }
                    break;

                case ConsoleKey.Backspace:
                    GetMainInterface(sourceArray);
                    break;
                default:
                    Console.SetCursorPosition(13, 6);
                    break;
            }

        } while (userChoice != ConsoleKey.Escape);
    }

    public static void PrintMaxWeatherStats(Weather[,][] sourceArray)
    {
        Console.Clear();

        Console.WriteLine("Menu");
        Console.WriteLine("<Y>. Get max weather statistics by all years");
        Console.WriteLine("<U>. Get max weather statistics by specific year");
        Console.WriteLine("<Backspace>. Back");
        Console.WriteLine("Your choice: ");

        ConsoleKey userChoice;

        do
        {
            Console.SetCursorPosition(13, 4);

            userChoice = Console.ReadKey().Key;
            Console.WriteLine();

            switch (userChoice)
            {
                case ConsoleKey.Y:
                    int[] minValue = new int[2];
                    
                    for (int i = 0; i < Enum.GetNames(typeof(Weather)).Length - 1; i++)
                    {
                        byte currentWeather = 0b0000000000000001;

                        currentWeather = (byte)(currentWeather << i);

                        minValue = BL.GetMaxWeatherKinds(sourceArray, (Weather)currentWeather);

                        OutputWeatherInfoByYearMonthDay(minValue[0], kind: (Weather)currentWeather, 
                                                        value: minValue[1], message: "maxValue");
                    }
                    break;
                case ConsoleKey.U:
                    int year = BL.EnterIntValue("year");

                    for (int i = 0; i < Enum.GetNames(typeof(Weather)).Length - 1; i++)
                    {
                        byte currentWeather = 0b0000000000000001;

                        currentWeather = (byte)(currentWeather << i);

                        minValue = BL.GetMaxWeatherKinds(sourceArray, (Weather)currentWeather, year);

                        OutputWeatherInfoByYearMonthDay(year, minValue[0], kind: (Weather)currentWeather, 
                                                        value: minValue[1], message: "maxValue");
                    }
                    break;

                case ConsoleKey.Backspace:
                    GetMainInterface(sourceArray);
                    break;
                default:
                    Console.SetCursorPosition(13, 6);
                    break;
            }

        } while (userChoice != ConsoleKey.Escape);
    }

    public static int GetMonth()
    {
        for (int i = 1; i < Enum.GetNames(typeof(MonthsName)).Length; i++)
        {
            if (i == Enum.GetNames(typeof(MonthsName)).Length - 1)
            {
                System.Console.Write("{0}: {1}", (MonthsName)i, i);
                break;
            }

            System.Console.Write("{0}: {1}, ", (MonthsName)i, i);
        }

        System.Console.WriteLine();

        int day = BL.EnterIntValue("your month") - 1;

        return day;
    }

    public static void OutputWeatherInfoByYearMonthDay(int sourceYear = -1, int sourceMonth = -1, int sourceDay = -1,
                                                        float floatValue = -1f, Weather kind = Weather.None, int value = -1,
                                                        string message = null)
    {
        if (sourceYear >= 0 & sourceMonth == -1 & sourceDay == -1 
            & floatValue >= 0f & kind == Weather.None & value == -1)
        {
            System.Console.WriteLine("Year: {0}, {1}: {2}", sourceYear,message, floatValue);
        }
        else if (sourceYear >= 0 & sourceMonth >= 0 & sourceDay == -1 
                    & floatValue >= 0f & kind == Weather.None & value == -1)
        {
            System.Console.WriteLine("Year: {0}, Month: {1}, {2}: {3}", sourceYear, 
                                    (MonthsName)sourceMonth + 1, message, floatValue);
        }
        else if (sourceYear >= 0 & sourceMonth >= 0 & sourceDay >= 0 
                    & floatValue >= 0f & kind == Weather.None & value == -1)
        {
            System.Console.WriteLine("Year: {0}, Month: {1}, Day: {2}, {3}: {4}", sourceYear, 
                                        (MonthsName)sourceMonth + 1, sourceDay, message, floatValue);
        }
        else if (sourceYear >= 0 & sourceMonth == -1 & sourceDay == -1 
                    & floatValue == -1f & (byte)kind > 0b0 & value >= 0)
        {
            System.Console.WriteLine("Year: {0}, Weather: {1}, {2}: {3}", sourceYear, kind, message, value);
        }
        else if (sourceYear >= 0 & sourceMonth >= 0 & sourceDay == -1 
                    & floatValue == -1f & (byte)kind > 0b0 & value >= 0)
        {
            System.Console.WriteLine("Year: {0}, Month: {1}, Weather: {2}, {3}: {4}", sourceYear, 
                                        (MonthsName)sourceMonth + 1, kind, message, value);
        }
    }

    public static void PrintWeatherByDate(Weather[,][] sourceArray, int sourceYear = 0, int sourceMonth = -1, int sourceDay = -1)
    {
        if (sourceMonth == -1)
        {
            for (int month = 0; month < sourceArray.GetLength(1); month++)
            {
                MonthsName currentMonth = (MonthsName)(month + 1);
                System.Console.WriteLine(currentMonth);
                System.Console.WriteLine("------------------------------------------------------------------");

                for (int day = 0; day < sourceArray[sourceYear, month].Length; day++)
                {
                    // System.Console.Write("| {0, 2}: {1, 6} ", day + 1, 
                    //                     TransferEnumWeatherToIcon(sourceArray[sourceYear, month][day]));

                    byte test = (byte)Weather.Sun;
                    char icon1 = '0';
                    char icon2 = '0';

                    for (int i = 0; i < Enum.GetNames(typeof(Weather)).Length - 1; i++)
                    {
                        if (sourceArray[sourceYear, month][day].HasFlag((Weather)test))
                        {
                            Weather difference = sourceArray[sourceYear, month][day];
                            difference ^= (Weather)test;
                            icon1 = TransferEnumWeatherToIcon(difference);
                            icon2 = TransferEnumWeatherToIcon((Weather)test);
                        }

                        test = (byte)(test << 1);
                    }

                    System.Console.Write("| {0, 2}: {1, 5} {2}", day + 1, icon1, icon2);
    
                    if ((day + 1) % 5 == 0 | day == sourceArray[sourceYear, month].Length - 1)
                    {
                        System.Console.Write("|");
                        System.Console.WriteLine();
                        System.Console.WriteLine("------------------------------------------------------------------");
                    }
                }

                System.Console.WriteLine();
                System.Console.WriteLine();
            }
        }
        else if (sourceDay == -1)
        {
            MonthsName currentMonth = (MonthsName)(sourceMonth + 1);
            System.Console.WriteLine(currentMonth);
            System.Console.WriteLine("------------------------------------------------------------------");

            for (int day = 0; day < sourceArray[sourceYear, sourceMonth].Length; day++)
            {
                // System.Console.Write("| {0, 2}: {1, 6} ", day + 1, 
                //                     TransferEnumWeatherToIcon(sourceArray[sourceYear, sourceMonth][day]));

                byte test = (byte)Weather.Sun;
                char icon1 = '0';
                char icon2 = '0';

                for (int i = 0; i < Enum.GetNames(typeof(Weather)).Length - 1; i++)
                {
                    if (sourceArray[sourceYear, sourceMonth][day].HasFlag((Weather)test))
                    {
                        Weather difference = sourceArray[sourceYear, sourceMonth][day];
                        difference ^= (Weather)test;
                        icon1 = TransferEnumWeatherToIcon(difference);
                        icon2 = TransferEnumWeatherToIcon((Weather)test);
                    }

                    test = (byte)(test << 1);
                }
                System.Console.Write("| {0, 2}: {1, 5} {2}", day + 1, icon1, icon2);
                

                if ((day + 1) % 5 == 0 | day == sourceArray[sourceYear, sourceMonth].Length - 1)
                {
                    System.Console.Write("|");
                    System.Console.WriteLine();
                    System.Console.WriteLine("------------------------------------------------------------------");
                }
            }
        }
        else
        {
            System.Console.WriteLine(sourceArray[sourceYear, sourceMonth][sourceDay]);

            byte test = (byte)Weather.Sun;
            char icon1 = '0';
            char icon2 = '0';

            for (int i = 0; i < Enum.GetNames(typeof(Weather)).Length - 1; i++)
            {
                if (sourceArray[sourceYear, sourceMonth][sourceDay].HasFlag((Weather)test))
                {
                    Weather difference = sourceArray[sourceYear, sourceMonth][sourceDay];
                    difference ^= (Weather)test;
                    icon1 = TransferEnumWeatherToIcon(difference);
                    icon2 = TransferEnumWeatherToIcon((Weather)test);
                }

                test = (byte)(test << 1);
            }
            System.Console.Write("Year: {0}, Month: {1}, Day: {2}: {3} {4}", sourceYear, 
                                    (MonthsName)sourceMonth + 1, sourceDay, icon1, icon2);
                
        }
    }

    public static char TransferEnumWeatherToIcon(Weather kind = Weather.None)
    {
        if (kind.HasFlag(Weather.Sun))
        {
            char sun = '\u2600';    // ☀ 
            return sun;
        }
        else if (kind.HasFlag(Weather.Cloudy))
        {
            char cloudy = '\u2601';    // ☁ 
            return cloudy;
        }
        else if (kind.HasFlag(Weather.Rainy))
        {
            char rainy = '\u26C6';    // ⛆
            return rainy;
        }
        else if (kind.HasFlag(Weather.Windy))
        {
            char windy = '\u2604';    // ☄
            return windy;
        }
        else if (kind.HasFlag(Weather.Fog))
        {
            char fog = '\u26C8';    // ⛈
            return fog;
        }
        else if (kind.HasFlag(Weather.Snow))
        {
            char snow = '\u2603';   // ☃ 
            return snow;
        }

        return '0';
    }
}
