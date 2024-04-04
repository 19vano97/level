// See https://aka.ms/new-console-template for more information

using System.ComponentModel;
using _20240403_HW9;

Console.Clear();

DayWeek day = DayWeek.None;

byte a = 0;

#region TestVar
// do
// {
//    System.Console.WriteLine("Provide a number of a day week: ");

//    if (Enum.TryParse(Console.ReadLine(), out day))
//    {
//        switch (day)
//        {
//            case DayWeek.Monday:
//                System.Console.WriteLine("Day: {0}, Number: {1}", day, (int)day);
//                day = DayWeek.Monday;
//                break;
//            case DayWeek.Tuesday:
//                System.Console.WriteLine("Day: {0}, Number: {1}", day, (int)day);
//                day = DayWeek.Tuesday;
//                break;
//            case DayWeek.Wednesday:
//                System.Console.WriteLine("Day: {0}, Number: {1}", day, (int)day);
//                day = DayWeek.Wednesday;
//                break;
//            case DayWeek.Thursday:
//                System.Console.WriteLine("Day: {0}, Number: {1}", day, (int)day);
//                day = DayWeek.Thursday;
//                break;
//            case DayWeek.Friday:
//                System.Console.WriteLine("Day: {0}, Number: {1}", day, (int)day);
//                day = DayWeek.Friday;
//                break;
//            case DayWeek.Saturday:
//                System.Console.WriteLine("Day: {0}, Number: {1}", day, (int)day);
//                day = DayWeek.Saturday;
//                break;
//            case DayWeek.Sunday:
//                System.Console.WriteLine("Day: {0}, Number: {1}", day, (int)day);
//                day = DayWeek.Sunday;
//                break;
//            default:
//                break;
//        }
//        if (day.HasFlag(DayWeek.Monday))
//        {
//            a |= (byte)DayWeek.Monday;
//        }
//        else if (day.HasFlag(DayWeek.Tuesday))
//        {
//            a |= (byte)DayWeek.Tuesday;
//        }
//        else if (day.HasFlag(DayWeek.Wednesday))
//        {
//            a |= (byte)DayWeek.Wednesday;
//        }
//        else if (day.HasFlag(DayWeek.Thursday))
//        {
//            a |= (byte)DayWeek.Thursday;
//        }
//        else if (day.HasFlag(DayWeek.Friday))
//        {
//            a |= (byte)DayWeek.Friday;
//        }
//        else if (day.HasFlag(DayWeek.Saturday))
//        {
//            a |= (byte)DayWeek.Saturday;
//        }
//        else if (day.HasFlag(DayWeek.Sunday))
//        {
//            a |= (byte)DayWeek.Sunday;
//        }
//        System.Console.WriteLine("Result: {0, 8}, {1, 2}", a.ToString("B8"), a);

//    }
//    else
//    {
//        System.Console.WriteLine("Wrong");
//        break;
//    }

// } while (true);
#endregion

Console.WriteLine("Menu");
Console.WriteLine("<M>. Monday");
Console.WriteLine("<T>. Tuesday");
Console.WriteLine("<W>. Wednesday");
Console.WriteLine("<H>. Thursday");
Console.WriteLine("<F>. Friday");
Console.WriteLine("<S>. Saturday");
Console.WriteLine("<U>. Sunday");
Console.WriteLine("<D>. Exit (<Esc>)");
System.Console.WriteLine("Your choice: ");

ConsoleKey userChoice;

do
{
    Console.SetCursorPosition(13, 9);

    userChoice = Console.ReadKey().Key;
    System.Console.WriteLine();

    switch (userChoice)
    {
        case ConsoleKey.M:
            day = DayWeek.Monday;
            break;
        case ConsoleKey.T:
            day = DayWeek.Tuesday;
            break;
        case ConsoleKey.W:
            day = DayWeek.Wednesday;
            break;
        case ConsoleKey.H:
            day = DayWeek.Thursday;
            break;
        case ConsoleKey.F:
            day = DayWeek.Friday;
            break;
        case ConsoleKey.S:
            day = DayWeek.Saturday;
            break;
        case ConsoleKey.U:
            day = DayWeek.Sunday;
            break;
        case ConsoleKey.D:
        case ConsoleKey.Escape:
            System.Console.WriteLine("Pause");
            break;
        default:
            Console.WriteLine("Wrong");
            break;
    }
    if (day.HasFlag(DayWeek.Monday))
    {
        a |= (byte)DayWeek.Monday;
    }
    else if (day.HasFlag(DayWeek.Tuesday))
    {
        a |= (byte)DayWeek.Tuesday;
    }
    else if (day.HasFlag(DayWeek.Wednesday))
    {
        a |= (byte)DayWeek.Wednesday;
    }
    else if (day.HasFlag(DayWeek.Thursday))
    {
        a |= (byte)DayWeek.Thursday;
    }
    else if (day.HasFlag(DayWeek.Friday))
    {
        a |= (byte)DayWeek.Friday;
    }
    else if (day.HasFlag(DayWeek.Saturday))
    {
        a |= (byte)DayWeek.Saturday;
    }
    else if (day.HasFlag(DayWeek.Sunday))
    {
        a |= (byte)DayWeek.Sunday;
    }
    System.Console.WriteLine("Result: {0, 8}, {1, 2}", a.ToString("B8"), a);


} while (userChoice != ConsoleKey.Escape && userChoice != ConsoleKey.D);
