using Galaga;

internal class Program
{
    const int DELAY = 50;

    private static void Main(string[] args)
    {
        Console.Clear();

        GameLevelStructure level = LevelDesign.GetLevelOfDifficulty(LevelDesign.ChooseLevelFromAList());

        Console.Clear();

        int score = 0;

        char[,] gamezone = GamezoneManipulations.InitGamezone();

        Spaceship[] allSpaceships = SpaceshipManipulation.InitSpaceshipArray(gamezone, level);
        Spaceship hero = allSpaceships[0];
        
        UI.SetDefaultPosition(gamezone);

        int x = UI.GetDefaultPosition(gamezone).x;
        int y = UI.GetDefaultPosition(gamezone).y;

        bool isRunning = true;
        bool isGameOver = false;
        
        // Start position
        hero.spaceshipCoodinates.x = x;
        hero.spaceshipCoodinates.y = y;

        Movements direction = Movements.None;

        Console.CursorVisible = false;

        ulong gameTime = 0;

        ConsoleKey key;

        do
        {
            hero = allSpaceships[0];

            #region SpaceshipMove

                if (Console.KeyAvailable)
                {
                    key = Console.ReadKey().Key;
    
                    switch (key)
                    {
                        case ConsoleKey.UpArrow:
                            direction = Movements.Up;
                            break;
                        case ConsoleKey.DownArrow:
                            direction = Movements.Down;
                            break;
                        case ConsoleKey.LeftArrow:
                            direction = Movements.Left;
                            break;
                        case ConsoleKey.RightArrow:
                            direction = Movements.Right;
                            break;
                        case ConsoleKey.Spacebar:
                            AttackBlusterUI.ShootByBluster(ref gamezone, ref hero, ref allSpaceships, 
                                                                        false, gameTime, ref score, ref isRunning);
                            break;
                        case ConsoleKey.Escape:
                            isRunning = false;
                            break;
                        default:
                            break;
                    }
                }
    
                if (gameTime % level.heroSpeed == 0L)
                {
                    switch (direction)
                    {       
                        case Movements.Up:
                            SpaceshipManipulation.MoveSpaceship(ref gamezone, ref allSpaceships, ref hero, ref x, ref y, direction);
                            break;
                        case Movements.Down:
                            SpaceshipManipulation.MoveSpaceship(ref gamezone, ref allSpaceships, ref hero, ref x, ref y, direction);
                            break;
                        case Movements.Left:
                            SpaceshipManipulation.MoveSpaceship(ref gamezone, ref allSpaceships, ref hero, ref x, ref y, direction);
                            break;
                        case Movements.Right:
                            SpaceshipManipulation.MoveSpaceship(ref gamezone, ref allSpaceships, ref hero, ref x, ref y, direction);
                            break;
                        default:
                            break;
                    }
    
                }

            #endregion

            EnemyManipulation.GenerateAmountOfEnemiesOnStart(ref gamezone, ref allSpaceships, 
                                                                            level.maxEnemiesOnScreen, gameTime, level);
            
            EnemyManipulation.MoveAndShootEnemies(ref gamezone, ref allSpaceships, gameTime, ref score, level, ref isRunning);

            UI.PrintScreenOfGamezone(gamezone);
            UI.PrintShortInfoAboutSpaceShip(gamezone, hero, score);
            
            Thread.Sleep(DELAY);

            gameTime++;;

        } while (isRunning);

        Console.CursorVisible = false;
    }
}