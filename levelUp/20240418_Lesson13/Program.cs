internal class Program
{
    private static void Main(string[] args)
    {
        double arr;
    }

    public static void Init(double[] destination, int low, int max)
    {
        if (destination == null)
        {
            System.Console.WriteLine("empty");
            return;
        }

        Random rnd = new Random();

        for (int i = 0; i < destination.Length; i++)
        {
            destination[i] = rnd.Next(low * 100, max * 100 + 1) / 100.0;
        }
        
    }
}