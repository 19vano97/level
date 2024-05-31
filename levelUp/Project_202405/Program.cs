using Project_202405;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Clear();
        int[,] gameZone = BL.InitializeGameZone();

        


        Console.Clear();
        ConsoleKey key;
        int x = Console.WindowWidth /2;
        int y = Console.WindowHeight;

        Console.CursorVisible = false; 

        Console.SetCursorPosition(x, y);
        System.Console.Write(UI.PrintCharOfSpaceship());      

        do
        {
            key = Console.ReadKey(true).Key;
            Console.SetCursorPosition(x, y);
            Console.Write(' ');

            // Task.Run(() => 
            // {
            //     BL.RenderStars(gameZone);
            // });

            // Console.KeyAvailable

            switch (key)
            {
                case ConsoleKey.UpArrow:
                    y = BL.MoveSpaceship(SpaceshiptMovement.Up, x, y);
                    break;
                case ConsoleKey.DownArrow:
                    y = BL.MoveSpaceship(SpaceshiptMovement.Down, x, y);
                    break;
                case ConsoleKey.LeftArrow:
                    x = BL.MoveSpaceship(SpaceshiptMovement.Left, x, y);
                    break;
                case ConsoleKey.RightArrow:
                    x = BL.MoveSpaceship(SpaceshiptMovement.Right, x, y);
                    break;
                case ConsoleKey.Spacebar:
                    BL.ShootBlaster(BL.GetSpaceShipPosition(x, y)); 
                    break;
                default:
                    break;
            }  

            Console.SetCursorPosition(x, y);
            Console.Write(UI.PrintCharOfSpaceship());
            Thread.Sleep(50);
            
        } while (key != ConsoleKey.Escape);     

        Console.CursorVisible = false;
    }

    
}