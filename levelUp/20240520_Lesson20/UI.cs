using System.Security.Cryptography.X509Certificates;

namespace _20240520_Lesson20;

public class UI
{
    public static void Show(Retrangle r)
    {
        Console.BackgroundColor = r.Color;
        for (int x = r.P1.X; x <= r.P2.X; x++)
        {
            for (int y = r.P1.Y; y < r.P2.Y; y++)
            {
                Hide(x, y);
                //Show(x, y);
                //Show(new Point2D() { X = x, Y = y });
            }
        }
        Console.BackgroundColor = ConsoleColor.Black;
    }
    // p - by value !!!
    public static void Show(Point2D p)
    {
        Console.ForegroundColor = p.Color;
        Show(p.X, p.Y);
        // copy!!!
        p.X += 2;
        p.Y += 3;
    }
    public static void Show(int x, int y)
    {
        Console.SetCursorPosition(x, y);
        //Console.Write($"({x}, {y})");
        Console.Write("*");
    }
    public static void Hide(int x, int y)
    {
        Console.SetCursorPosition(x, y);
        //Console.Write($"({x}, {y})");
        Console.Write(" ");
    }
    public static void ShowPolyLine(Point2D[] coords)
    {
        // coords.Length - кількість точок в ламаной лінії
        // !!! нам не потрібно синхронізувати кількість координат за X та Y
        for (int i = 0; i < coords.Length; i++)
        {
            Show(coords[i]);
            if (i < coords.Length - 1)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("-");
            }
        }
        Console.WriteLine();
    }
    public static Point2D InputPoint()
    {
        // Valu type!!!
        Point2D result;
        result.X = 10;
        result.Y = 12;
        result.Color = ConsoleColor.Green;
        return result;
    }
    public static void ShowPolyLine(int[] xCoords, int[] yCoords, ConsoleColor[] colors)
    {
        for (int i = 0; i < xCoords.Length; i++)
        {
            Console.ForegroundColor = colors[i];    // (1)
            Console.Write($"({xCoords[i]}, {yCoords[i]})");    // (2) (3)
            if (i < xCoords.Length - 1)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("-");
            }
        }
        Console.WriteLine();
    }
    //public static void ShowPolyLine(int[] xCoords, int[] yCoords)
    //{
    //    for (int i = 0; i < xCoords.Length; i++)
    //    {
    //        Console.Write($"({xCoords[i]}, {yCoords[i]})");
    //        if (i < xCoords.Length - 1)
    //        {
    //            Console.Write("-");
    //        }
    //    }
    //    Console.WriteLine();
    //}
}
