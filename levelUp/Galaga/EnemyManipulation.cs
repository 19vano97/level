namespace Galaga;

public class EnemyManipulation
{
    public static char[,] MoveAutomiticallyEnemy(ref char[,] gamezone, ref Spaceship[] allSpaceships, 
                                                    ref Spaceship enemy, ulong gameTime, GameLevelStructure level)
    {
        Movements directionInt = GetRandomStepOfDirectionForEnemy(gamezone, enemy);

        if (gameTime % level.enemySpeed == 0)
        {
            if (directionInt == Movements.Left)
            {
                gamezone = SpaceshipManipulation.MoveSpaceship(ref gamezone, ref allSpaceships, ref enemy, ref enemy.spaceshipCoodinates.x, 
                                                                ref enemy.spaceshipCoodinates.y, directionInt);
            }
            
            if (directionInt == Movements.Right)
            {
                gamezone = SpaceshipManipulation.MoveSpaceship(ref gamezone, ref allSpaceships, ref enemy, ref enemy.spaceshipCoodinates.x, 
                                                                ref enemy.spaceshipCoodinates.y, directionInt);
            }
    
            if (directionInt == Movements.Up)
            {
                gamezone = SpaceshipManipulation.MoveSpaceship(ref gamezone, ref allSpaceships, ref enemy, ref enemy.spaceshipCoodinates.x, 
                                                                ref enemy.spaceshipCoodinates.y, directionInt);
            }
    
            if (directionInt == Movements.Down)
            {
                gamezone = SpaceshipManipulation.MoveSpaceship(ref gamezone, ref allSpaceships, ref enemy, ref enemy.spaceshipCoodinates.x, 
                                                                ref enemy.spaceshipCoodinates.y, directionInt);
            }
        }

        return gamezone;
    }

    public static Movements GetRandomStepOfDirectionForEnemy(char[,] gamezone, Spaceship enemy)
    {
        Movements direction = (Movements)BL.GetRandomInt(1, Enum.GetValues(typeof(Movements)).Cast<int>().Max());
        
        if (direction.HasFlag(Movements.Left) && (enemy.spaceshipCoodinates.x - 1) <= 0)
        {
            Movements directionTryAgain = GetRandomStepOfDirectionForEnemy(gamezone, enemy);
            
            return directionTryAgain;
        }

        if (direction.HasFlag(Movements.Right) && enemy.spaceshipCoodinates.x >= gamezone.GetLength(0) - 1)
        {
            Movements directionTryAgain = GetRandomStepOfDirectionForEnemy(gamezone, enemy);
            
            return directionTryAgain;
        }

        if (direction.HasFlag(Movements.Up) && (enemy.spaceshipCoodinates.y - 1) <= 0)
        {
            Movements directionTryAgain = GetRandomStepOfDirectionForEnemy(gamezone, enemy);
            
            return directionTryAgain;
        }

        if (direction.HasFlag(Movements.Left) && (enemy.spaceshipCoodinates.y >= gamezone.GetLength(0) - 1))
        {
            Movements directionTryAgain = GetRandomStepOfDirectionForEnemy(gamezone, enemy);
            
            return directionTryAgain;
        }


        return direction;
    }

    public static char[,] GenerateAmountOfEnemiesOnStart(ref char[,] gamezone, ref Spaceship[] allSpaceships, 
                                                            int enemiesMax, ulong gameTime, GameLevelStructure level)
    {
        if (GetAmountOfEnemies(allSpaceships) > enemiesMax || GetAmountOfEnemies(allSpaceships) >= 2)
        {
            return gamezone;
        }
        else
        {
            for (int i = 0; i < enemiesMax; i++)
            {
                Spaceship enemy = SpaceshipManipulation.InitEnemy(gamezone, level); 
                allSpaceships = SpaceshipManipulation.AddSpaceshipToArray(ref allSpaceships, ref enemy);
            }
    
            return gamezone;
        }
    }

    public static char[,] MoveAndShootEnemies(ref char[,] gamezone, ref Spaceship[] allSpaceships, 
                                                ulong gameTime, ref int score, GameLevelStructure level, ref bool isGameOver)
    {
        for (int i = 1; i < allSpaceships.Length; i++)
        {
            gamezone = MoveAutomiticallyEnemy(ref gamezone, ref allSpaceships, ref allSpaceships[i], gameTime, level);
            gamezone = AttackBlusterBL.EnemyAutoShooting(ref gamezone, ref allSpaceships, 
                                                            ref allSpaceships[i], gameTime, 
                                                            ref score, level, ref isGameOver);

            allSpaceships = SpaceshipManipulation.UpdateSpaceshipArray(ref allSpaceships, ref allSpaceships[i]);
        }

        return gamezone;
    }

    public static int GetAmountOfEnemies(Spaceship[] allSpaceships)
    {
        int value = allSpaceships.Length - 1;

        return value;
    }
}
