using System.Dynamic;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello$$$$, World!$$$$");
        Console.WriteLine("Hello$$$$, World!$$$$");
        Console.WriteLine("Hello$$$$, World!$$$$");
        Console.WriteLine("Hello$$$$, World!$$$$");
        Console.WriteLine("Hello$$$$, World!$$$$");

        Console.ForegroundColor = ConsoleColor.DarkBlue;

        ShowMessage("Ivan");
        ShowMessage("Ivan");
        ShowMessage("Ivan");
        ShowMessage("Ivan");
        ShowMessage("Ivan");

        int a = 23;
        int b = 55;
        int result = CalculateSum(a, b);

        int result2 = 100;

        CalculateSum1(a, b, result);

        CalculateSum2(a, b, out result2);

        int result3 = -100;

        CalculateSum3(a, b, ref result3);
    }

    private static void ShowMessage(string message)
    {
        Console.WriteLine($"$$$$Hello, {message}!$$$$");
    }

    public static int CalculateSum(int first, int second)
    {
        int result = first +second;
        first += 10;
        second += 10;

        System.Console.WriteLine("result: {0}", result);

        //CalculateSum1(first, second, result);
        return result;
    }

    public static void CalculateSum1(int first, int second, int result)
    {
        System.Console.WriteLine("Cal result: {0}", result);
    }

    public static void CalculateSum2(int first, int second, out int result)
    {
        result = first +second;
        first += 10;
        second += 10;
        System.Console.WriteLine("cal 2, a= {0}, b= {1}, result= {2}", first, second, result);
    }

    public static void CalculateSum3(int first, int second, ref int result)
    {
        int resultCopy = result; // get inital param from reslt

        result = first +second;
        first += 10;
        second += 10;
        System.Console.WriteLine("cal 3, a= {0}, b= {1}, result= {2}", first, second, result);
    }

} 