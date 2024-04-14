// See https://aka.ms/new-console-template for more information
using System.Collections;

#region byteMul

    Console.Write("a = ");
    // int a = int.Parse(Console.ReadLine());
    int a = 127;
    
    Console.Write("b = ");
    // int b = int.Parse(Console.ReadLine());
    int b = 125;
    
    System.Console.WriteLine();
    
    int step = 0;
    double c = 0;
    
    for (int i = 0; i < int.MaxValue; i++)
    {
        
        c = a - Math.Pow(2,i);
        
        if (c < 0)
        {
            step = i - 1;
            System.Console.WriteLine("Step is {0}", step);
            break;
        }
    }

    for (int i = step; i >= 0; i--)
    {
        c = a - Math.Pow(2,i);
        
        System.Console.WriteLine("c = {0}, i = {1}", c, i);
    }
    
    int shiftedB = 0;
    double res = 0;
    
    for (int i = 0; i <= step; i++)
    {
        shiftedB = b << i;
        System.Console.WriteLine("Shitfted = {0}", shiftedB); 
        res = shiftedB;
        System.Console.WriteLine("resInCycle = {0}", res);
    }

    //res = res + Math.Pow(2, step+1) - 2;
    
    System.Console.WriteLine("(byte) a * b = {0}", (byte)a*b);
    
    System.Console.WriteLine("By byte: {0}", res);
    
    System.Console.WriteLine("Difference (byte)a*b - res = {0}", (byte)a * b - res);

#endregion

#region DayWeekMask
    // const byte DefMASK = 0b00000000;
    // const byte MonMASK = 0b00000001;
    // const byte TueMASK = 0b00000010;
    // const byte WedMASK = 0b00000100;
    // const byte ThuMASK = 0b00001000;
    // const byte FRIMASK = 0b00010000;
    // const byte SatMASK = 0b00100000;
    // const byte SunMASK = 0b01000000;
    // //const byte MASK_08 = 0b10000000;
    
    // byte flag = 0;
    
    // ConsoleKey key;
    
    // do
    // {
    //     key = Console.ReadKey().Key;
    //     System.Console.Write("Enter a week day: ");
    
    //     string weekDay = Console.ReadLine();
    //     string weekDaySmall = weekDay.ToLower();
    //     
            //switch (weekDaySmall)
    //     {
    //         case "monday":
    //             case "mon":
    //                 case "понеділок":
    //                 flag ^= MonMASK;
    //                 System.Console.WriteLine("flags: = {0, 10}, {1}", Convert.ToString(flag, 2), flag);
    //                 break;
    //         case "tuesday":
    //             case "tue":
    //                 case "вівторок":
    //                 flag ^= TueMASK;
    //                 System.Console.WriteLine("flags: = {0, 10}, {1}", Convert.ToString(flag, 2), flag);
    //                 break;
    //         case "wednesday":
    //             case "wed":
    //                 case "середа":
    //                 flag ^= WedMASK;
    //                 System.Console.WriteLine("flags: = {0, 10}, {1}", Convert.ToString(flag, 2), flag);
    //                 break;
    //         case "thursday":
    //             case "thu":
    //                 case "четвер":
    //                 flag ^= ThuMASK;
    //                 System.Console.WriteLine("flags: = {0, 10}, {1}", Convert.ToString(flag, 2), flag);
    //                 break;
    //         case "friday":
    //             case "fri":
    //                 case "пʼятниця":
    //                 flag ^= FRIMASK;
    //                 System.Console.WriteLine("flags: = {0, 10}, {1}", Convert.ToString(flag, 2), flag);
    //                 break;
    //         case "saturday":
    //             case "sat":
    //                 case "субота":
    //                 flag ^= SatMASK;
    //                 System.Console.WriteLine("flags: = {0, 10}, {1}", Convert.ToString(flag, 2), flag);
    //                 break;
    //         case "sunday":
    //             case "sun":
    //                 case "неділя":
    //                 flag ^= SunMASK;
    //                 System.Console.WriteLine("flags: = {0, 10}, {1}", Convert.ToString(flag, 2), flag);
    //                 break;
    //         default:
    //             System.Console.WriteLine("Wrong");
    //             break;
    //     }
    // } while (key != ConsoleKey.Escape);
#endregion