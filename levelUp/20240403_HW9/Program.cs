// See https://aka.ms/new-console-template for more information

using System.ComponentModel;
using _20240403_HW9;

DayWeek day = DayWeek.None;
DayWeek switcher = DayWeek.None;

// if (day.HasFlag(DayWeek.Monday))
// {
//     System.Console.WriteLine("true");
// }
// else
// {
//     System.Console.WriteLine(false);
// }

do
{
    System.Console.WriteLine("Provide a number of a day week: ");

    if (Enum.TryParse(Console.ReadLine(), out day))
    {
        switch (day)
        {
            case DayWeek.Monday:
                System.Console.WriteLine("Day: {0}, Number: {1}", day, (int)day);
                day = DayWeek.Monday;
                switcher = DayWeek.Result;
                break;
            case DayWeek.Tuesday:
                System.Console.WriteLine("Day: {0}, Number: {1}", day, (int)day);
                day = DayWeek.Tuesday;
                break;
            case DayWeek.Wednesday:
                System.Console.WriteLine("Day: {0}, Number: {1}", day, (int)day);
                day = DayWeek.Wednesday;
                break;
            case DayWeek.Thursday:
                System.Console.WriteLine("Day: {0}, Number: {1}", day, (int)day);
                day = DayWeek.Thursday;
                break;
            case DayWeek.Friday:
                System.Console.WriteLine("Day: {0}, Number: {1}", day, (int)day);
                day = DayWeek.Friday;
                break;
            case DayWeek.Saturday:
                System.Console.WriteLine("Day: {0}, Number: {1}", day, (int)day);
                day = DayWeek.Saturday;
                break;
            case DayWeek.Sunday:
                System.Console.WriteLine("Day: {0}, Number: {1}", day, (int)day);
                day = DayWeek.Sunday;
                break;
            case DayWeek.Result: 
                   
                break;
            default:
                break;
        }
        if (day.HasFlag(DayWeek.Monday))
                   {
                        day |= DayWeek.Monday;
                   }
                   else if (day.HasFlag(DayWeek.Tuesday))
                   {
                        day |= DayWeek.Tuesday;
                   }
                   else if (day.HasFlag(DayWeek.Wednesday))
                   {
                        day |= DayWeek.Wednesday;
                   }
                   else if (day.HasFlag(DayWeek.Thursday))
                   {
                        day |= DayWeek.Thursday;
                   }
                   else if (day.HasFlag(DayWeek.Friday))
                   {
                        day |= DayWeek.Friday;
                   }
                   else if (day.HasFlag(DayWeek.Saturday))
                   {
                        day |= DayWeek.Saturday;
                   }
                   else if (day.HasFlag(DayWeek.Sunday))
                   {
                        day |= DayWeek.Sunday;
                   }
                   else if (day.HasFlag(DayWeek.Monday))
                   {
                        day |= DayWeek.Monday;
                   }
                   System.Console.WriteLine("Result: {0}, {1, 2}", (byte)day, (int)day);
    }
    else
    {
        System.Console.WriteLine("Wrong");
    }

} while (true);


#region app
    // ConsoleKey userChoice;
    
    // Console.Clear();
    // Console.WriteLine("menu");
    // Console.WriteLine("<M>. Monday");
    // Console.WriteLine("<T>. Tuesday");
    // Console.WriteLine("<W>. Wednesday");
    // Console.WriteLine("<H>. Thursday");
    // Console.WriteLine("<F>. Friday");
    // Console.WriteLine("<S>. Saturday");
    // Console.WriteLine("<U>. Sunday");
    // Console.WriteLine("<R>. Result");
    // Console.WriteLine("<D>. Exit (<Esc>)");
    
    // System.Console.WriteLine("Your choice: ");
    // int firstArg = 0;
    // int result = 0;
    

    // Console.SetCursorPosition(20,10);
    // userChoice = Console.ReadKey().Key;
    // System.Console.WriteLine();
    // switch (userChoice)
    // {
    //     case ConsoleKey.M:
    //         day = DayWeek.Monday;
    //         break;
    //     case ConsoleKey.T:
    //         day = DayWeek.Tuesday;
    //         break;
    //     case ConsoleKey.W:
    //         day = DayWeek.Wednesday;
    //         break;
    //     case ConsoleKey.H:
    //         day = DayWeek.Thursday;
    //         break;
    //     case ConsoleKey.F:
    //         day = DayWeek.Friday;
    //         break;
    //     case ConsoleKey.S:
    //         day = DayWeek.Saturday;
    //         break;
    //     case ConsoleKey.U:
    //         day = DayWeek.Sunday;
    //         break;
    //     case ConsoleKey.R:
            
    //         break;
    //     // case ConsoleKey.D:
    //     //     case ConsoleKey.Escape:
    //     //     System.Console.WriteLine("Pause");
    //     //     break;
    //     default:
    //         Console.WriteLine("Wrong");
    //         break;
    // }

    
#endregion

