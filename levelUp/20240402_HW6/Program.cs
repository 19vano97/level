// See https://aka.ms/new-console-template for more information
using System.Text;
#region Encoding/Decoding
    string text = "Hello World!";

    byte[] byteArray = Encoding.UTF8.GetBytes(text);

    byte mask = 0b01001001;
    byte[] byteNewGen = new byte[text.Length];


    for (int i = 0; i < text.Length; i++)
    {
        byteNewGen[i] = (byte)(mask ^ byteArray[i]);
    }

    string resEncoded = Encoding.UTF8.GetString(byteNewGen);
    System.Console.WriteLine(resEncoded);

    byte[] byteDecoded = new byte[text.Length];

    for (int i = 0; i < text.Length; i++)
    {
        byteDecoded [i] = (byte)(mask ^ byteNewGen[i]);
    }
    string resDecoded = Encoding.UTF8.GetString(byteDecoded );
    System.Console.WriteLine(resDecoded);
#endregion

#region counting0and1

    System.Console.Write("firstArg = ");
    int firstArg = int.Parse(Console.ReadLine());


    int zeroCounter = 0;
    int oneCounter = 0;

    string firstArgString = Convert.ToString(firstArg, 2);


    for (int i = 0; i < firstArgString.Length; i++)
    {
        if (firstArgString[i] == '0')
        {
            zeroCounter++;
        }
        else
        {
            oneCounter++;
        }
    }

    System.Console.WriteLine("Byte = {0}", firstArgString);
    System.Console.WriteLine("ZeroCounter = {0}", zeroCounter);
    System.Console.WriteLine("OneCounter = {0}", oneCounter);

#endregion



