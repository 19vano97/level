internal class Program
{
    private static void Main(string[] args)
    {
        int[] initial1dArray = Init1dArray();
        PrintArray(initial1dArray, message: "Intial 1D Array");

        int[,] arraySnakeDownUp = Transform1dTo2dArraySnakeDownUp(initial1dArray);
        PrintArray(initial1dArray, arraySnakeDownUp, true, "1D Array moved to 2D Array by snake (up - down)");

        int[,] arraySnakeLeftRight = Transform1dTo2dArraySnakeLeftRight(initial1dArray);
        PrintArray(initial1dArray, arraySnakeLeftRight, true, "1D Array moved to 2D Array by snake (left - right)");

        int[,] array2dtest = Init2dSquareArrayWithRndValues();
        int[,] squareChangeElementsOnDiagonals = ChangeElementsInDiagonals(array2dtest);
        int[,] changeElementsByTriangles = ChangeElementsByTrianglesUpDown(array2dtest);
        int[,] moveArrayTriangle = MoveArrayTrianglesByCircle(array2dtest);
        
        PrintArray(origin2dArray: array2dtest, message: "Initial 2D array");
        PrintArray(origin2dArray: squareChangeElementsOnDiagonals, message: "Changed the original 2D array by diagonals");
        PrintArray(origin2dArray: changeElementsByTriangles, message: "Changed the original 2D array by triangles (up - down)");
        PrintArray(origin2dArray: moveArrayTriangle, message: "Changed the original 2D array by triangle circle");
    }

    public static int EnterIntValue(string message)
    {
        System.Console.Write("Enter {0}: ", message);
        int value = int.Parse(Console.ReadLine());

        return value;
    }

    public static int[] Init1dArray()
    {
        int quantity = EnterIntValue("quantity for 1D array");

        int[] originArray = new int[quantity];

        Random rnd = new Random();

        for (int i = 0; i < originArray.Length; i++)
        {
            originArray[i] = rnd.Next(0, 1000);
        }

        return originArray;
    }

    public static int[,] Init2dSquareArrayWithRndValues(int quantityElementsinSquare = 0)
    {
        if (quantityElementsinSquare == 0)
        {
            quantityElementsinSquare = EnterIntValue("quantity of elements in a square");
        }

        int[,] sourceArray = new int[quantityElementsinSquare, quantityElementsinSquare];

        Random rnd = new Random();

        for (int i = 0; i < sourceArray.GetLength(0); i++)
        {
            for (int y = 0; y < sourceArray.GetLength(1); y++)
            {
                sourceArray[i,y] = rnd.Next(0, 1000);
            }
        }

        return sourceArray;
    }

    private static int[,] Get2dEmptyArrayBasedOn1dArray(ref int[] origin1dArray)
    {
        if (isPrimeValue(origin1dArray.Length))
        {
            Array.Resize(ref origin1dArray, origin1dArray.Length + 1);
        }

        int difference = 0, 
            quantityOfRowsFor2dArray = 0, 
            quantityOfColumnsFor2dArray = 0;

        for (int i = 1; i < origin1dArray.Length; i++)
        {
            difference = origin1dArray.Length / i;

            if (difference * i == origin1dArray.Length & i < origin1dArray.Length / 2)
            {
                quantityOfRowsFor2dArray = difference;
                quantityOfColumnsFor2dArray = i;
            }
        }

        int[,] result2dArray = new int[quantityOfRowsFor2dArray, quantityOfColumnsFor2dArray];
        
        return result2dArray;
    }

    public static int[,] Transform1dTo2dArraySnakeDownUp(int[] origin1dArray)
    {
        int[,] result2dArray = Get2dEmptyArrayBasedOn1dArray(ref origin1dArray);

        int index1dArray = 0;

        for (int i = 0; i < result2dArray.GetLength(1); i++)
        {
            if (i % 2 == 0)
            {
                for (int y = 0; y < result2dArray.GetLength(0); y++)
                {
                    result2dArray[y,i] = origin1dArray[index1dArray];
                    index1dArray++;
                }
            }
            else
            {
                for (int y = result2dArray.GetLength(0) - 1; y >= 0; y--)
                {
                    result2dArray[y,i] = origin1dArray[index1dArray];
                    index1dArray++;
                }
            }
        }

        return result2dArray;
    }

    public static int[,] Transform1dTo2dArraySnakeLeftRight(int[] origin1dArray)
    {
        int[,] result2dArray = Get2dEmptyArrayBasedOn1dArray(ref origin1dArray);

        int index1dArray = 0;

        for (int i = 0; i < result2dArray.GetLength(0); i++)
        {
            if (i % 2 == 0)
            {
                for (int y = 0; y < result2dArray.GetLength(1); y++)
                {
                    result2dArray[i, y] = origin1dArray[index1dArray];
                    index1dArray++;
                }
            }
            else
            {
                for (int y = result2dArray.GetLength(1) - 1; y >= 0; y--)
                {
                    result2dArray[i, y] = origin1dArray[index1dArray];
                    index1dArray++;
                }
            }
        }

        return result2dArray;
    }

    public static int[,] ChangeElementsInDiagonals(int[,] origin2dArray)
    {
        int[,] elementsOnDiagonals = (int[,])origin2dArray.Clone();

        int temp = 0;

        for (int i = 0; i < elementsOnDiagonals.GetLength(0); i++)
        {
            for (int y = i; y < elementsOnDiagonals.GetLength(0) / 2; y++)
            {
                if (y == i)
                {
                    temp = elementsOnDiagonals[i, y];
                    elementsOnDiagonals[i, y] = elementsOnDiagonals[i, elementsOnDiagonals.GetLength(0) - i - 1];
                    elementsOnDiagonals[i, elementsOnDiagonals.GetLength(0) - i - 1] = temp;
                }
            }
        }

        for (int i = elementsOnDiagonals.GetLength(0) - 1; i >= 0; i--)
        {
            for (int y = 0; y < elementsOnDiagonals.GetLength(0) / 2; y++)
            {
                if (y == elementsOnDiagonals.GetLength(0) - i - 1)
                {
                    temp = elementsOnDiagonals[i, y];
                    elementsOnDiagonals[i, y] = elementsOnDiagonals[i, elementsOnDiagonals.GetLength(0) - y  - 1];
                    elementsOnDiagonals[i, elementsOnDiagonals.GetLength(0) - y  - 1] = temp;
                }
            }
        }

        return elementsOnDiagonals;
    }

    public static int[,] ChangeElementsByTrianglesUpDown(int[,] origin2dArray)
    {
        int[,] elementsOnTriangles = (int[,])origin2dArray.Clone();

        int temp = 0;

        for (int i = 0; i < elementsOnTriangles.GetLength(0) / 2; i++)
        {
            for (int y = i; y < elementsOnTriangles.GetLength(0) - i; y++)
            {
                temp = elementsOnTriangles[i, y];
                elementsOnTriangles[i, y] = elementsOnTriangles[elementsOnTriangles.GetLength(0) - i - 1, y];
                elementsOnTriangles[elementsOnTriangles.GetLength(0) - i - 1, y] = temp;
            }
        }

        return elementsOnTriangles;
    }

    public static int[,] MoveArrayTrianglesByCircle(int[,] origin2dArray)
    {
        int[,] elementsOnTriangles = (int[,])origin2dArray.Clone();

        int temp = 0;

        for (int i = 0; i < elementsOnTriangles.GetLength(0) / 2; i++)
        {
            for (int y = i; y < elementsOnTriangles.GetLength(0) - i; y++)
            {
                // temp1 = elementsOnTriangles[i, y];
                // temp2 = elementsOnTriangles[y, elementsOnTriangles.GetLength(0) - i - 1];
                // temp3 = elementsOnTriangles[elementsOnTriangles.GetLength(0) - i - 1, elementsOnTriangles.GetLength(0) - y - 1];
                // temp4 = elementsOnTriangles[y, i];

                // elementsOnTriangles[i, y] = elementsOnTriangles[y, elementsOnTriangles.GetLength(0) - i - 1];
                // elementsOnTriangles[elementsOnTriangles.GetLength(0) - i - 1, y] = temp2;

                temp = elementsOnTriangles[y, elementsOnTriangles.GetLength(0) - i - 1];
                elementsOnTriangles[y, elementsOnTriangles.GetLength(0) - i - 1] = elementsOnTriangles[i, y];
                elementsOnTriangles[i, y] = elementsOnTriangles[y, i];
                elementsOnTriangles[y, i] = elementsOnTriangles[elementsOnTriangles.GetLength(0) - i - 1, elementsOnTriangles.GetLength(0) - y - 1];
                elementsOnTriangles[elementsOnTriangles.GetLength(0) - i - 1, y] = temp;                
            }
        }

        return elementsOnTriangles;
    }

    public static bool isPrimeValue(int value)
    {
        for (int i = 2; i < value; i++)
        {
            if (value % i == 0)
            {
                return false;
            }
        }

        return true;
    }

    public static void PrintArray(int[] originArray = null, int[,] origin2dArray = null, bool compareIndexes = false, string message = null)
    {
        if (originArray != null & origin2dArray == null)
        {
            System.Console.WriteLine(message);
            System.Console.WriteLine();

            for (int i = 0; i < originArray.Length; i++)
            {
                System.Console.Write("{0, 5}", originArray[i]);
            }
            System.Console.WriteLine();
        }
        else if (origin2dArray != null & originArray == null)
        {
            System.Console.WriteLine(message);
            System.Console.WriteLine();

            for (int i = 0; i < origin2dArray.GetLength(0); i++)
            {
                for (int y = 0; y < origin2dArray.GetLength(1); y++)
                {
                    System.Console.Write("{0, 5}", origin2dArray[i,y]);
                }
                System.Console.WriteLine();
            }
        }
        else if (originArray != null & origin2dArray != null & compareIndexes == false)
        {
            System.Console.WriteLine(message);
            System.Console.WriteLine();

            for (int i = 0; i < originArray.Length; i++)
            {
                System.Console.Write("{0, 5}", originArray[i]);
            }

            System.Console.WriteLine();
            System.Console.WriteLine();

            for (int i = 0; i < origin2dArray.GetLength(0); i++)
            {
                for (int y = 0; y < origin2dArray.GetLength(1); y++)
                {
                    System.Console.Write("{0, 5}", origin2dArray[i,y]);
                }
                System.Console.WriteLine();
            }
        }
        else if (originArray != null & origin2dArray != null & compareIndexes == true)
        {
            System.Console.WriteLine(message);
            System.Console.WriteLine();
            
            for (int i = 0; i < origin2dArray.GetLength(0); i++)
            {
                for (int y = 0; y < origin2dArray.GetLength(1); y++)
                {
                    System.Console.Write("{0, 5}, [{1}, {2}] [{3}] |", 
                        origin2dArray[i, y], i, y, Array.IndexOf(originArray, origin2dArray[i,y]));
                }
                System.Console.WriteLine();
            }
        }
        System.Console.WriteLine();           
    }

    public static int Compare2dArrays(int[,] origin2dArray, int[,] secondaryArray, int value)
    {
        for (int i = 0; i < origin2dArray.GetLength(0); i++)
        {
            for (int y = 0; y < origin2dArray.GetLength(0); y++)
            {
                if (secondaryArray[i, y].Equals(value))
                {
                    System.Console.WriteLine("{0, 5}, [{1}, {2}] |", 
                        secondaryArray[i, y], i, y);
                }
            }
            
        }

        return 0;
    }
}