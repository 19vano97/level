using _20240430_Lesson16;

internal class Program
{
    private static void Main(string[] args)
    {
        int[][] arr2 = new int[5][];

        for (int i = 0; i < arr2.Length; i++)
        {
            arr2[i] = new int[i + 2];
        }

        int value = 1000;

        for (int i = arr2.Length - 1; i >= 0; i--)
        {
            for (int y = arr2[i].Length - 1; y >= 0; y--)
            {
                arr2[i][y] = --value;
            }
        }
        PrintArray(arr2, 5, 5);

        #region arrayCopy

        int[][] arrCopy = (int[][])arr2.Clone();
        PrintArray(arrCopy, 15, 5);

        int[][] arrCopy1 = GetFullCopy(arr2);
        PrintArray(arrCopy1, 5, 20);

        #endregion

        SwapRows(arr2, 1, 4);

        PrintArray(arr2);

        Weather[,][,,] weatherArray = new Weather[10, 12][,,];

        // weather.GetLength(0) - count of years

        for (int year = 0; year < weatherArray.GetLength(0); year++)
        {
            for (int month = 0; month < weatherArray.GetLength(1); month++)
            {
                weatherArray[year, month] = new Weather[31, 24, 60];
            }
        }

    }

    private static void SwapRows(int[][] arr2, int indexFirstRow, int indexSecondRow)
    {
        int[] temp = arr2[indexFirstRow];
        arr2[indexFirstRow] = arr2[indexSecondRow];
        arr2[indexSecondRow] = temp;
    }

    private static void PrintArray(int[][] sourceArray, int offsetX = 0, int offsetY = 0)
    { 
        int oldX = Console.CursorLeft;
        int oldY = Console.CursorTop;

        for (int i = 0; i < sourceArray.Length; i++)
        {
            for (int y = 0; y < sourceArray[i].Length; y++)
            {
                //Console.SetCursorPosition(offsetX + y * 5, offsetY + i);
                System.Console.Write("{0}, ", sourceArray[i][y]);
            }
            System.Console.WriteLine();
        }
        System.Console.WriteLine();

        //Console.SetCursorPosition(oldX, oldY);
    }

    public static int[][] GetFullCopy(int[][] sourceArray)
    {
        int[][] result = new int[sourceArray.Length][];
        // int[][] arrCopy = (int[][])sourceArray.Clone();

        for (int i = 0; i < sourceArray.Length; i++)
        {
            result[i] = (int[])sourceArray[i].Clone();
        }

        return result;
    }
}