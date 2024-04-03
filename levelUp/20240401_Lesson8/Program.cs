using System;
using System.Diagnostics;
using _20240401_Lesson8;
//using _20240329_Lesson7;

//Console.WriteLine("Hello, World!");

// Direction d1 = Direction.Left | Direction.Bottom;

// System.Console.WriteLine($"d1: {d1}");

// for (Direction d = Direction.Left; d <= Direction.Bottom; d++)
// {
//     System.Console.WriteLine($"d: {d}, ({(int)d})");
// }

// Direction d2 = Direction.Left | Direction.Top;

// System.Console.WriteLine($"d2: {d2}");

// // if ((d2 & Direction.Left) > 0)
// // {
// //     System.Console.WriteLine("Direction left");
// // }
// // else
// // {
// //     System.Console.WriteLine("Error");
// // }

// if ((d2 & Direction.Right) > 0)
// {
//     System.Console.WriteLine("Direction right");
// }
// else
// {
//     System.Console.WriteLine("Error");
// }

// if (d2.HasFlag(Direction.Left))
// {
//     System.Console.WriteLine("Direction left");
// }
// else
// {
//     System.Console.WriteLine("Error");
// }

// //shit code
// switch (d2)
// {
//     case Direction.Empty:
//         System.Console.WriteLine("None");
//         break;
//     case Direction.Left:
//         break;
//     case Direction.Top:
//         break;
//     case Direction.Right:
//         break;
//     case Direction.Bottom:
//         break;
//     default:
//         System.Console.WriteLine("default");
//         break;
// }

internal class Program
{
    private static void Main(string[] args)
    {
        ConsoleKey userChoice;

        Console.WriteLine("menu");
        Console.WriteLine("<A>. Enter data");
        Console.WriteLine("<B>. Calculate");
        Console.WriteLine("<C>. Show results");
        Console.WriteLine("<D>. Exit (<Esc>)");
        System.Console.WriteLine("Your choice: ");

        int firstArg = 0;
        int secondArg = 0;
        int result = 0;

        do
        {


            Console.SetCursorPosition(13,10);

            userChoice = Console.ReadKey().Key;
            System.Console.WriteLine();

            switch (userChoice)
            {
                case ConsoleKey.A:
                    System.Console.Write("firstArg  ");
                    firstArg = int.Parse(Console.ReadLine());

                    System.Console.Write("secondArg  ");
                    secondArg = int.Parse(Console.ReadLine());
                    break;
                case ConsoleKey.B:
                    result = firstArg + secondArg;
                    break;
                case ConsoleKey.C:
                    System.Console.WriteLine("{0} + {1} = {2}", firstArg, secondArg, result);
                    break;
                case ConsoleKey.D:
                case ConsoleKey.Escape:
                System.Console.WriteLine("Pause");
                System.Console.ReadKey();
                System.Threading.Thread.Sleep(2000);
                    break;
                default:
                    Console.WriteLine("Wrong");
                    break;
            }

        } while (userChoice != ConsoleKey.Escape && userChoice != ConsoleKey.D);
    }
}