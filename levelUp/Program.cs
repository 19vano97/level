// See https://aka.ms/new-console-template for more information

class Lesson1
{
    static void Main(string[] args)
    {
        //Console.ForegroundColor = ConsoleColor.Green; //font color green
        //Console.BackgroundColor = ConsoleColor.Red;

        //Console.CursorLeft = 20;

        //int a = 15;

        //Console.CursorTop = a;

        //Console.WriteLine("Hi");

        //Console.WriteLine();

        //Console.BackgroundColor = ConsoleColor.Black;
        //Console.ForegroundColor = ConsoleColor.Gray;


        //for (int i = 0; i < 10; i++)
        //{
        //    Console.WriteLine($"hi {i}"); //as on bash 
        //}

        #region Types

        //collapse and extend code

        Console.WriteLine($"Min value: {int.MinValue} \nMax value: {int.MaxValue}");
        Console.WriteLine("Min value : {0} \nMax value: {1}", int.MinValue, int.MaxValue); //Note: this way is abount not using "$" to execute the string. Just like in an array put numbers and params after

        //int outputText;

        //Console.WriteLine("Enter your age:");
        //string text = Console.ReadLine();
        ////Console.WriteLine("text: {0}", text);
        ////text = int.Parse(text); //exception
        ////Console.WriteLine(text);

        //if (int.TryParse(text, out outputText))
        //{
        //    Console.WriteLine("outputText: {0}", outputText);
        //}
        //else
        //{
        //    Console.WriteLine("Error");
        //}



        #endregion

        Console.WriteLine();
        Console.Write("Press any key...");
        Console.ReadKey();
    }
}

