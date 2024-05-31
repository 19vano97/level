using Galaga;

internal class Program
{
    const int DELAY = 50;

    private static void Main(string[] args)
    {
        Console.Clear();

        //TODO Create Menu

        //TODO Select level

        //TODO Create Scoreboard

        char[,] gamezone = GamezoneManipulations.InitGamezone();

        Spaceship[] allSpaceships = SpaceshipManipulation.InitSpaceshipArray(gamezone);
        Spaceship hero = allSpaceships[0];
        
        allSpaceships = SpaceshipManipulation.AddSpaceshipToArray(ref allSpaceships, 
                                                                    SpaceshipManipulation.InitEnemy(gamezone));

        UI.SetDefaultPosition(gamezone);

        int x = UI.GetDefaultPosition(gamezone).x;
        int y = UI.GetDefaultPosition(gamezone).y;
        bool isRunning = true;

        SpaceshipMovement direction = SpaceshipMovement.None;

        //TODO enemy automove
        
        //TODO enemy autoshoot

        //TODO Enemies autogenerator (max enemies on screen)

        Console.CursorVisible = false;

        gamezone = UI.PrintEnemy(ref gamezone, allSpaceships[1]);   // TEMP enemy

        ulong gateTime = 0;

        ConsoleKey key;

        do
        {
            Console.SetCursorPosition(x, y);
            Console.Write(' ');

            #region SpaceshipMove

                if (Console.KeyAvailable)
                {
                    key = Console.ReadKey().Key;
    
                    switch (key)
                    {
                        case ConsoleKey.UpArrow:
                            direction = SpaceshipMovement.Up;
                            break;
                        case ConsoleKey.DownArrow:
                            direction = SpaceshipMovement.Down;
                            break;
                        case ConsoleKey.LeftArrow:
                            direction = SpaceshipMovement.Left;
                            break;
                        case ConsoleKey.RightArrow:
                            direction = SpaceshipMovement.Right;
                            break;
                        case ConsoleKey.Spacebar:
                            gamezone = AttackBlusterUI.ShootBluster(ref gamezone, hero, ref allSpaceships, false);
                            break;
                        case ConsoleKey.Escape:
                            isRunning = false;
                            break;
                        default:
                            break;
                    }
                }
    
                if (gateTime % hero.spaceshipSpeed == 0L)
                {
                    switch (direction)
                    {
                        //TODO make function of direction
        
                        case SpaceshipMovement.Up:
                            int[] oldPosition = BL.GetOldPosition(x, y);
                            y--;
                            hero.spaceshipCoodinates.y = y;
                            gamezone = GamezoneManipulations.UpdatePositionOnGamezone(ref gamezone, hero, false, oldPosition);
                            break;
                        case SpaceshipMovement.Down:
                            oldPosition = BL.GetOldPosition(x, y);
                            y++;
                            hero.spaceshipCoodinates.y = y;
                            gamezone = GamezoneManipulations.UpdatePositionOnGamezone(ref gamezone, hero, false, oldPosition);
                            break;
                        case SpaceshipMovement.Left:
                            oldPosition = BL.GetOldPosition(x, y);
                            x--;
                            hero.spaceshipCoodinates.x = x;
                            gamezone = GamezoneManipulations.UpdatePositionOnGamezone(ref gamezone, hero, false, oldPosition);
                            break;
                        case SpaceshipMovement.Right:
                            oldPosition = BL.GetOldPosition(x, y);
                            x++;
                            hero.spaceshipCoodinates.x = x;
                            gamezone = GamezoneManipulations.UpdatePositionOnGamezone(ref gamezone, hero, false, oldPosition);
                            break;
                        default:
                            break;
                    }
    
                }
            #endregion

            //Temp HP
            Console.SetCursorPosition(gamezone.GetLength(0) - 15, gamezone.GetLength(1) - 3);
            UI.PrintShortInfoAboutSpaceShip(hero);

            // Console.SetCursorPosition(gamezone.GetLength(0) - 15, gamezone.GetLength(1) - 2);
            // UI.PrintShortInfoAboutSpaceShip(allSpaceships[1]);

            Console.SetCursorPosition(x, y);
            System.Console.Write(hero.symbol);

            Thread.Sleep(DELAY);

            gateTime++;        

        } while (isRunning);

        Console.CursorVisible = false;
    }
}