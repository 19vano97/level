namespace Galaga;

public class BL
{

    public static int[] GetPositionOfSpaceship(int x, int y)
    {
        int[] position = new int[] {x, y};

        return position;
    }

    public static int GetRandomInt(int minValue = 0, int maxValue = int.MaxValue)
    {
        Random rnd = new Random();

        int value = rnd.Next(minValue, maxValue);

        return value;
    }


    public static int[] GetOldPosition(int x, int y)
    {
        int[] position = new int[] {x, y};

        return position;
    }



}
