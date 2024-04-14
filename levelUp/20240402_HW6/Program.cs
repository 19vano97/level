// See https://aka.ms/new-console-template for more information
using System.Text;


internal class Program
{
    private static void Main(string[] args)
    {

        #region Encoding/Decoding

            string text = InputString();
    
            byte mask = InputByte("Enter a mask: ");
    
            string encodedText = EncodeByMask(mask, text);
    
            System.Console.WriteLine(encodedText);
    
            string decodedText = DecodeByMask(mask, encodedText);
    
            System.Console.WriteLine(decodedText);

        #endregion

        System.Console.WriteLine();

        #region counting0and1

            int number = InputIntNumber("firstArg");

            CountZeroAndOne(number);

        #endregion
    }

    

    public static int InputIntNumber(string varName)
    {
        System.Console.Write("Enter {0} = ", varName);
        int result = int.Parse(Console.ReadLine());

        return result;
    }

    public static string InputString()
    {
        System.Console.Write("Enter a text: ");
        string str = Console.ReadLine();

        return str;
    }

    public static byte InputByte(string message)
    {
        System.Console.WriteLine(message);
        // byte inputByte = byte.Parse(Console.ReadLine());
        byte inputByte = 0b01001001;

        return inputByte;
    }

    public static string EncodeByMask(byte maskDefault, string text)
    {
        byte[] byteArray = Encoding.UTF8.GetBytes(text);

        byte[] byteNewGen = new byte[text.Length];

        for (int i = 0; i < text.Length; i++)
        {
            byteNewGen[i] = (byte)(maskDefault ^ byteArray[i]);
        }

        string textEncoded = Encoding.UTF8.GetString(byteNewGen);

        return textEncoded;
    }

    public static string DecodeByMask(byte maskDefault, string textEncoded)
    {
        byte[] byteArray = Encoding.UTF8.GetBytes(textEncoded);

        byte[] byteDecoded = new byte[textEncoded.Length];

        for (int i = 0; i < textEncoded.Length; i++)
        {
            byteDecoded[i] = (byte)(maskDefault ^ byteArray[i]);
        }

        string textDecoded = Encoding.UTF8.GetString(byteDecoded);

        return textDecoded;
    }

    public static void CountZeroAndOne(int number)
    {
        int zeroCounter = 0;
        int oneCounter = 0;

        string numberString = Convert.ToString(number, 2);

        for (int i = 0; i < numberString.Length; i++)
        {
            if (numberString[i] == '0')
            {
                zeroCounter++;
            }
            else
            {
                oneCounter++;
            }
        }

        Console.WriteLine("Byte = {0}", numberString);
        Console.WriteLine("ZeroCounter = {0}", zeroCounter);
        Console.WriteLine("OneCounter = {0}", oneCounter);
    }
}