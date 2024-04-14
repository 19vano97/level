internal class Program
{
    private static void Main(string[] args)
    {
        int a = GetNumbers("a");
        int b = GetNumbers("b");

        SwapNumbersSum(a, b);
        SwapNumbersMul(a, b);
        SwapNumbersRoundBrackets(a, b);
        SwapNumbersExtraVar(a, b);
        SwapNumbersXOR(a, b);
    }

    // public static int GetNumbers(string message)
    // {
    //     System.Console.Write("Enter {0} = ", message);
    //     int variable = int.Parse(Console.ReadLine()); 

    //     return variable;      
    // }

    public static int GetNumbers(string message)
    {
        int result;
        
        ConsoleKey key;
        key = Console.ReadKey().Key;

        do
        {
            
            System.Console.WriteLine(message);
        } while (!int.TryParse(Console.ReadLine(), out result) | key != ConsoleKey.Escape);

        return result;     
    }

    public static void SwapNumbersSum(int firstPar, int secondPar)
    {
        int res = firstPar + secondPar;
        firstPar = res - firstPar;
        secondPar = res - secondPar;
        System.Console.WriteLine("Scenario - Sum: a = {0}, b = {1}", firstPar, secondPar);
    }

    public static void SwapNumbersMul(int firstPar, int secondPar)
    {
        int res = firstPar * secondPar;
        firstPar = res / firstPar;
        secondPar = res / secondPar;
        System.Console.WriteLine("Scenario - Mul: a = {0}, b = {1}", firstPar, secondPar);
    }

    public static void SwapNumbersRoundBrackets(int firstPar, int secondPar)
    {
        (firstPar, secondPar) = (secondPar, firstPar);
        System.Console.WriteLine("Scenario - RoundBrackets: a = {0}, b = {1}", firstPar, secondPar);
    }

    public static void SwapNumbersExtraVar(int firstPar, int secondPar)
    {
        int temp = firstPar;
        firstPar = secondPar;
        secondPar = temp;
        System.Console.WriteLine("Scenario - ExtraVar: a = {0}, b = {1}", firstPar, secondPar);
    }

    public static void SwapNumbersXOR(int firstPar, int secondPar)
    {
        firstPar ^= secondPar;
        secondPar ^= firstPar;
        firstPar ^= secondPar;
        System.Console.WriteLine("Scenario - XOR: a = {0}, b = {1}", firstPar, secondPar);
    }
}