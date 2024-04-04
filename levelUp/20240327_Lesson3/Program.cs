// See https://aka.ms/new-console-template for more information
using System;
using System.Security.Cryptography.X509Certificates;

class lesson3
{
    static void Main(string[] args)
    {
        //Console.WriteLine(uint.MaxValue);

        #region UINT

        //uint k = 0; // there is transitions, therefore it will take more time/resorces to work, because of Uint = int

        //uint k1 = 0u; //takes less resources to work with since, there is no transitionsbecause of Uint = Uint (number with U-ending)

        #endregion

        #region ConvertByteToString

        // byte x = byte.MinValue;
        // while (x < byte.MaxValue)
        // {
        //    string sOut2 = Convert.ToString(x, 2); //converting binary to string
        //    string sOut8 = Convert.ToString(x, 8);
        //    string sOut16 = Convert.ToString(x, 16);

        //    Console.WriteLine("{0,3} - {1,8} - {2,12} - {3,16}", x, sOut2, sOut8, sOut16); //coma and number adds space  ex "    0 -            0"
        //    x++;
        // }

        #endregion

        #region float

        // float f1 = 0.999999f;
        // float f2 = 1.0f;

        // if (f1==f2)
        // {
        //     Console.WriteLine("True");
        // }
        // else
        // {
        //     Console.WriteLine("False");
        // }

        // float eps = 0.0001f;

        // if (Math.Abs(f1-f2) <= eps) //module
        // {
        //     System.Console.WriteLine("true");
        // }
        // else
        // {
        //     System.Console.WriteLine("false");
        // }


        // double d1 = 0.999999;


        #endregion

        #region bool
            //and: &
            //and: &&

            //or: | complete form
            //or: || short form if the first parameter is true, no sence to go to the next form

            //not: !

            // double a = 10.5;
            // double b = 20.9;

            // System.Console.Write("x=");

            // double x = double.Parse(Console.ReadLine());

            // bool range = a < x && x < b;

            // if (a < x && x < b)
            // {
            //     System.Console.WriteLine("True");
            // }
            // else
            // {
            //     System.Console.WriteLine("false");
            // }

            // if (!range)
            // {
            //     System.Console.WriteLine("true1");
            // }
            // else
            // {
            //     System.Console.WriteLine("false1");
            // }

            // if (x < a | x > b)
            // {
            //     System.Console.WriteLine("true2");
            // }
            // else
            // {
            //     System.Console.WriteLine("false2");
            // }

        // System.Console.WriteLine("AND");
        
        // {
        //     System.Console.WriteLine("f1(false) & f2 (false)");
        //     bool res1 = f1(false) & f2 (false);

        //     System.Console.WriteLine("f1(false) & f2 (true)");
        //     bool res2 = f1(false) & f2 (true);

        //     System.Console.WriteLine("f1(true) & f2 (false)");
        //     bool res3 = f1(true) & f2 (false);

        //     System.Console.WriteLine("f1(true) & f2 (true)");
        //     bool res4 = f1(true) & f2 (true);
        // }

        // {
        //     System.Console.WriteLine("f1(false) && f2 (false)");
        //     bool res1 = f1(false) && f2 (false);

        //     System.Console.WriteLine("f1(false) && f2 (true)");
        //     bool res2 = f1(false) && f2 (true);

        //     System.Console.WriteLine("f1(true) && f2 (false)");
        //     bool res3 = f1(true) && f2 (false);

        //     System.Console.WriteLine("f1(true) && f2 (true)");
        //     bool res4 = f1(true) && f2 (true);
        // }

        //         System.Console.WriteLine("OR");
        //         Console.ForegroundColor = ConsoleColor.DarkGreen;
        
        // {
        //     System.Console.WriteLine("f1(false) | f2 (false)");
        //     bool res1 = f1(false) | f2 (false);

        //     System.Console.WriteLine("f1(false) | f2 (true)");
        //     bool res2 = f1(false) | f2 (true);

        //     System.Console.WriteLine("f1(true) | f2 (false)");
        //     bool res3 = f1(true) | f2 (false);

        //     System.Console.WriteLine("f1(true) | f2 (true)");
        //     bool res4 = f1(true) | f2 (true);
        // }

        // {
        //     System.Console.WriteLine("f1(false) || f2 (false)");
        //     bool res1 = f1(false) || f2 (false);

        //     System.Console.WriteLine("f1(false) || f2 (true)");
        //     bool res2 = f1(false) || f2 (true);

        //     System.Console.WriteLine("f1(true) || f2 (false)");
        //     bool res3 = f1(true) || f2 (false);

        //     System.Console.WriteLine("f1(true) || f2 (true)");
        //     bool res4 = f1(true) || f2 (true);
        // }

        #endregion
    
        #region char
            //char exists to store ONE symbol, c# one symbol = 2 byte (because of Unicode)
            char ch1 = 'a';
            System.Console.WriteLine($"ch1={ch1}");

            char ch2 = 'ç';
            System.Console.WriteLine($"ch2={ch2}");

        #endregion

    }
    // public static bool f1(bool flag)
    // {
    //     System.Console.WriteLine("f1({0})", flag);
    //     return flag;
    // }

    //     public static bool f2(bool flag)
    // {
    //     System.Console.WriteLine("f2({0})", flag);
    //     return flag;
    // }
}

