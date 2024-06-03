namespace Galaga;

public class GamezoneManipulations
{
    public static char[,] InitGamezone()
    {
        int x = Console.WindowWidth;
        int y = Console.WindowHeight - 5;
        // int x = 155;
        // int y = 22;

        char[,] gamezone = new char[x, y];

        return gamezone;
    }

    public static char[,] UpdatePositionOnGamezone(ref char[,] gamezone, Spaceship spaceship, 
                                                   Position oldPosition, bool attack = false)
    {
        if (attack == false)
        {
            if (spaceship.spaceshipCoodinates.x < 0 || spaceship.spaceshipCoodinates.x > gamezone.GetLength(0) - 1 
                || spaceship.spaceshipCoodinates.y < 0 || spaceship.spaceshipCoodinates.y > gamezone.GetLength(1) - 1)
            {
                return gamezone;
            }
            else
            {
                gamezone[spaceship.spaceshipCoodinates.x, spaceship.spaceshipCoodinates.y] = spaceship.symbol;  
            }
        }
        else
        {
            gamezone[spaceship.bluster.coordinates.x, spaceship.bluster.coordinates.y] = spaceship.bluster.symbolOfShot;
        }

        gamezone = DeletePosition(ref gamezone, oldPosition);

        return gamezone;
    }

    public static char[,] UpdateAllpostionsBySpaceshipArray(ref char[,] gamezone, Spaceship[] allSpaceships)
    {
        for (int i = 0; i < gamezone.GetLength(0); i++)
        {
            for (int j = 0; j < gamezone.GetLength(1); j++)
            {
                if (allSpaceships[i].spaceshipCoodinates.x < 0 || allSpaceships[i].spaceshipCoodinates.x > gamezone.GetLength(0) - 1 
                || allSpaceships[i].spaceshipCoodinates.y < 0 || allSpaceships[i].spaceshipCoodinates.y > gamezone.GetLength(1) - 1)
                {
                    return gamezone;
                }

                else if (gamezone[i, j] == allSpaceships[1].symbol || gamezone[i, j] == allSpaceships[0].symbol)
                {
                    gamezone[i, j] = '\0';
                }
            }
        }
        
        for (int i = 0; i < allSpaceships.Length; i++)
        {
            gamezone[allSpaceships[i].spaceshipCoodinates.x, allSpaceships[i].spaceshipCoodinates.y] = allSpaceships[i].symbol;
        }

        return gamezone;
    }

    public static char[,] DeletePosition(ref char[,] gamezone, Position oldPosition)
    {
        if (oldPosition.x < 0 || oldPosition.x > gamezone.GetLength(0) - 1 
                || oldPosition.y < 0 || oldPosition.y > gamezone.GetLength(1) - 1)
        {
            return gamezone;
        }
        else
        {
            gamezone[oldPosition.x, oldPosition.y] = '\0';
            
            return gamezone;
        }
    }


}
