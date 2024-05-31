using _20240509_Lesson18;

internal class Program
{
    const int POINTS_COUNT = 4;
    private static void Main(string[] args)
    {
        {
            int[] xCoordindates = new int[POINTS_COUNT] {3, 7, 21, 11};
            int[] yCoordindates = new int[POINTS_COUNT] {10, 15, 11, 33};

            ConsoleColor[] pointsColors = new ConsoleColor[]
            {
                ConsoleColor.Red,
                ConsoleColor.DarkBlue,
                ConsoleColor.DarkCyan,
                ConsoleColor.DarkMagenta,
                ConsoleColor.Blue
            };

            ShowLine(xCoordindates, yCoordindates, pointsColors);
        }

        {
            Point2D p1 = new Point2D() {X = 3, Y = 10, Color = ConsoleColor.Red};
            Point2D p4 = new Point2D() {X = 11, Y = 33, Color = ConsoleColor.DarkMagenta};

            Point2D p5 = InputPoint();

            
            Show(p5);

            Point2D p5Copy = p5;
            p5Copy.X += 2;
            Show(p5Copy);

            // array of points
            Point2D[] points = new Point2D[]
            {
                p1,
                new Point2D() {X = 7, Y = 15, Color = ConsoleColor.DarkBlue},
                new Point2D() {X = 21, Y = 11, Color = ConsoleColor.DarkCyan},
                p4
            };

            ShowLine(points);
        }
    }

//     public static void ShowLine(int[] x, int[] y)
//     {
//         for (int i = 0; i < x.Length; i++)
//         {
//             System.Console.Write($"({x[i]}, {y[i]})");

//             if (i < x.Length - 1)
//             {
//                 System.Console.Write("-");
//             }
//         }
//         System.Console.WriteLine();
//     }

    public static void ShowLine(int[] x, int[] y, ConsoleColor[] colors)
    {
        for (int i = 0; i < x.Length; i++)
        {
          Console.ForegroundColor = colors[i];
            System.Console.Write($"({x[i]}, {y[i]})");

            if (i < x.Length - 1)
            {
              Console.ForegroundColor = ConsoleColor.Black;
                System.Console.Write("-");
            }
        }
        System.Console.WriteLine();
    }

    public static void ShowLine(Point2D[] coords)
    {
        for (int i = 0; i < coords.Length; i++)
        {
            Console.ForegroundColor = coords[i].Color;
            System.Console.Write($"({coords[i].X}, {coords[i].Y})");
            
            if (i < coords[i].X - 1)
            {
                Console.ForegroundColor = ConsoleColor.Black;
                System.Console.Write("-");
            }
        }

        System.Console.WriteLine();
    }

    public static Point2D InputPoint()
    {
        Point2D result;

        result.X = 10;
        result.Y = 12;
        result.Color = ConsoleColor.Blue;

        return result;
    }

    public static void Show(Point2D coord)
    {
        System.Console.WriteLine("{0}, {1}", coord.X, coord.Y);
    }

}
