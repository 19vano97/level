using System.Diagnostics;
using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {
        int[] arrayToSort = InitArray();
        int[] bubbleArray = SortByBubble(arrayToSort);
        int[] selectionArray = SortBySelectionWithTimer(arrayToSort);
        int[] insertionArray = SortByInsertionWithTimer(arrayToSort);


        //PrintIntValuesFromArray(arrayToSort, "Original");
        // PrintIntValuesFromArray(bubbleArray, "Bubble");
        // PrintIntValuesFromArray(selectionArray, "Sorting");
        // PrintIntValuesFromArray(insertionArray, "Insertion");
    }

    public static int[] InitArray()
    {
        System.Console.Write("Array size: ");
        int quantity = int.Parse(Console.ReadLine());

        int[] originArray = new int[quantity];

        Random rnd = new Random();

        for (int i = 0; i < originArray.Length; i++)
        {
            originArray[i] = GetRandomInt();
        }

        return originArray;
    }

    public static int GetRandomInt()
    {
        Random rnd = new Random();

        int randomValue = rnd.Next(0, 1000);

        return randomValue;
    }

    public static int[] SortByBubble(int[] originArray)
    {
        int[] sortedByBubble = (int[])originArray.Clone();

        Stopwatch time = new Stopwatch();

        time.Start();

        for (int i = 0; i < sortedByBubble.Length - 1; i++)
        {

            bool swapped = false;

            for (int y = 0; y < sortedByBubble.Length - i - 1; y++)
            {
                if (sortedByBubble[y] > sortedByBubble[y + 1])
                {
                    int temp = sortedByBubble[y];
                    sortedByBubble[y] = sortedByBubble[y + 1];
                    sortedByBubble[y + 1] = temp;
                    swapped = true;
                }
            }

            if (!swapped)
            {
                break;
            }
        }

        time.Stop();

        TimeSpan ts = time.Elapsed;

        string elapsedTime = String.Format("{0:00}:{1:00}",
            ts.Seconds, ts.Milliseconds,
            ts.Milliseconds / 10);
        Console.WriteLine("Bubble sort: " + elapsedTime);

        return sortedByBubble;
    }

    public static int[] SortBySelectionWithTimer(int[] originArray)
    {
        int[] sortBySelection = (int[])originArray.Clone();

        Stopwatch time = new Stopwatch();

        time.Start();

        for (int i = 0; i < sortBySelection.Length; i++)
        {
            int minIndex = i;

            for (int y = i + 1; y < sortBySelection.Length; y++)
            {
                if (sortBySelection[y] < sortBySelection[minIndex])
                {
                    minIndex = y;
                }
            }

            if (minIndex != i)
            {
                int temp = sortBySelection[i];
                sortBySelection[i] = sortBySelection[minIndex];
                sortBySelection[minIndex] = temp;
            }
        }

        time.Stop();

        TimeSpan ts = time.Elapsed;

        string elapsedTime = String.Format("{0:00}:{1:00}",
            ts.Seconds, ts.Milliseconds,
            ts.Milliseconds / 10);
        Console.WriteLine("Selection sort: " + elapsedTime);

        return sortBySelection;
    }

    public static int[] SortByInsertionWithTimer(int[] originArray)
    {
        int[] sortByInsertion = (int[])originArray.Clone();

        Stopwatch time = new Stopwatch();

        time.Start();

        for (int i = 0; i < sortByInsertion.Length; i++)
        {
            int insertIndex = i;
            int currentValue = sortByInsertion[i];

            for (int y = i - 1; y >= 0; y--)
            {
                if (sortByInsertion[y] > currentValue)
                {
                    int temp = sortByInsertion[y];
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

        time.Stop();

        TimeSpan ts = time.Elapsed;

        string elapsedTime = String.Format("{0:00}:{1:00}",
            ts.Seconds, ts.Milliseconds,
            ts.Milliseconds / 10);
        Console.WriteLine("Insertion sort: " + elapsedTime);

        return sortByInsertion;
    }

    public static void PrintIntValuesFromArray(int[] originArray, string message)
    {
        for (int i = 0; i < originArray.Length; i++)
        {
            System.Console.WriteLine("message: {0}, value: {1}, index: {2}", message, originArray[i], Array.IndexOf(originArray, originArray[i]));
        }
        System.Console.WriteLine();
    }

}