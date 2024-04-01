// See https://aka.ms/new-console-template for more information
using System.Security.Cryptography;
using _20240329_Lesson7;
using System.Runtime.Versioning;

System.Console.WriteLine("Current foreground: {0}", Console.ForegroundColor);
System.Console.WriteLine("Current foreground: {0}", Console.BackgroundColor);

System.Console.WriteLine($"{(char)Border.TopLeft}{(char)Border.TopRight}");
System.Console.WriteLine($"{(char)Border.BottomLeft}{(char)Border.BottomRight}");

int direction = 0;

switch (direction)
{
    case 1:
        System.Console.WriteLine("Left");
        break;
    case 2:
        System.Console.WriteLine("Top");
        break;
    case 3:
        System.Console.WriteLine("Right");
        break;
    case 4:
        System.Console.WriteLine("Bottom");
        break;    
}

#region enumIntialize
    Direction.d2;



#endregion



ConsoleKey key;
int x = Console.WindowWidth /2;
int y = Console.WindowHeight / 2;

Console.CursorVisible = false;

Console.SetCursorPosition(x, y);
System.Console.Write("#");

do
{
    key = Console.ReadKey().Key;
    Console.SetCursorPosition(x, y);
    Console.Write(' ');
    switch (key)
    {
        case ConsoleKey.LeftArrow:
            x--;
            break;
        case ConsoleKey.UpArrow:
            y--;
            break;
        case ConsoleKey.RightArrow: 
            x++; 
            break;
        case ConsoleKey.DownArrow:
            y++;
            break; 
        default:
            break;
    }  
    Console.SetCursorPosition(x, y);
    Console.Write('#');
} while (key != ConsoleKey.Escape);

Console.CursorVisible = true;


Direction d1 = Direction.Right;

System.Console.WriteLine($"d1: {d1}");

System.Console.Write("Enter new direction: ");

if (Enum.TryParse(Console.ReadLine(), out d1)
    && d1 >= Direction.Left && d1 <= Direction.Bottom)
{
    System.Console.WriteLine("(int)d1 {0}", (int)d1);
    switch (d1)
    {
        case Direction.Left:
            System.Console.WriteLine("<-");
            break;
        case Direction.Top:
            System.Console.WriteLine("^");
            break;
        case Direction.Right:
            System.Console.WriteLine("->");
            break;
        case Direction.Bottom:
            System.Console.WriteLine("v");
            break;
        default:
            break;
    } 
}
else
{
    System.Console.WriteLine("Wrong");
}

System.Console.WriteLine("Choose direction");
for (Direction b = Direction.Left; b < Direction.Bottom; b++)
{
    System.Console.WriteLine("{0}", b);
}
System.Console.WriteLine("");
if (Enum.TryParse(Console.ReadLine(), out Border ch)
    && ch >= Border.TopLeft && ch <= Border.TopRight)
{
    System.Console.WriteLine($"d1: {d1}, (int)d1: {(int)d1}");
}
else
{
    System.Console.WriteLine("Error");
}

System.Console.WriteLine("Choose border");
for (Border b = Border.TopLeft; b < Border.TopRight; b++)
{
    System.Console.WriteLine("{0}", b);
}
System.Console.WriteLine("");
if (Enum.TryParse(Console.ReadLine(), out Border ch)
    && ch >= Border.TopLeft && ch <= Border.TopRight)
{
    System.Console.WriteLine($"d1: {0}, (int)d1: {(int)ch}");
}
else
{
    System.Console.WriteLine("Error");
}


System.Console.WriteLine();