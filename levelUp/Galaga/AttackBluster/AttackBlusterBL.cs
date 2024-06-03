namespace Galaga;

public class AttackBlusterBL
{
    const int DELAY_OF_KILLED_ENEMY = 100;
    public static char[,] DamageSpaceship(ref char[,] gamezone, ref Spaceship attacker, 
                                                ref Spaceship victim, ref Spaceship[] allSpaceships, 
                                                ulong gameTime, ref int score, ref bool isGameOver)
    {
        if (attacker.bluster.coordinates.x == victim.spaceshipCoodinates.x 
                && attacker.bluster.coordinates.y == victim.spaceshipCoodinates.y)
        {
            victim.healthPoint = victim.healthPoint - attacker.bluster.damage;

            allSpaceships = SpaceshipManipulation.UpdateSpaceshipArray(ref allSpaceships, ref victim);

            if (victim.healthPoint <= 0)
            {
                gamezone = GamezoneManipulations.DeletePosition(ref gamezone, victim.spaceshipCoodinates);

                Console.SetCursorPosition(victim.spaceshipCoodinates.x, victim.spaceshipCoodinates.y);
                Console.Write('\u2600');

                Thread.Sleep(DELAY_OF_KILLED_ENEMY);

                Console.SetCursorPosition(victim.spaceshipCoodinates.x, victim.spaceshipCoodinates.y);
                Console.Write(' ');

                if (attacker.id == 0)
                {
                    score++;
                }
                else
                {
                    isGameOver = false;
                }

                allSpaceships = SpaceshipManipulation.DeleteSpaceshipFromArray(ref allSpaceships, victim);
            }
            else
            {
                gamezone = UI.PrintEnemy(ref gamezone, ref victim);
            }
        }

        return gamezone;
    }

    public static bool IsTargetUnderBlustShot(Position blusterShotPosition, ref Spaceship[] allSpaceships)
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
                                                            ref Spaceship[] allSpaceships, 
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

    public static char[,] EnemyAutoShooting(ref char[,] gamezone, ref Spaceship[] allSpaceships, ref Spaceship enemy, 
                                                ulong gameTime, ref int score, GameLevelStructure level, ref bool isGameOver)
    {
        if (gameTime % level.enemyShotFrequensy == 0)
        {
            gamezone = AttackBlusterUI.ShootByBluster(ref gamezone, ref enemy, ref allSpaceships, 
                                                        true, gameTime, ref score, ref isGameOver);

            return gamezone;
        }

        return gamezone;
    }
}
