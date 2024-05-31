using System.ComponentModel;

namespace Galaga;

public class UI
{
    public static char GetHeroSymbol()
    {
        Console.ForegroundColor = ConsoleColor.Red;
        char hero = '\u4DCC';

        return hero;
    }

    public static char GetEnemySymbol()
    {
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        char enemy = 'A';

        return enemy;
    }

    public static void SetDefaultPosition(char[,] gamezone)
    {
        Console.SetCursorPosition(gamezone.GetLength(0) / 2, gamezone.GetLength(1) - 1);
    }

    public static Position GetDefaultPosition(char[,] gamezone)
    {
        Position defaultPosition = new Position ()
        {
            x = gamezone.GetLength(0) / 2, 
            y = gamezone.GetLength(1) - 1
        };

        return defaultPosition;
    }

    public static char[,] PrintEnemy(ref char[,] gamezone, Spaceship enemy)
    {
        Console.SetCursorPosition(enemy.spaceshipCoodinates.x, enemy.spaceshipCoodinates.y);
        gamezone[enemy.spaceshipCoodinates.x, enemy.spaceshipCoodinates.y] = enemy.symbol;
        System.Console.Write(enemy.symbol);

        return gamezone;
    }

    public static char GetDestoyEnemy()
    {
        char destroy = '\u2601';

        return destroy;
    }

    public static void PrintShortInfoAboutSpaceShip(Spaceship spaceshipInfo)
    {
        System.Console.WriteLine("id: {0}, HP: {1}", spaceshipInfo.id, spaceshipInfo.healthPoint);
    }

    public static void PrintShortInfoAboutSpaceShip(Spaceship[] allSpaceships)
    {
        for (int i = 0; i < allSpaceships.Length; i++)
        {
            System.Console.WriteLine("id: {0}, HP: {1}", allSpaceships[i].id, allSpaceships[i].healthPoint);
        }
    }

    
    
}
