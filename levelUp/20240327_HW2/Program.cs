// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

char c1 = '┏';
char c2 = '┛';
char c3 = '┗';
char c4 = '┓';
char c5 = '━';
char c6 = '┃';


for (int i = 0; i < 100; i = i + 24)
{
    //System.Console.CursorLeft = i;
    System.Console.Write($"{c1}");
    for (int y = 0; y < 20; y++)
    {
        System.Console.Write($"{c5}");
    }
    System.Console.Write($"{c4}");
    System.Console.CursorLeft = i;
}

System.Console.WriteLine();

for (int i = 1; i <= 10; i++)
{
    System.Console.CursorLeft = 0;
    System.Console.Write($"{c6}");
    
    System.Console.CursorLeft = 6;
    System.Console.Write($"2 + {i} = " + 2 * i);

    System.Console.CursorLeft = 21;
    System.Console.Write($"{c6}");

    System.Console.CursorLeft = 24;
    System.Console.Write($"{c6}");

    System.Console.CursorLeft = 30;
    System.Console.Write($"3 + {i} = " + 3 * i);

    System.Console.CursorLeft = 45;
    System.Console.Write($"{c6}");

    System.Console.CursorLeft = 48;
    System.Console.Write($"{c6}");

    System.Console.CursorLeft = 54;
    System.Console.Write($"4 + {i} = " + 4 * i);

    System.Console.CursorLeft = 69;
    System.Console.Write($"{c6}");

    System.Console.CursorLeft = 72;
    System.Console.Write($"{c6}");

    System.Console.CursorLeft = 78;
    System.Console.Write($"5 + {i} = " + 5 * i);

    System.Console.CursorLeft = 93;
    System.Console.Write($"{c6}");

    System.Console.WriteLine();
}

for (int i = 0; i < 100; i = i + 24)
{
    //System.Console.CursorLeft = i;
    System.Console.Write($"{c3}");
    for (int y = 0; y < 20; y++)
    {
        System.Console.Write($"{c5}");
    }
    System.Console.Write($"{c2}");
    System.Console.CursorLeft = i;
}

System.Console.WriteLine();
System.Console.WriteLine();
System.Console.WriteLine();


for (int i = 0; i < 100; i = i + 24)
{
    //System.Console.CursorLeft = i;
    System.Console.Write($"{c1}");
    for (int y = 0; y < 20; y++)
    {
        System.Console.Write($"{c5}");
    }
    System.Console.Write($"{c4}");
    System.Console.CursorLeft = i;
}

System.Console.WriteLine();

for (int i = 1; i <= 10; i++)
{
    System.Console.CursorLeft = 0;
    System.Console.Write($"{c6}");
    
    System.Console.CursorLeft = 6;
    System.Console.Write($"6 + {i} = " + 6 * i);

    System.Console.CursorLeft = 21;
    System.Console.Write($"{c6}");

    System.Console.CursorLeft = 24;
    System.Console.Write($"{c6}");

    System.Console.CursorLeft = 30;
    System.Console.Write($"7 + {i} = " + 7 * i);

    System.Console.CursorLeft = 45;
    System.Console.Write($"{c6}");

    System.Console.CursorLeft = 48;
    System.Console.Write($"{c6}");

    System.Console.CursorLeft = 54;
    System.Console.Write($"8 + {i} = " + 8 * i);

    System.Console.CursorLeft = 69;
    System.Console.Write($"{c6}");

    System.Console.CursorLeft = 72;
    System.Console.Write($"{c6}");

    System.Console.CursorLeft = 78;
    System.Console.Write($"9 + {i} = " + 9 * i);

    System.Console.CursorLeft = 93;
    System.Console.Write($"{c6}");

    System.Console.WriteLine();
}

for (int i = 0; i < 100; i = i + 24)
{
    System.Console.Write($"{c3}");
    for (int y = 0; y < 20; y++)
    {
        System.Console.Write($"{c5}");
    }
    System.Console.Write($"{c2}");
    System.Console.CursorLeft = i;
}


System.Console.WriteLine();

