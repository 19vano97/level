namespace Galaga;

public class AttackBlusterBL
{
    public static char[,] DamageSpaceship(ref char[,] gamezone, ref Spaceship attacker, 
                                                ref Spaceship victim, ref Spaceship[] allSpaceships)
    {
        if (attacker.bluster.coordinates.x == victim.spaceshipCoodinates.x 
                && attacker.bluster.coordinates.y == victim.spaceshipCoodinates.y)
        {
            victim.healthPoint = victim.healthPoint - attacker.bluster.damage;

            allSpaceships = SpaceshipManipulation.UpdateSpaceshipArray(ref allSpaceships, victim);

            if (victim.healthPoint <= 0)
            {
                gamezone = GamezoneManipulations.DeletePosition(ref gamezone, victim.spaceshipCoodinates);

                Console.SetCursorPosition(victim.spaceshipCoodinates.x, victim.spaceshipCoodinates.y);
                Console.Write('\u2600');

                Thread.Sleep(100);

                Console.SetCursorPosition(victim.spaceshipCoodinates.x, victim.spaceshipCoodinates.y);
                Console.Write(' ');

                allSpaceships = SpaceshipManipulation.DeleteSpaceshipFromArray(ref allSpaceships, victim);
            }
            else
            {
                Console.SetCursorPosition(victim.spaceshipCoodinates.x, victim.spaceshipCoodinates.y);
                System.Console.Write(victim.symbol);
            }
        }

        return gamezone;
    }

    public static bool IsTargetUnderBlustShot(Position blusterShotPosition, Spaceship[] allSpaceships)
    {
        bool isTargetNearShot = false;

        for (int i = 0; i < allSpaceships.Length; i++)
        {
            if (allSpaceships[i].spaceshipCoodinates.x == blusterShotPosition.x 
                    && allSpaceships[i].spaceshipCoodinates.y == blusterShotPosition.y)
            {
                isTargetNearShot = true;
                return isTargetNearShot;
            }
        }

        return isTargetNearShot;
    }

    public static Spaceship GetVictimOnShotLine(Position blusterShotPosition, 
                                                            Spaceship[] allSpaceships, 
                                                            bool enemyShot = false)
    {
        Spaceship victim = new Spaceship();
        if (!enemyShot)
        {
            for (int i = 0; i < allSpaceships.Length; i++)
            {
                if (allSpaceships[i].spaceshipCoodinates.x == blusterShotPosition.x 
                        && allSpaceships[i].spaceshipCoodinates.y == blusterShotPosition.y)
                {
                    victim = allSpaceships[i];
                    return victim;
                }
            }
        }
        else
        {
            victim = SpaceshipManipulation.FindHeroByCoordinates(allSpaceships);
            return victim;
        }

        return victim;
    }
}
