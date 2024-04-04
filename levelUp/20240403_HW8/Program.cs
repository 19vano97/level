// See https://aka.ms/new-console-template for more information
using _20240403_HW8;





#region trafficLighter
    ColorTrafficLighter light = ColorTrafficLighter.Red;
    int RedMilisec = 3000;
    int delay = 500;
    int YellowMilisec = 1500;
    int GreenMilisec = 3000;
    string red1 = "****";
    string yellow1 = "****";
    string green1 = "****";

    ConsoleKey key;
    do
    {
        key = Console.ReadKey().Key;
        
        if (light >= 0)
        {

            switch (light)
            {
                case ColorTrafficLighter.Red:
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    System.Console.WriteLine(red1);
                    System.Console.WriteLine(red1);
                    System.Console.WriteLine(red1);
                    Thread.Sleep(RedMilisec);
                    for (int i = 0; i < 5; i++)
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        System.Console.WriteLine(red1);
                        System.Console.WriteLine(red1);
                        System.Console.WriteLine(red1);
                        Thread.Sleep(delay);
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Black;
                        System.Console.WriteLine(red1);
                        System.Console.WriteLine(red1);
                        System.Console.WriteLine(red1);
                        Thread.Sleep(delay);
                    }
                    light = ColorTrafficLighter.Yellow;
                    break;
                case ColorTrafficLighter.Yellow:
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    System.Console.WriteLine(yellow1);
                    System.Console.WriteLine(yellow1);
                    System.Console.WriteLine(yellow1);
                    Thread.Sleep(YellowMilisec);
                    light = ColorTrafficLighter.Green;
                    break;
                case ColorTrafficLighter.Green:
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Green;
                    System.Console.WriteLine(green1);
                    System.Console.WriteLine(green1);
                    System.Console.WriteLine(green1);
                    Thread.Sleep(GreenMilisec);
                    for (int i = 0; i < 5; i++)
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Green;
                        System.Console.WriteLine("****");
                        System.Console.WriteLine("****");
                        System.Console.WriteLine("****");
                        Thread.Sleep(delay);
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Black;
                        System.Console.WriteLine("****");
                        System.Console.WriteLine("****");
                        System.Console.WriteLine("****");
                        Thread.Sleep(delay);
                    }
                    light = ColorTrafficLighter.Red;
                    break;
                
                default:
                    break;
            }
        }
        else
        {
            System.Console.WriteLine("Wrong");
        }
        
    } while (key != ConsoleKey.Escape);
    
#endregion



#region dayWeek
    // DayWeek day = 0;

    // if (Enum.TryParse(Console.ReadLine(), out day))
    // {
    //     switch (day)
    //     {
    //         case DayWeek.Monday:
    //             System.Console.WriteLine("Day: {0}, Number: {1}", day, (int)day);
    //             break;
    //         case DayWeek.Tuesday:
    //             System.Console.WriteLine("Day: {0}, Number: {1}", day, (int)day);
    //             break;
    //         case DayWeek.Wednesday:
    //             System.Console.WriteLine("Day: {0}, Number: {1}", day, (int)day);
    //             break;
    //         case DayWeek.Thursday:
    //             System.Console.WriteLine("Day: {0}, Number: {1}", day, (int)day);
    //             break;
    //         case DayWeek.Friday:
    //             System.Console.WriteLine("Day: {0}, Number: {1}", day, (int)day);
    //             break;
    //         case DayWeek.Saturday:
    //             System.Console.WriteLine("Day: {0}, Number: {1}", day, (int)day);
    //             break;
    //         case DayWeek.Sunday:
    //             System.Console.WriteLine("Day: {0}, Number: {1}", day, (int)day);
    //             break;
    //         default:
    //             break;
    //     }
    // }
    // else
    // {
    //     System.Console.WriteLine("Wrong");
    // }

#endregion