// See https://aka.ms/new-console-template for more information
using System;
using System.Security.Cryptography.X509Certificates;
using System.Numerics;

namespace hw2
{
    class Program
    {
        public static void Main(string[] args)
        {
            #region mulTable
                // char cTopLeft = '┏';
                // char cBottomRight = '┛';
                // char cBottomLeft = '┗';
                // char cTopRight = '┓';
                // char cHorizontal = '━';
                // char cVertical = '┃';

                // for (int i = 0; i < 100; i = i + 24)
                // {
                //     System.Console.Write($"{cTopLeft}");
                    
                //     for (int y = 0; y < 20; y++)
                //     {
                //         System.Console.Write($"{cHorizontal}");
                //     }

                //     System.Console.Write($"{cTopRight}");
                //     System.Console.CursorLeft = i;
                // }

                // System.Console.WriteLine();

                // for (int i = 1; i <= 10; i++)
                // {
                //     System.Console.CursorLeft = 0;
                //     System.Console.Write($"{cVertical}");
                    
                //     System.Console.CursorLeft = 6;
                //     System.Console.Write($"2 + {i} = " + 2 * i);

                //     System.Console.CursorLeft = 21;
                //     System.Console.Write($"{cVertical}");

                //     System.Console.CursorLeft = 24;
                //     System.Console.Write($"{cVertical}");

                //     System.Console.CursorLeft = 30;
                //     System.Console.Write($"3 + {i} = " + 3 * i);

                //     System.Console.CursorLeft = 45;
                //     System.Console.Write($"{cVertical}");

                //     System.Console.CursorLeft = 48;
                //     System.Console.Write($"{cVertical}");

                //     System.Console.CursorLeft = 54;
                //     System.Console.Write($"4 + {i} = " + 4 * i);

                //     System.Console.CursorLeft = 69;
                //     System.Console.Write($"{cVertical}");

                //     System.Console.CursorLeft = 72;
                //     System.Console.Write($"{cVertical}");

                //     System.Console.CursorLeft = 78;
                //     System.Console.Write($"5 + {i} = " + 5 * i);

                //     System.Console.CursorLeft = 93;
                //     System.Console.Write($"{cVertical}");

                //     System.Console.WriteLine();
                // }

                // for (int i = 0; i < 100; i = i + 24)
                // {
                //     //System.Console.CursorLeft = i;
                //     System.Console.Write($"{cBottomLeft}");
                //     for (int y = 0; y < 20; y++)
                //     {
                //         System.Console.Write($"{cHorizontal}");
                //     }
                //     System.Console.Write($"{cBottomRight}");
                //     System.Console.CursorLeft = i;
                // }

                // System.Console.WriteLine();
                // System.Console.WriteLine();
                // System.Console.WriteLine();


                // for (int i = 0; i < 100; i = i + 24)
                // {
                //     //System.Console.CursorLeft = i;
                //     System.Console.Write($"{cTopLeft}");
                //     for (int y = 0; y < 20; y++)
                //     {
                //         System.Console.Write($"{cHorizontal}");
                //     }
                //     System.Console.Write($"{cTopRight}");
                //     System.Console.CursorLeft = i;
                // }

                // System.Console.WriteLine();

                // for (int i = 1; i <= 10; i++)
                // {
                //     System.Console.CursorLeft = 0;
                //     System.Console.Write($"{cVertical}");
                    
                //     System.Console.CursorLeft = 6;
                //     System.Console.Write($"6 + {i} = " + 6 * i);

                //     System.Console.CursorLeft = 21;
                //     System.Console.Write($"{cVertical}");

                //     System.Console.CursorLeft = 24;
                //     System.Console.Write($"{cVertical}");

                //     System.Console.CursorLeft = 30;
                //     System.Console.Write($"7 + {i} = " + 7 * i);

                //     System.Console.CursorLeft = 45;
                //     System.Console.Write($"{cVertical}");

                //     System.Console.CursorLeft = 48;
                //     System.Console.Write($"{cVertical}");

                //     System.Console.CursorLeft = 54;
                //     System.Console.Write($"8 + {i} = " + 8 * i);

                //     System.Console.CursorLeft = 69;
                //     System.Console.Write($"{cVertical}");

                //     System.Console.CursorLeft = 72;
                //     System.Console.Write($"{cVertical}");

                //     System.Console.CursorLeft = 78;
                //     System.Console.Write($"9 + {i} = " + 9 * i);

                //     System.Console.CursorLeft = 93;
                //     System.Console.Write($"{cVertical}");

                //     System.Console.WriteLine();
                // }

                // for (int i = 0; i < 100; i = i + 24)
                // {
                //     System.Console.Write($"{cBottomLeft}");
                //     for (int y = 0; y < 20; y++)
                //     {
                //         System.Console.Write($"{cHorizontal}");
                //     }
                //     System.Console.Write($"{cBottomRight}");
                //     System.Console.CursorLeft = i;
                // }


                // System.Console.WriteLine();
            #endregion

            #region minMaxValues

                System.Console.Write("valDouble1=");
                double valDouble1 = double.Parse(Console.ReadLine());
           
                System.Console.Write("valDouble2=");
                double valDouble2 = double.Parse(Console.ReadLine());

                System.Console.Write("valDouble3=");
                double valDouble3 = double.Parse(Console.ReadLine());

                System.Console.Write("valDouble4=");
                double valDouble4 = double.Parse(Console.ReadLine());

                System.Console.Write("valDouble5=");
                double valDouble5 = double.Parse(Console.ReadLine());

                double minDouble1 = double.MaxValue,
                       minDouble2 = double.MaxValue,
                       maxDouble1 = double.MinValue,
                       maxDouble2 = double.MinValue;

                System.Console.WriteLine();

                #region minMaxX2

                    if (valDouble1 < valDouble2)
                    {
                        minDouble1 = valDouble1;
                        minDouble2 = valDouble1;
                        maxDouble1 = valDouble2;
                        maxDouble2 = valDouble2;
                    }
                    else
                    {
                        minDouble1 = valDouble2;
                        minDouble2 = valDouble2;
                        maxDouble1 = valDouble1;
                        maxDouble2 = valDouble2;
                    }

                    if (valDouble3 < minDouble1)
                    {
                        minDouble2 = minDouble1;
                        minDouble1 = valDouble3;
                    }
                    else if (valDouble3 < minDouble2)
                    {
                        minDouble2 = valDouble3;
                    }

                    if (valDouble3 > maxDouble1)
                    {
                        maxDouble2 = maxDouble1;
                        maxDouble1 = valDouble3;
                    }
                    else if (valDouble3 > maxDouble2)
                    {
                        maxDouble2 = valDouble3;
                    }

                    if (valDouble4 < minDouble1)
                    {
                        minDouble2 = minDouble1;
                        minDouble1 = valDouble4;
                    }
                    else if (valDouble4 < minDouble2)
                    {
                        minDouble2 = valDouble4;
                    }

                    if (valDouble4 > maxDouble1)
                    {
                        maxDouble2 = maxDouble1;
                        maxDouble1 = valDouble4;
                    }
                    else if (valDouble4 > maxDouble2)
                    {
                        maxDouble2 = valDouble4;
                    }
                    
                    if (valDouble5 < minDouble1)
                    {
                        minDouble2 = minDouble1;
                        minDouble1 = valDouble5;
                    }
                    else if (valDouble5 < minDouble2)
                    {
                        minDouble2 = valDouble5;
                    }

                    if (valDouble5 > maxDouble1)
                    {
                        maxDouble2 = maxDouble1;
                        maxDouble1 = valDouble5;
                    }
                    else if (valDouble5 > maxDouble2)
                    {
                        maxDouble2 = valDouble5;
                    }
                    



                    System.Console.WriteLine("minDouble1 = {0}\nminDouble2 = {1}\nmaxDouble1 = {2}\nmaxDouble2 = {3}", minDouble1, minDouble2, maxDouble1, maxDouble2);
                    
                #endregion
                // double[] arrayValD = {valDouble1, valDouble2, valDouble3, valDouble4, valDouble5};
                // double max = double.MinValue;

                // foreach (double item in arrayValD)
                // {
                //     if (item>max)
                //     {
                //         max = item;
                //     }
                // }

                // System.Console.WriteLine(max);
 
                System.Console.WriteLine(Math.Min(
                    Math.Min(
                        Math.Min(valDouble1, valDouble2), 
                        Math.Min(valDouble3, valDouble4)), 
                    valDouble5));

                System.Console.WriteLine(Math.Max(
                    Math.Max(
                        Math.Max(valDouble1, valDouble2), 
                        Math.Max(valDouble3, valDouble4)), 
                    valDouble5));
                
            #endregion

        }
        //public static double Min (double valDouble1, double valDouble2);
    }
}
