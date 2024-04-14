using System.Formats.Asn1;

internal class Program
{
    private static void Main(string[] args)
    {
        int a = 5;
        int b = 9;
        int result1 = GetSum(a, b);
        System.Console.WriteLine(result1);

        int result2 = GetSumRec(a, b);
        System.Console.WriteLine(result2);

        int result3 = GetSumRec1(a, b);
        System.Console.WriteLine(result3);

        int resultF1 = GetFactorial(a);
        System.Console.WriteLine(resultF1);

        int resultF2 = GetFactorialRec(a, 1);
        System.Console.WriteLine(resultF2);

        int resultF3 = GetFactorialRec(a, 0);
        System.Console.WriteLine(resultF3);
    }

    public static int GetSum(int low, int high)
    {
        int sum = 0;

        for (int i = high; i >= low; i--)
        {
            sum += i;
        }

        return sum;
    }

    public static int GetSumRec(int low, int high)
    {
        if (low == high)
        {
            return low;
        }

        int sum = GetSumRec(low + 1, high);

        return sum + low;
    }

    public static int GetSumRec1(int low, int high)
    {
        if (low == high)
        {
            return low;
        }

        int sum = GetSumRec1(low, high - 1);

        return sum + high;
    }

    public static int GetFactorial(int n)
    {
        int result = 1;
        for (int i = 1; i <= n; i++)
        {
            result *= i;
        }

        return result;
    }

    public static int GetFactorialRec(int n, int i = 1)
    {
        if (n == 0) //trival 
        {
            return 1;
        }

        if (i == n) //trival
        {
            return i;
        }
        
        return i * GetFactorialRec(n, i + 1);
    }
}