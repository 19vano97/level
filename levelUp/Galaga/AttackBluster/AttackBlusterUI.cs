using System.Security.Cryptography.X509Certificates;

namespace Galaga;

public class AttackBlusterUI
{
    public static char[,] MoveBlusterShot(ref char[,] gamezone, ref Spaceship attacker, bool isEnemyShot)
    {
        int x = attacker.bluster.coordinates.x;
        int y = attacker.bluster.coordinates.y;

        Position oldShotPosition = new Position()
        {
            x = x,
            y = y
        };

        if (!isEnemyShot)
        {
            y--;
            attacker.bluster.coordinates.x = x;
            attacker.bluster.coordinates.y = y;
        }
        else
        {
            y++;
            attacker.bluster.coordinates.x = x;
            attacker.bluster.coordinates.y = y;
        }

        if (attacker.bluster.coordinates.y < 0 || attacker.bluster.coordinates.y > gamezone.GetLength(1) - 1)
        {
            attacker.bluster.coordinates.y = oldShotPosition.y;
            return gamezone;
        }

        Console.SetCursorPosition(attacker.bluster.coordinates.x, attacker.bluster.coordinates.y);
        System.Console.Write(attacker.bluster.symbolOfShot);

        gamezone = GamezoneManipulations.UpdatePositionOnGamezone(ref gamezone, attacker, oldShotPosition, true);

        return gamezone;
    }

    public static char[,] ShootByBluster(ref char[,] gamezone, ref Spaceship attacker, 
                                        ref Spaceship[] allSpaceships, bool isEnemyShot, ulong gameTime, ref int score, ref bool isGameOver)
    {
        if (!isEnemyShot)
        {
            for (int i = attacker.spaceshipCoodinates.y - 1; i > 0; i--)
            {
                attacker.bluster.coordinates.x = attacker.spaceshipCoodinates.x;
                attacker.bluster.coordinates.y = i;
    
                gamezone = MoveBlusterShot(ref gamezone, ref attacker, isEnemyShot);
    
                if (AttackBlusterBL.IsTargetUnderBlustShot(attacker.bluster.coordinates, ref allSpaceships))
                {
                    Spaceship victim = AttackBlusterBL.GetVictimOnShotLine(attacker.bluster.coordinates, 
                                                                            ref allSpaceships, isEnemyShot);
                    
                    
                    
                    gamezone = AttackBlusterBL.DamageSpaceship(ref gamezone, ref attacker, 
                                                                ref victim, ref allSpaceships, gameTime, ref score, ref isGameOver);
                    break;
                }
            }
            for (int i = attacker.spaceshipCoodinates.y - 1; i >= 0; i--)
            {
                Thread.Sleep(2);
                Console.SetCursorPosition(attacker.bluster.coordinates.x, i);
                System.Console.Write(' ');
            }

        }
        else
        {
            for (int i = attacker.spaceshipCoodinates.y + 1; i < gamezone.GetLength(1); i++)
            {
                attacker.bluster.coordinates.x = attacker.spaceshipCoodinates.x;
                attacker.bluster.coordinates.y = i;
    
                gamezone = MoveBlusterShot(ref gamezone, ref attacker, isEnemyShot);
    
                if (AttackBlusterBL.IsTargetUnderBlustShot(attacker.bluster.coordinates, ref allSpaceships))
                {
                    Spaceship victim = AttackBlusterBL.GetVictimOnShotLine(attacker.bluster.coordinates, 
                                                                            ref allSpaceships, isEnemyShot);

                    
                    gamezone = AttackBlusterBL.DamageSpaceship(ref gamezone, ref attacker, 
                                                                ref victim, ref allSpaceships, gameTime, ref score, ref isGameOver);
                    break;
                }
            }
            for (int i = attacker.spaceshipCoodinates.y + 1; i < gamezone.GetLength(1); i++)
            {
                Thread.Sleep(2);
                Console.SetCursorPosition(attacker.bluster.coordinates.x, i);
                System.Console.Write(' ');
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
