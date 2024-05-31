namespace Project_202405;

public class BL
{
    public static int MoveSpaceship(SpaceshiptMovement direction = 0, int x = 0, int y = 0)
    {
        if (direction.HasFlag(SpaceshiptMovement.Up))
        {
            y--;
            return y;
        }
        else if (direction.HasFlag(SpaceshiptMovement.Down))
        {
            y++;
            return y;
        }
        else if (direction.HasFlag(SpaceshiptMovement.Left))
        {
            x--;
            return x;
        }
        else if (direction.HasFlag(SpaceshiptMovement.Right))
        {
            x++;
            return x;
        }

        return 0;
    }

    public static int GetRandomInt(int minLimit = int.MinValue, int maxLimit = int.MaxValue)
    {
        Random rnd = new Random();

        int value = rnd.Next(minLimit, maxLimit);

        return value;
    }

    public static int[,] InitializeGameZone()
    {
        int x = Console.WindowWidth;
        int y = Console.BufferHeight;

        int[,] gameZone = new int[y, x];

        return gameZone;
    }

    public static void RenderStars(int[,] gameZone, int renderSpeed = 1000)
    {

        do
        {
            for (int i = 0; i < gameZone.GetLength(0); i++)
            {
                UI.ShowStars(UI.PrintStar(), gameZone.GetLength(1), i);
                Thread.Sleep(renderSpeed);

                for (int k = 0; k < gameZone.GetLength(1); k++)
                {
                    System.Console.Write(' ');
                }
            }
            
        } while (true);
    }

    public static int[] GetSpaceShipPosition(int x, int y)
    {
        int[] position = new int[] {x, y};
        //System.Console.WriteLine("X={0} Y={1}", x, y);

        return position;
    }

    public static void ShootBlaster(int[] spaceshipPosition)
    {
        for (int i = spaceshipPosition[1]; i > 0 ; i--)
        {
            Render(spaceshipPosition[0], i, UI.PrintBlasterShot());
            Thread.Sleep(50);
            Render(spaceshipPosition[0], i, ' ');
        }
    }

    public static void Render(int x, int y, char symbol)
    {
        Console.SetCursorPosition(x, y);
        System.Console.WriteLine(symbol);
    }
}
