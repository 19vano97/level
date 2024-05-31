using _20240524_Dynamic;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Clear();
        ConsoleKey key;

        int x = Console.WindowWidth / 2;
        int y = Console.WindowHeight / 2;

        Direction direct = Direction.None;

        Console.SetCursorPosition(x, y);
        Console.Write("#");
        bool isRunning = true;

        ulong gameTime = 0;
        ulong speed = 10;

        do
        {
            Console.SetCursorPosition(x, y);
            System.Console.Write(' ');

            if (Console.KeyAvailable)
            {
                key = Console.ReadKey(true).Key; 

                switch (key)
                {
                case ConsoleKey.LeftArrow:
                    direct = Direction.Left;
                    break;
                case ConsoleKey.RightArrow:
                    direct = Direction.Right;
                    break;
                case ConsoleKey.UpArrow:
                    direct = Direction.Up;
                    break;
                case ConsoleKey.DownArrow:
                    direct = Direction.Down;
                    break;
                case ConsoleKey.Escape:
                    isRunning = false;
                    break;
                case ConsoleKey.W:
                    speed -= 2;
                    break;
                case ConsoleKey.Q:
                    speed += 2;
                    break;
                default:
                    break;
                }
            }

            if (gameTime % speed == 0L)
            {
                switch (direct)
                {
                    case Direction.Left:
                        x--;
                        break;
                    case Direction.Right:
                        x++;
                        break;
                    case Direction.Up:
                        y--;
                        break;
                    case Direction.Down:
                        y++;
                        break;
                    default:
                        break;
                }
            }

            Console.SetCursorPosition(x, y);
            Console.Write("#");

            Thread.Sleep(20);

            gameTime++;

        } while (isRunning);
    }
}