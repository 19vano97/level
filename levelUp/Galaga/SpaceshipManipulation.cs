namespace Galaga;

public class SpaceshipManipulation
{
    const int HERO_HEALTHPOINTS = 100;
    const int ENEMY_HEALTHPOINTS = 50;
    const int HERO_BLUSTER_DAMAGE = 20;
    const int ENEMY_BLUSTER_DAMAGE = 20;

    public static Spaceship[] InitSpaceshipArray(char[,] gamezone)
    {
        Spaceship[] spaceships = new Spaceship[1];
        spaceships[0] = InitHero(gamezone);

        return spaceships;
    }

    public static Spaceship[] AddSpaceshipToArray(ref Spaceship[] allSpaceships, 
                                                                ref Spaceship spaceship)
    {
        Array.Resize(ref allSpaceships, allSpaceships.Length + 1);
        allSpaceships[allSpaceships.Length - 1] = spaceship;
        spaceship.id = allSpaceships.Length - 1;

        allSpaceships = UpdateSpaceshipArray(ref allSpaceships, spaceship);

        return allSpaceships;
    }

    public static Spaceship[] AddSpaceshipToArray(ref Spaceship[] allSpaceships, 
                                                                Spaceship spaceship)
    {
        Array.Resize(ref allSpaceships, allSpaceships.Length + 1);
        allSpaceships[allSpaceships.Length - 1] = spaceship;
        spaceship.id = allSpaceships.Length - 1;

        allSpaceships = UpdateSpaceshipArray(ref allSpaceships, spaceship);

        return allSpaceships;
    }

    public static Spaceship[] UpdateSpaceshipArray(ref Spaceship[] allSpaceships, 
                                                                params Spaceship[] spaceship)
    {
        for (int i = 0; i < spaceship.Length; i++)
        {
            allSpaceships[spaceship[i].id] = spaceship[i];
        }

        return allSpaceships;
    }

    public static Spaceship[] DeleteSpaceshipFromArray(ref Spaceship[] allSpaceships, 
                                                                    Spaceship spaceshipToDelete)
    {
        for (int i = spaceshipToDelete.id; i < allSpaceships.Length - 1; i++)
        {
            allSpaceships[i] = allSpaceships[i + 1];
            allSpaceships[i].id = allSpaceships[i].id - 1;
            System.Console.WriteLine("old {0}, new {1}", allSpaceships[i].id, allSpaceships[i].id + 1);
        }

        Array.Resize(ref allSpaceships, allSpaceships.Length - 1);

        return allSpaceships;
    }
    
    public static Spaceship InitHero(char[,] gamezone)
    {
        Spaceship hero = new Spaceship()
        {
            id = 0,
            symbol = UI.GetHeroSymbol(),
            healthPoint = HERO_HEALTHPOINTS,
            bluster = InitBlusterProperties(HERO_BLUSTER_DAMAGE, AttackBlusterUI.GetHeroBlusterShot(), 20),
            spaceshipCoodinates = UI.GetDefaultPosition(gamezone),
            spaceshipSpeed = 5
        };

        return hero;
    }

    public static BlusterProperties InitBlusterProperties(int damage = 100, char symbolOfShot = '|', int speed = 20)
    {
        BlusterProperties bluster = new BlusterProperties()
        {
            damage = damage,
            symbolOfShot = symbolOfShot,
            speed = speed
        };

        return bluster;
    }

    public static Spaceship InitEnemy(char[,] gamezone)
    {
        Spaceship enemy = new Spaceship()
        {
            id = 0,
            symbol = UI.GetEnemySymbol(),
            healthPoint = ENEMY_HEALTHPOINTS,
            bluster = InitBlusterProperties(ENEMY_BLUSTER_DAMAGE, AttackBlusterUI.GetEnemyBlusterShot(), 50),
            spaceshipCoodinates= LocateEnemy(gamezone)
        };

        return enemy;
    }

    public static Spaceship FindHeroByCoordinates(Spaceship[] allSpaceships)
    {
        Spaceship hero = new Spaceship();

        for (int i = 0; i < allSpaceships.Length; i++)
        {
            if (allSpaceships[i].symbol == UI.GetHeroSymbol())
            {
                hero = allSpaceships[i];
            }
        }

        return hero;
    }

    public static Position LocateEnemy(char[,] gamezone)
    {
        //int x = GetRandomInt(0, gamezone.GetLength(0));
        int xLocateEnemy = gamezone.GetLength(0) / 2;

        Position coordinates = new Position()
        {
            x = xLocateEnemy,
            y = 2
        };

        return coordinates;
    }
}
