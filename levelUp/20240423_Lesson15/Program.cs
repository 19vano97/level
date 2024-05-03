internal class Program
{
    static Random rnd = new Random();

    private static void Main(string[] args)
    {
        #region Name
        // int[] src = new int[] {21, -3, 212, 12};

        // int[] srcCopy = (int[])src.Clone(); // copy!!! Change hw 12,13,14!!

        // PrintIntValuesFromArray(src, "origin");

        // Array.Resize(ref src, 12); 

        // PrintIntValuesFromArray(src, "after resize + 12");

        // Array.Resize(ref src, 2);

        // PrintIntValuesFromArray(src, "after resize - 2");

        // Resize(ref src, 6);

        // PrintIntValuesFromArray(src, "after resize by func");

        // // for memory where all links (refs) were forgotten, there is a system GC(garbige conteiner)
        // //advanteges GC: 1. automated 2. 

        // GC.Collect();
        #endregion

        double[,] doubleArray = new double[8, 12];

        //doubleArray.Length = 4*5 = 20
        //doubleArray.GetLength(0) = 4 ->
        //doubleArray.GetLength(1) = 5 V

        for (int i = 0; i < doubleArray.GetLength(0); i++)
        {
            for (int y = 0; y < doubleArray.GetLength(1); y++)
            {
                doubleArray[i, y] = rnd.Next(-100, 101) / 10.0;
            }
        }

        PrintDoubleArrayVoid(doubleArray);

        double[,] doubleArrayTrans = Transp(doubleArray);

        PrintDoubleArrayVoid(doubleArrayTrans);

    }

    private static void PrintDoubleArrayVoid(double[,] doubleArray)
    {
        for (int i = 0; i < doubleArray.GetLength(0); i++)
        {
            for (int y = 0; y < doubleArray.GetLength(1); y++)
            {
                System.Console.Write("{0, 5}", doubleArray[i, y]);
            }
            System.Console.WriteLine();
        }
        System.Console.WriteLine();
    }

    private static double[,] Transp(double[,] doubleArray)
    {
        double[,] destination = new double[doubleArray.GetLength(1), doubleArray.GetLength(0)];

        for (int i = 0; i < doubleArray.GetLength(1); i++)
        {
            for (int y = 0; y < doubleArray.GetLength(0); y++)
            {
                destination[i, y] = doubleArray[y, i];
            }
            System.Console.WriteLine();
        }
        System.Console.WriteLine();

        return destination;
    }

    public static int[] GetCopy(int[] originArray)
    {
        int[] copyArray = new int[originArray.Length];

        if (originArray == null)
        {
            return null;
        }

        for (int i = 0; i < originArray.Length; i++)
        {
            copyArray[i] = originArray[i];
        }

        return copyArray;
    }

    public static void Resize(ref int[] originArray, int resize)
    {
        int[] destinationArray = new int[resize];

        if (originArray == null)
        {
            return;
        }

        if (resize > originArray.Length)
        {
            resize = originArray.Length;
        }

        for (int i = 0; i < resize; i++)
        {
            destinationArray[i] = originArray[i];
        }

        originArray = destinationArray;
    }

    public static void PrintIntValuesFromArray(int[] originArray, string message)
    {
        for (int i = 0; i < originArray.Length; i++)
        {
            System.Console.WriteLine("Value {0} {1}: {2}", message, i, originArray[i]);
        }
        System.Console.WriteLine();
    }
}