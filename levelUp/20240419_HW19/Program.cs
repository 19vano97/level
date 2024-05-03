internal class Program
{
    private static void Main(string[] args)
    {
        System.Console.WriteLine("Would like to enter data randomly(0) or manually (1)? ");
        bool randomOrManualInput = bool.Parse(Console.ReadLine());
        
        int[] arrayOfValues = InitializeIntArray(randomOrManualInput);

        int[] minValues = GetMinFromArray(arrayOfValues);

        int[] maxValues = GetMaxFromArray(arrayOfValues);

        PrintIntValuesFromArray(arrayOfValues, "OriginArray");
        
        PrintIntValuesFromArrayWithIndexFromOriginArray(minValues, arrayOfValues, "MinValue");

        PrintIntValuesFromArrayWithIndexFromOriginArray(maxValues, arrayOfValues, "MaxValue");
    }

    public static int InputValues(string message)
    {
        System.Console.Write("Enter {0}: ", message);
        int value = int.Parse(Console.ReadLine());

        return value;
    }

    public static int[] InitializeIntArray(bool randomOrManualInput = false)
    {
        int quantity = InputValues("quantity");

        int[] originArray = new int[quantity];

        if (randomOrManualInput == false)
        {
            for (int i = 0; i < originArray.Length; i++)
            {
                originArray[i] = GetRandomInt();
            }
        }
        else
        {
            for (int i = 0; i < originArray.Length; i++)
            {
                originArray[i] = InputValues(Convert.ToString(i));
            }
        }

        return originArray;
    }

    public static int[] GetMinFromArray(int[] originArray, int quantity = 0, int minFirst = int.MaxValue, int minSecond = int.MaxValue)
    {
        if (quantity == 0)
        {
            minFirst = originArray[quantity];
            minSecond = originArray[quantity];
        }

        if (minFirst > originArray[quantity])
        {
            minSecond = minFirst;
            minFirst = originArray[quantity];
        }
        else if (minSecond > originArray[quantity] & minFirst < originArray[quantity])
        {
            minSecond = originArray[quantity];
        }

        if (quantity == originArray.Length - 1)
        {
            return new [] {minFirst, minSecond};
        }
        
        int[] minValues = GetMinFromArray(originArray, quantity + 1, minFirst, minSecond);

        return minValues;
    }

    public static int[] GetMaxFromArray(int[] originArray, int quantity = 0, int maxFirst = int.MinValue, int maxSecond = int.MinValue)
    {
        if (quantity == 0)
        {
            maxFirst = originArray[quantity];
            maxSecond = originArray[quantity];
        }
        else if (maxFirst < originArray[quantity])
        {
            maxSecond = maxFirst;
            maxFirst = originArray[quantity];
        }
        else if (maxSecond < originArray[quantity])
        {
            maxSecond = originArray[quantity];
        }

        if (quantity == originArray.Length - 1)
        {
            return new [] {maxFirst, maxSecond};
        }
        
        int[] maxValues = GetMaxFromArray(originArray, quantity + 1, maxFirst, maxSecond);

        return maxValues;
    }

    public static void PrintIntValuesFromArray(int[] originArray, string message)
    {
        for (int i = 0; i < originArray.Length; i++)
        {
            System.Console.WriteLine("Value {0} {1}: {2}", message, i, originArray[i]);
        }
        System.Console.WriteLine();
    }

    public static void PrintIntValuesFromArrayWithIndexFromOriginArray(int[] modifiedArray, int[] originArray, string message)
    {
        for (int i = 0; i < modifiedArray.Length; i++)
        {
            System.Console.WriteLine("Value {0}{1}: {2}, index: {3}", message, i, modifiedArray[i], Array.IndexOf(originArray, modifiedArray[i]));
        }
        System.Console.WriteLine();
    }

    public static int GetRandomInt()
    {
        Random rnd = new Random();

        int randomValue = rnd.Next(0, 1000);

        return randomValue;
    }
}