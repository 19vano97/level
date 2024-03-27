// See https://aka.ms/new-console-template for more information
using System;
Console.WriteLine("Hello, World!");

#region HW1.1
    //rectangle
    Console.WriteLine();
    Console.WriteLine("HW 1.1");
    Console.WriteLine();

    Console.WriteLine("Rectangle by cycles");

    Console.WriteLine("Enter a width: ");
    int widthRectangle = int.Parse(Console.ReadLine());

    Console.WriteLine("Enter a lenght: ");
    int lenghtRectangle = int.Parse(Console.ReadLine());

    for (int i = 0; i < widthRectangle; i++)
    {
        Console.Write("* ");
    }

    Console.WriteLine();

    lenghtRectangle = lenghtRectangle - 2;

    for (int y = 0; y < lenghtRectangle; y++)
    {
        Console.CursorLeft = 0;
        Console.WriteLine("*");
        Console.CursorLeft = widthRectangle * 2;
        Console.Write("*");
    }

    Console.CursorLeft = 0;

    for (int m = 0; m < widthRectangle; m++)
    {
        Console.Write("* ");
    }

    Console.WriteLine("Rectangle by a cycle");
    Console.WriteLine();

    Console.WriteLine("Triangle by a cycle");
    Console.WriteLine();

    Console.WriteLine("Enter a lenght: ");
    int lenghtTriangle = int.Parse(Console.ReadLine());

    for (int k = 1; k <= lenghtTriangle; k++)
    {
        Console.CursorLeft = k + lenghtTriangle;
        Console.WriteLine("*");
        Console.CursorLeft = lenghtTriangle - k;
        Console.Write("*");
    }

    Console.Write(new string('*', lenghtTriangle * 2));

    Console.WriteLine();

    Console.WriteLine("Triangle by hardcode");
    //hardcoded triangle
    Console.WriteLine();
    Console.WriteLine();

    Console.CursorLeft = 3;
    Console.WriteLine("*"); //top
    Console.CursorLeft = 2;
    Console.WriteLine("* *");
    Console.CursorLeft = 1;
    Console.WriteLine("*   *");
    Console.CursorLeft = 0;
    Console.WriteLine("*******");

    //parallelepiped
    Console.WriteLine();

    Console.WriteLine("Parallelepiped by a cycle");

    Console.WriteLine("Enter a width: ");
    int widthParallelepiped = int.Parse(Console.ReadLine());

    Console.WriteLine("Enter a lenght: ");
    int lenghtParallelepiped = int.Parse(Console.ReadLine());

    Console.WriteLine();

    lenghtParallelepiped = lenghtParallelepiped - 2;

    Console.CursorLeft = lenghtParallelepiped;

    Console.Write(new string('*', widthParallelepiped));

    for (int i = lenghtParallelepiped; i > 0; --i)
    {
        Console.CursorLeft = i;
        Console.WriteLine("*");
        Console.CursorLeft = i + widthParallelepiped - 1;
        Console.Write("*");
    }

    Console.CursorLeft = 0;

    Console.WriteLine();

    Console.Write(new string('*', widthParallelepiped));

    Console.WriteLine();

    Console.WriteLine("Parallelepiped by a hardcode");
    Console.CursorLeft = 5;
    Console.WriteLine(new string('*', 10));

    Console.CursorLeft = 4;
    Console.Write("*");

    Console.CursorLeft = 13;
    Console.Write("*");
    Console.WriteLine();

    Console.CursorLeft = 3;
    Console.Write("*");
    Console.CursorLeft = 12;
    Console.Write("*");
    Console.WriteLine();

    Console.CursorLeft = 2;
    Console.Write("*");

    Console.CursorLeft = 11;
    Console.Write("*");
    Console.WriteLine();

    Console.CursorLeft = 1;
    Console.Write("*");
    Console.CursorLeft = 10;
    Console.Write("*");
    Console.WriteLine();

    Console.CursorLeft = 0;
    Console.WriteLine(new string('*', 10));

#endregion


#region HW 1.2
//1.2
    Console.WriteLine();
    Console.WriteLine("HW 1.2");

    Console.WriteLine();

    Console.WriteLine("With additional variable");

    int a = 3;
    int b = 6;
    int c = 1;
    int d = 0;

    Console.Write("Initial: {0}, {1}, {2}", a, b, c);

    if (true)
    {
        d = b;
        b = a;
        a = c;
        c = d;
        Console.Write("Changed: {0}, {1}, {2}", a, b, c);
    }

    Console.WriteLine();

    Console.WriteLine("Without additional variable");

    Console.Write("q=");
    int q = int.Parse(Console.ReadLine());

    Console.Write("w=");
    int w = int.Parse(Console.ReadLine());

    Console.Write("e=");
    int e = int.Parse(Console.ReadLine());

    q = q + w + e;
    w = q - w - e;
    e = q - w - e;
    q = q - e - w;
    
    Console.WriteLine("q={0}, w={1}, e={2}", q, w, e);

#endregion

Console.WriteLine();
Console.Write("Press any key...");
Console.ReadKey();
