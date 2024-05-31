using System.Drawing;

namespace _20240520_Lesson20;

public class BL
{
    // Factory method - метод, обов'язок якого ініціалізувати іншу структуру (або клас)
    public static Polyline CreateEmpty()
    {
        Polyline pl = new Polyline()
        {
            Points = new Point2D[0]    // масив з 0ля елементів
        };
        return pl;
    }

    public static Polyline Create(int capacity)
    {
        Polyline pl = new Polyline()
        {
            Size = 0,
            Points = new Point2D[capacity]  
        };
        return pl;
    }
    
    public static Polyline Create(params Point2D[] points)
    {
        Polyline pl = new Polyline();

        for (int i = 0; i < points.Length; i++)
        {
            AddPoint(ref pl, points[i]);   
        }


        return pl;
    }

    public static void AddPoint(ref Polyline pl, Point2D p)
    {
        if (pl.Size >= GetCapacity(pl))
        {
            // TODO: set new size
            Array.Resize(ref pl.Points, pl.Points.Length + 1);
        }
        

        pl.Points[pl.Points.Length - 1] = p;
        pl.Size++;
    }

    // public static void DeletePoint(ref Polyline pl, int position)
    // {
    //     for (int i = position; i < pl.Points.Length - 1; i++)
    //     {
    //         pl.Points[i] = pl.Points[i + 1];
    //     }

    //     Array.Resize(ref pl.Points, pl.Points.Length - 1);
    // }

    public static Point2D DeletePoint(ref Polyline pl, int position)
    {
        Point2D delete = pl.Points[position];
        for (int i = position; i < pl.Points.Length - 1; i++)
        {
            pl.Points[i] = pl.Points[i + 1];
        }

        Array.Resize(ref pl.Points, pl.Points.Length - 1);

        return delete;
    }

    public static bool TryDeletePoint(ref Polyline pl, Point2D p)
    {
        int position = FindPosition(pl, p);
        bool result = position != -1;

        if (!result)
        {
            return result;
        }

        DeletePoint(ref pl, position);

        return result;
    }

    public static int FindPosition(Polyline pl, Point2D p)
    {
        int index = -1;

        for (int i = 0; i < pl.Points.Length; i++)
        {
            if (pl.Points[i].X == p.X && pl.Points[i].Y == p.Y)
            {
                index = i;
                break;
            }
        }

        return index;
    }

    public static bool UpdatePoint(Polyline pl, Point2D source, Point2D destination)
    {
        int position = FindPosition(pl, source);
        bool result = position != -1;

        if (!result)
        {
            return result;
        }

        pl.Points[position] = destination;

        return result;
    }

    public static int GetCapacity(Polyline pl)
    {
        return pl.Points.Length;
    }
}

