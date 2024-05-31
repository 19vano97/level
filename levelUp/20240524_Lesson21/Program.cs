internal class Program
{
    private static void Main(string[] args)
    {
        
        int m1 = GetMin(new int[] {});
        int m2 = GetMin(new int[] {55, 05});
        int m3 = GetMin(new int[] {234, 324, 324, 12, 05});
    
        int m4 = GetMin(new int[] {});
        int m5 = GetMin(55, 05);
        int m6 = GetMin(234, 324, 324, 12, 05);

    }

    public static int GetMin(int a, int b)
    {
        int result = a;
        
        if (b < result)
        {
            result = b;
        }

        return result;
        }


    public static int GetMin(params int[] arguments)
    {
        int min = arguments[0];

        for (int i = 0; i < arguments.Length; i++)
        {
            if (arguments[i] < min)
            {
                min = arguments[i];
            }
        }

        return  min;
    }
}