namespace Galaga;

public class GamezoneManipulations
{
    public static char[,] InitGamezone()
    {
        // int x = Console.WindowWidth;
        // int y = Console.WindowHeight;
        int x = 155;
        int y = 22;

        char[,] gamezone = new char[x, y];

        return gamezone;
    }

    public static char[,] UpdatePositionOnGamezone(ref char[,] gamezone, Spaceship spaceship, 
                                                    bool attack = false, int[] oldPosition = null)
    {
        if (attack == false)
        {
            gamezone[spaceship.spaceshipCoodinates.x, spaceship.spaceshipCoodinates.y] = spaceship.symbol;
        }
        else
        {
            gamezone[spaceship.bluster.coordinates.x, spaceship.bluster.coordinates.y] = spaceship.bluster.symbolOfShot;
        }

        gamezone = DeletePosition(ref gamezone, oldPosition);

        return gamezone;
    }

    public static char[,] DeletePosition(ref char[,] gamezone, int[] oldPosition)
    {
        gamezone[oldPosition[0], oldPosition[1]] = '\0';
        
        return gamezone;
    }

    public static char[,] DeletePosition(ref char[,] gamezone, Position oldPosition)
    {
        gamezone[oldPosition.x, oldPosition.y] = '\0';
        
        return gamezone;
    }


}
