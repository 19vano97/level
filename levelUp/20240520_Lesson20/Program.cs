using _20240520_Lesson20;

internal class Program
{
    private static void Main(string[] args)
    {
        Point2D p1 = new Point2D() {X = 3, Y = 10, Color = ConsoleColor.Red};
        Point2D p4 = new Point2D() {X = 11, Y = 33, Color = ConsoleColor.DarkMagenta};

        const int POINTS_COUNT = 4;

        static void Main(string[] args)
        {
            // Demo1();

            Console.ForegroundColor = ConsoleColor.White;
            // Demo2();

            #region ---===   Agregation   ===---

            Point2D p1 = new Point2D() { X = 13, Y = 4, Color = ConsoleColor.Red };

            Retrangle r1 = new Retrangle()
            {
                P1 = p1,
                P2 = new Point2D() { X = 23, Y = 14, Color = ConsoleColor.Red },
                Color = ConsoleColor.Green
            };

            UI.Show(r1);

            #endregion

            #region ---===   Composition   ===---

            Polyline poly1 = new Polyline();

            poly1.Points = new Point2D[] 
            { 
                r1.P1, 
                r1.P2,
                new Point2D() { X = 34, Y = 3, Color = ConsoleColor.Red },
            };

            Polyline poly2 = BL.CreateEmpty();
            int size = poly2.Points.Length;

            Array.Resize(ref poly2.Points, size + 4);

            // var. 2
            Polyline poly3 = BL.Create(r1.P1, r1.P2);

            #endregion

            // params !!!

            Console.WriteLine("Press any key...");
            Console.ReadKey();
        }

        // private static void Demo2()
        // {
        //     // Початкова ініціалізація змінної структури
        //     // <StuctType> <Variable> = new <StuctType>() { <СПИСОК_ІНІЦІАЛІЗАЦІЇ> };
        //     // <СПИСОК_ІНІЦІАЛІЗАЦІЇ> ::= <Field1> = <Value1>, <Field2> = <Value2>, [...] 
        //     // new <StuctType>() - виклик конструктора по замовчуванню
        //     Point2D p1 = new Point2D() { X = 3, Y = 10, Color = ConsoleColor.Red };
        //     Point2D p4 = new Point2D()
        //     {
        //         X = 11,     // comment1
        //         Y = 33,
        //         Color = ConsoleColor.DarkGreen
        //     };

        //     Point2D p5 = UI.InputPoint();

        //     Point2D p5Copy = p5;

        //     p5Copy.Y += 2;

        //     Console.ForegroundColor = ConsoleColor.Magenta;
        //     Console.Write("p5: ");
        //     UI.Show(p5);
        //     Console.WriteLine();

        //     Console.ForegroundColor = ConsoleColor.Yellow;
        //     Console.Write("p5Copy: ");
        //     UI.Show(p5Copy);
        //     Console.WriteLine();

        //     Console.ReadKey();

        //     // масив точок 
        //     Point2D[] points = new Point2D[]
        //     {
        //             p1,
        //             new Point2D() { X = 7, Y = 15, Color = ConsoleColor.Green },
        //             new Point2D() { X = 21, Y = 11, Color = ConsoleColor.Blue },
        //             p4
        //     };

        //     UI.ShowPolyLine(points);
        // }

        // private static void Demo1()
        // {
        //     // опис ламаної лінії
        //     int[] xCoordinates = new int[/*POINTS_COUNT*/] { 3, 7, 21, 11/*, 31*/ };
        //     int[] yCoordinates = new int[POINTS_COUNT] { 10, 15, 11, 33 };
        //     int[] zCoordinates = new int[POINTS_COUNT] { 10, 15, 11, 33 };
        //     ConsoleColor[] pointsColors = new ConsoleColor[/*POINTS_COUNT*/]
        //     {
        //             ConsoleColor.Red,
        //             ConsoleColor.Green,
        //             ConsoleColor.Blue,
        //             ConsoleColor.DarkGreen,
        //             ConsoleColor.Cyan    // не використовується, => НЕМАЄ СИНХРОНІЗАЦІЇ !!!!
        //     };

        //     UI.ShowPolyLine(xCoordinates, yCoordinates, pointsColors);
        // }

    }
}