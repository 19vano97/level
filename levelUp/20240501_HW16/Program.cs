internal class Program
{
    const int DEFAULT_ITEMS_QUANTITY = 10;
    
    private static void Main(string[] args)
    {
        int quantityOfArray = EnterIntValue("quantity of array [Quantity][]");
        float [][] linkedArray = InitLinkedArray(quantityOfArray);
        float[] avarageValuesInArray = GetSumOfAvarageValuesInLinkedArray(linkedArray);
        float[][] sortedLinkedArray = Sort1dAndLinkedArraysByTheFirstArray(avarageValuesInArray, linkedArray);
        float[] sorted1dArray = SortByInsertionWithTimer(avarageValuesInArray);

        PrintArray(sourceLinkedArray: linkedArray, message: "Source");
        PrintArray(avarageValuesInArray, message: "Avarage sum by i-array");
        PrintArray(sorted1dArray, sortedLinkedArray, message: "Sorted array by avarage sum");
    }

    public static int EnterIntValue(string message)
    {
        System.Console.Write("Enter {0}: ", message);
        int value = int.Parse(Console.ReadLine());

        return value;
    }

    public static float[][] InitLinkedArray(int quantity = DEFAULT_ITEMS_QUANTITY)
    {
        if (quantity == 0)
        {
            return null;
        }

        float[][] sourceLinkedArray = new float[quantity][];

        Random rndQuantityOfSubArray = new Random();
        Random rndValue = new Random();

        for (int i = 0; i < sourceLinkedArray.Length; i++)
        {
            int rndY = rndQuantityOfSubArray.Next(quantity / 2, quantity * 2);

            sourceLinkedArray[i] = new float[rndY];

            for (int y = 0; y < sourceLinkedArray[i].Length; y++)
            {
                sourceLinkedArray[i][y] = rndValue.Next(0, 1000);
            }
        }

        return sourceLinkedArray;
    }

    public static float[] GetSumOfAvarageValuesInLinkedArray(float[][] sourceLinkedArray)
    {
        float[] sumOfAverageValues = new float[sourceLinkedArray.Length];

        for (int i = 0; i < sourceLinkedArray.Length; i++)
        {
            float sumOfRow = 0.0f;

            for (int y = 0; y < sourceLinkedArray[i].Length; y++)
            {
                sumOfRow += sourceLinkedArray[i][y];
            }

            sumOfRow /= sourceLinkedArray[i].Length;
            sumOfAverageValues[i] = sumOfRow;
        }

        return sumOfAverageValues;
    }

    public static float[][] Sort1dAndLinkedArraysByTheFirstArray(float[] source1dArray, float[][] sourceLinkedArray)
    {
        float[][] copyOfSourceLinkedArray = new float[sourceLinkedArray.Length][];
        float[] copyOfsource1dArray = (float[])source1dArray.Clone();

        for (int i = 0; i < sourceLinkedArray.Length; i++)
        {
            copyOfSourceLinkedArray[i] = (float[])sourceLinkedArray[i].Clone();
        } 

        for (int i = 0; i < copyOfsource1dArray.Length; i++)
        {
            float currentValue = copyOfsource1dArray[i];
            int currentIndex = i;
            
            for (int y = i - 1; y >= 0; y--)
            {
                if (copyOfsource1dArray[y] <= currentValue)
                {
                    break;
                }

                float[] tempArray = copyOfSourceLinkedArray[y];
                copyOfSourceLinkedArray[y] = copyOfSourceLinkedArray[y + 1];
                copyOfSourceLinkedArray[y + 1] = tempArray;

                currentIndex = y;
            }
        }

        return copyOfSourceLinkedArray;
    }

    public static float[] SortByInsertionWithTimer(float[] originArray)
    {
        float[] sortByInsertion = (float[])originArray.Clone();

        for (int i = 0; i < sortByInsertion.Length; i++)
        {
            int insertIndex = i;
            float currentValue = sortByInsertion[i];

            for (int y = i - 1; y >= 0; y--)
            {
                if (sortByInsertion[y] > currentValue)
                {
                    float temp = sortByInsertion[y];
                    sortByInsertion[y] = sortByInsertion[y + 1];
                    sortByInsertion[y + 1] = temp;
                    insertIndex = y;
                }
                else
                {
                    break;
                }
            }

            sortByInsertion[insertIndex] = currentValue;
            
        }

        return sortByInsertion;
    }

    public static void PrintArray(float[] sourceArray = null, float[][] sourceLinkedArray = null, string message = null)
    {
        if (sourceArray != null & sourceLinkedArray == null)
        {
            System.Console.WriteLine(message);
            System.Console.WriteLine();

            for (int i = 0; i < sourceArray.Length; i++)
            {
                System.Console.WriteLine("{0, 5} index: {1},", sourceArray[i], i);
            }
            System.Console.WriteLine();
        }
        else if (sourceLinkedArray != null & sourceArray == null)
        {
            System.Console.WriteLine(message);
            System.Console.WriteLine();

            for (int i = 0; i < sourceLinkedArray.Length; i++)
            {
                for (int y = 0; y < sourceLinkedArray[i].Length; y++)
                {
                    System.Console.Write("{0, 5}", sourceLinkedArray[i][y]);
                }
                System.Console.WriteLine();
            }
            System.Console.WriteLine();
        }
        else if (sourceArray != null & sourceLinkedArray.Length == sourceArray.Length)
        {
            System.Console.WriteLine(message);
            System.Console.WriteLine();

            for (int i = 0; i < sourceLinkedArray.Length; i++)
            {
                System.Console.Write("{0} | ", sourceArray[i]);

                for (int y = 0; y < sourceLinkedArray[i].Length; y++)
                {
                    System.Console.Write("{0, 5}", sourceLinkedArray[i][y]);
                }
                System.Console.WriteLine();
            }
            System.Console.WriteLine();
        }
    }
}