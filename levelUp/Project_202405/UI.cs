using System.Reflection.PortableExecutable;

namespace Project_202405;

public class UI
{
    public static char PrintCharOfSpaceship()
    {
        Console.ForegroundColor = ConsoleColor.Red;
        char spaceshipUnique = '\u4DCC';

        // string spaceship =  "(TTTTTTT)";

        return spaceshipUnique;
    }

    public static char PrintStar()
    {
        char star = '*';

        return star;
    }

    public static void ShowStars(char icon, int x = int.MaxValue, int y = int.MaxValue)
    {      
            for (int k = 0; k < x / 100; k++)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                int xRandom = BL.GetRandomInt(0, x);
                Console.SetCursorPosition(xRandom, y);
                System.Console.Write(icon);
            }
    }

    public static char PrintBlasterShot()
    {
        char blasterShot = '|';

        return blasterShot;
    }
}
