namespace Galaga;

public struct GameProperties
{
    public char[,] gamezone;
    public Spaceship[] allSpaceships;
    public ulong gameTime;
    public bool isGameOver;
    public GameLevelStructure level;
    public int score;
}
