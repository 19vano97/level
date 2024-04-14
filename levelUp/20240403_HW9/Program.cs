// See https://aka.ms/new-console-template for more information

using System.ComponentModel;
using _20240403_HW9;

#region withoutFuction
    // internal class Program
    // {
    //     private static void Main(string[] args)
    //     {
    //         DayWeek day = DayWeek.None;
    
    //         byte result = 0;
    
    //         Console.Clear();
    
    //         Console.WriteLine("Menu");
    //         Console.WriteLine("<M>. Monday");
    //         Console.WriteLine("<T>. Tuesday");
    //         Console.WriteLine("<W>. Wednesday");
    //         Console.WriteLine("<H>. Thursday");
    //         Console.WriteLine("<F>. Friday");
    //         Console.WriteLine("<S>. Saturday");
    //         Console.WriteLine("<U>. Sunday");
    //         Console.WriteLine("<R>. Reset");
    //         Console.WriteLine("<D>. Exit (<Esc>)");
    //         Console.WriteLine("Your choice: ");
    
    //         ConsoleKey userChoice;
    
    //         do
    //         {
    //             Console.SetCursorPosition(13, 10);
    
    //             userChoice = Console.ReadKey().Key;
    //             Console.WriteLine();
    
    //             switch (userChoice)
    //             {
    //                 case ConsoleKey.M:
    //                     day = DayWeek.Monday;
    //                     break;
    //                 case ConsoleKey.T:
    //                     day = DayWeek.Tuesday;
    //                     break;
    //                 case ConsoleKey.W:
    //                     day = DayWeek.Wednesday;
    //                     break;
    //                 case ConsoleKey.H:
    //                     day = DayWeek.Thursday;
    //                     break;
    //                 case ConsoleKey.F:
    //                     day = DayWeek.Friday;
    //                     break;
    //                 case ConsoleKey.S:
    //                     day = DayWeek.Saturday;
    //                     break;
    //                 case ConsoleKey.U:
    //                     day = DayWeek.Sunday;
    //                     break;
    //                 case ConsoleKey.R:
    //                     day = DayWeek.None;
    //                     break;
    //                 case ConsoleKey.D:
    //                     case ConsoleKey.Escape:
    //                         Console.WriteLine("Pause");
    //                     break;
    //                 default:
    //                     Console.SetCursorPosition(13, 20);
    //                     Console.WriteLine("Wrong");
    //                     break;
    //             }
    
    //             if (day.HasFlag(DayWeek.Monday))
    //             {
    //                 result ^= (byte)DayWeek.Monday;
    //             }
    //             else if (day.HasFlag(DayWeek.Tuesday))
    //             {
    //                 result ^= (byte)DayWeek.Tuesday;
    //             }
    //             else if (day.HasFlag(DayWeek.Wednesday))
    //             {
    //                 result ^= (byte)DayWeek.Wednesday;
    //             }
    //             else if (day.HasFlag(DayWeek.Thursday))
    //             {
    //                 result ^= (byte)DayWeek.Thursday;
    //             }
    //             else if (day.HasFlag(DayWeek.Friday))
    //             {
    //                 result ^= (byte)DayWeek.Friday;
    //             }
    //             else if (day.HasFlag(DayWeek.Saturday))
    //             {
    //                 result ^= (byte)DayWeek.Saturday;
    //             }
    //             else if (day.HasFlag(DayWeek.Sunday))
    //             {
    //                 result ^= (byte)DayWeek.Sunday;
    //             }
    //             else if (day.HasFlag(DayWeek.None))
    //             {
    //                 result = (byte)DayWeek.None;
    //             }
                
    //             Console.WriteLine("Result: {0, 8}, {1, 2}", result.ToString("B8"), result);
    
    //         } while (userChoice != ConsoleKey.Escape && userChoice != ConsoleKey.D);
    //     }
    // }
#endregion

#region withFunction
    internal class Program
    {
        private static void Main(string[] args)
        {
            DayWeek day = DayWeek.None;
    
            byte result = 0;
    
            Console.Clear();
    
            Console.WriteLine("Menu");
            Console.WriteLine("<M>. Monday");
            Console.WriteLine("<T>. Tuesday");
            Console.WriteLine("<W>. Wednesday");
            Console.WriteLine("<H>. Thursday");
            Console.WriteLine("<F>. Friday");
            Console.WriteLine("<S>. Saturday");
            Console.WriteLine("<U>. Sunday");
            Console.WriteLine("<R>. Reset");
            Console.WriteLine("<D>. Exit (<Esc>)");
            Console.WriteLine("Your choice: ");
    
            ConsoleKey userChoice;
    
            do
            {
                Console.SetCursorPosition(13, 10);
    
                userChoice = Console.ReadKey().Key;
                Console.WriteLine();
    
                switch (userChoice)
                {
                    case ConsoleKey.M:
                        SumDayWeek(DayWeek.Monday, ref result);
                        break;
                    case ConsoleKey.T:
                        SumDayWeek(DayWeek.Tuesday, ref result);
                        break;
                    case ConsoleKey.W:
                        SumDayWeek(DayWeek.Wednesday, ref result);
                        break;
                    case ConsoleKey.H:
                        SumDayWeek(DayWeek.Thursday, ref result);
                        break;
                    case ConsoleKey.F:
                        SumDayWeek(DayWeek.Friday, ref result);
                        break;
                    case ConsoleKey.S:
                        SumDayWeek(DayWeek.Saturday, ref result);
                        break;
                    case ConsoleKey.U:
                        SumDayWeek(DayWeek.Sunday, ref result);
                        break;
                    case ConsoleKey.R:
                        ResetDayWeek(DayWeek.None, ref result);
                        break;
                    case ConsoleKey.D:
                        case ConsoleKey.Escape:
                            Console.WriteLine("Pause");
                        break;
                    default:
                        Console.SetCursorPosition(13, 20);
                        Console.WriteLine("Wrong");
                        break;
                }
                
                Console.WriteLine("Result: {0, 8}, {1, 2}", result.ToString("B8"), result);
    
            } while (userChoice != ConsoleKey.Escape && userChoice != ConsoleKey.D);
        }

        public static byte SumDayWeek(DayWeek day, ref byte result)
        {
            if (day.HasFlag(day))
            {
                result ^= (byte)day;
            }

            return result;
        }

        public static byte ResetDayWeek(DayWeek day, ref byte result)
        {
            if (day.HasFlag(DayWeek.None))
            {
                result = (byte)DayWeek.None;
            }

            return result;
        }

    }
#endregion