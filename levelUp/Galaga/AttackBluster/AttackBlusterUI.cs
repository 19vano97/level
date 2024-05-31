namespace Galaga;

public class AttackBlusterUI
{
    public static char[,] ShootBluster(ref char[,] gamezone, Spaceship spaceship, 
                                        ref Spaceship[] allSpaceships,
                                        bool enemyShot = false)
    {
        for (int i = 3; i > 0; i--)
        {
            spaceship.bluster.coordinates.x = spaceship.spaceshipCoodinates.x;
            spaceship.bluster.coordinates.y = i;

            Console.SetCursorPosition(spaceship.spaceshipCoodinates.x, i);
            System.Console.WriteLine(spaceship.bluster.symbolOfShot);

            Thread.Sleep(spaceship.bluster.speed);
            Console.SetCursorPosition(spaceship.spaceshipCoodinates.x, i);

            System.Console.WriteLine(' ');

            gamezone = GamezoneManipulations.UpdatePositionOnGamezone(ref gamezone, 
                                                                        spaceship, true, 
                                                                        [spaceship.spaceshipCoodinates.x, 
                                                                        i - 1]);

            if (AttackBlusterBL.IsTargetUnderBlustShot(spaceship.bluster.coordinates, allSpaceships))
            {
                Spaceship victim = AttackBlusterBL.GetVictimOnShotLine(spaceship.bluster.coordinates, 
                                                                        allSpaceships, enemyShot);
                gamezone = AttackBlusterBL.DamageSpaceship(ref gamezone, ref spaceship, 
                                                            ref victim, ref allSpaceships);
                
                break;
            }
        }

        return gamezone;
    }

    public static char GetHeroBlusterShot()
    {
        char shot = '|';

        return shot;
    }

    public static char GetEnemyBlusterShot()
    {
        char shot = '|';

        return shot;
    }
}
