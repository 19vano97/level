// See https://aka.ms/new-console-template for more information
using _20240403_HW8;

#region trafficLighter

// internal class Program
// {
//     private static void Main(string[] args)
//     {
//         ColorTrafficLighter light = ColorTrafficLighter.Red;
//         int RedMilisec = 3000;
//         int delay = 500;
//         int YellowMilisec = 1500;
//         int GreenMilisec = 3000;
//         string red1 = "****";
//         string yellow1 = "****";
//         string green1 = "****";

//         ConsoleKey key;
//         do
//         {
//             key = Console.ReadKey().Key;

//             if (light >= 0)
//             {

//                 switch (light)
//                 {
//                     case ColorTrafficLighter.Red:
//                         Console.Clear();
//                         Console.ForegroundColor = ConsoleColor.Red;
//                         Console.WriteLine(red1);
//                         Console.WriteLine(red1);
//                         Console.WriteLine(red1);
//                         Thread.Sleep(RedMilisec);
//                         for (int i = 0; i < 5; i++)
//                         {
//                             Console.Clear();
//                             Console.ForegroundColor = ConsoleColor.Red;
//                             Console.WriteLine(red1);
//                             Console.WriteLine(red1);
//                             Console.WriteLine(red1);
//                             Thread.Sleep(delay);
//                             Console.Clear();
//                             Console.ForegroundColor = ConsoleColor.Black;
//                             Console.WriteLine(red1);
//                             Console.WriteLine(red1);
//                             Console.WriteLine(red1);
//                             Thread.Sleep(delay);
//                         }
//                         light = ColorTrafficLighter.Yellow;
//                         break;
//                     case ColorTrafficLighter.Yellow:
//                         Console.Clear();
//                         Console.ForegroundColor = ConsoleColor.Yellow;
//                         Console.WriteLine(yellow1);
//                         Console.WriteLine(yellow1);
//                         Console.WriteLine(yellow1);
//                         Thread.Sleep(YellowMilisec);
//                         light = ColorTrafficLighter.Green;
//                         break;
//                     case ColorTrafficLighter.Green:
//                         Console.Clear();
//                         Console.ForegroundColor = ConsoleColor.Green;
//                         Console.WriteLine(green1);
//                         Console.WriteLine(green1);
//                         Console.WriteLine(green1);
//                         Thread.Sleep(GreenMilisec);
//                         for (int i = 0; i < 5; i++)
//                         {
//                             Console.Clear();
//                             Console.ForegroundColor = ConsoleColor.Green;
//                             Console.WriteLine("****");
//                             Console.WriteLine("****");
//                             Console.WriteLine("****");
//                             Thread.Sleep(delay);
//                             Console.Clear();
//                             Console.ForegroundColor = ConsoleColor.Black;
//                             Console.WriteLine("****");
//                             Console.WriteLine("****");
//                             Console.WriteLine("****");
//                             Thread.Sleep(delay);
//                         }
//                         light = ColorTrafficLighter.Red;
//                         break;

//                     default:
//                         break;
//                 }
//             }
//             else
//             {
//                 Console.WriteLine("Wrong");
//             }

//         } while (key != ConsoleKey.Escape);
//     }
// }

#endregion

#region trafficLighterWithFunction
    internal class Program
    {
        private static void Main(string[] args)
        {
            ColorTrafficLighter light = ColorTrafficLighter.Red;
            int RedMilisec = 3000;
            int YellowMilisec = 1500;
            int GreenMilisec = 3000;
            int delay = 500;
            string form = "****";
    
            ConsoleKey key;
            do
            {
                key = Console.ReadKey().Key;
    
                if (light >= 0)
                {
    
                    switch (light)
                    {
                        case ColorTrafficLighter.Red:
                            LightColor(RedMilisec, form, light);
                            BlinkTrafficLighter(delay, form, light);
                            light = ColorTrafficLighter.Yellow;
                            break;
                        case ColorTrafficLighter.Yellow:
                            LightColor(YellowMilisec, form, light);
                            light = ColorTrafficLighter.Green;
                            break;
                        case ColorTrafficLighter.Green:
                            LightColor(GreenMilisec, form, light);
                            BlinkTrafficLighter(delay, form, light);
                            light = ColorTrafficLighter.Red;
                            break;
    
                        default:
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Wrong");
                }
    
            } while (key != ConsoleKey.Escape);
        }

    private static void LightColor(int lightCurrent, string form, ColorTrafficLighter light)
    {
        Console.Clear();
        DefineColorForConsole(light);
        Console.WriteLine(form);
        Console.WriteLine(form);
        Console.WriteLine(form);
        Thread.Sleep(lightCurrent);
    }

    private static void BlinkTrafficLighter(int delay, string form, ColorTrafficLighter light)
    {
        for (int i = 0; i < 5; i++)
        {
            Console.Clear();
            DefineColorForConsole(light);
            Console.WriteLine(form);
            Console.WriteLine(form);
            Console.WriteLine(form);
            Thread.Sleep(delay);
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine(form);
            Console.WriteLine(form);
            Console.WriteLine(form);
            Thread.Sleep(delay);
        }
    }

    private static void DefineColorForConsole(ColorTrafficLighter light)
    {
        if (light.HasFlag(ColorTrafficLighter.Red))
        {
            Console.ForegroundColor = ConsoleColor.Red;
        }

        if (light.HasFlag(ColorTrafficLighter.Yellow))
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
        }

        if (light.HasFlag(ColorTrafficLighter.Green))
        {
            Console.ForegroundColor = ConsoleColor.Green;
        }
    }
}
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