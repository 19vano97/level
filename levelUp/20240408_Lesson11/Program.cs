using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Contracts;

internal class Program
{
    private static void Main(string[] args)
    {
        #region ConsoleAPP
            Console.Clear();
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
    
            bool flagArg = false;
    
            firstArg = InputIntNumber1("A");

            // do
            // {
    
            //     Console.SetCursorPosition(13,10);
    
            //     userChoice = Console.ReadKey().Key;
            //     System.Console.WriteLine();
    
            //     switch (userChoice)
            //     {
            //         case ConsoleKey.A:
            //             firstArg = InputIntNumber1("A");
            //             //System.Console.Write("secondArg  ");
            //             secondArg = InputIntNumber1("B");
            //             break;
            //         case ConsoleKey.B:
            //             bool a =  SumNumbers(firstArg, secondArg, out result);
            //             if (a)
            //             {
            //                 ShowErrorMessage("good");
            //             }
            //             else
            //             {
            //                 ShowErrorMessage("wrong");
            //             }
            //             break;
            //         case ConsoleKey.C:
            //             //System.Console.WriteLine("{0} + {1} = {2}", firstArg, secondArg, result);
            //             string resultInfo = string.Format("{0} + {1} = {2}", firstArg, secondArg, result);
            //             ShowErrorMessage(resultInfo);
            //             break;
            //         case ConsoleKey.D:
            //             case ConsoleKey.Escape:
            //                 ShowErrorMessage("Pause");
            //                 System.Console.ReadKey();
            //                 System.Threading.Thread.Sleep(2000);
            //             break;
            //         default:
            //             ShowErrorMessage("Wrong");
            //             break;
            //     }
    
            // } while (userChoice != ConsoleKey.Escape && userChoice != ConsoleKey.D);
        #endregion
    
        // int a = 10;
        // int b = 20;

        // int min1 = GetMin(a, b, 3);

        // float d = 20.5f;
        // float e = 44.8f;

        // // float min2 = GetMin(d, e);

        // int s1 = GetSum(2, 3);
        // int s2 = GetSum(4, 5, 6);
        // int s3 = GetSum(7, 8, 9);
        // int s4 = GetSum(d: 12, b: 1, a: 3);
        // int s5 = GetSum(1, 2, d: 5);

        // System.Console.WriteLine(s1);
        // System.Console.WriteLine(s2);
        // System.Console.WriteLine(s3);
        // System.Console.WriteLine(s4);
        // System.Console.WriteLine(s5);
    }

    private static bool SumNumbers(int firstArg, int secondArg, out int result)
    {
        bool a = false;
        
        result = 0;

        try
        {
            checked //overload if int.maxvalue
            {
                result = firstArg + secondArg;
                a = true;
            }
        }
        catch (System.Exception)
        {
        }

        return a;
    }

    private static int InputIntNumber(string message) 
    {
        System.Console.Write("Enter number {0}  ", message);
        int result = int.Parse(Console.ReadLine());
        return result;
    }

    private static int InputIntNumber1(string message) //To Do add escape from function
    {
        int result;
        
        ConsoleKey key;

        
            do
            {
                System.Console.Write("Enter number {0}  ", message);
                key = Console.ReadKey().Key;
    
                if (key == ConsoleKey.Escape)
                {
                    result = int.MinValue;
                    break;
                }
                 
                //result = int.Parse(Console.ReadLine());
                //System.Console.WriteLine(result);

                // if (int.TryParse(Console.ReadLine(), out result))
                // {
                //     System.Console.WriteLine(result);

                //     if (key == ConsoleKey.Escape)
                //     {
                //         break;
                //     }
                // }
                    
            } while (!int.TryParse(Console.ReadLine(), out result));
            System.Console.WriteLine(result);
            
            
            //result = int.Parse(Console.ReadLine());

        return result;
    }

    public static void ShowErrorMessage(string message)
    {
        ConsoleColor oldColor = Console.ForegroundColor;
        int oldX = Console.CursorLeft;
        int oldY = Console.CursorTop;

        int left = (Console.WindowWidth - message.Length) / 2;
        Console.ForegroundColor = ConsoleColor.Red;
        Console.SetCursorPosition(20, Console.WindowHeight - 1);

        System.Console.Write(message);

        Console.ForegroundColor = oldColor;
        Console.SetCursorPosition(oldX, oldY);
    }

    public static int GetMin(int a, int b)
    {
        int min = a;

        if (b < a)
        {
            min = b;
        }

        return min;
    }

    // public static int GetMin(float a, float b)
    // {
    //     float min = a;

    //     if (b < a)
    //     {
    //         min = b;
    //     }

    //     return min;
    // }

    public static int GetMin(int a, int b, int c)
    {
        int min = GetMin(a, b);

        return GetMin(min, c);
    }

    public static void GetMin(int a, int b, out int min)
    {
        min = a;

        if (b < a)
        {
            min = b;
        }

    }

    public static int GetSum(int a, int b, int c = 0, int d = 0) //parms by default should listed by right to left!!!!
    {
        return a + b + c + d;

    }
}