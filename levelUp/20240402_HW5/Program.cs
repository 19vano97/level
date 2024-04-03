// See https://aka.ms/new-console-template for more information

#region weekDays
//     System.Console.Write("Enter a week day: ");
//     string weekDay = Console.ReadLine();

//     string weekDaySmall = weekDay.ToLower();

//     switch (weekDaySmall)
//     {
//         case "monday":
//             case "mon":
//                 case "понеділок":
//                 System.Console.WriteLine("1");
//                 break;
//         case "tuesday":
//             case "tue":
//                 case "вівторок":
//                 System.Console.WriteLine("2");
//                 break;
//         case "wednesday":
//             case "wed":
//                 case "середа":
//                 System.Console.WriteLine("3");
//                 break;
//         case "thursday":
//             case "thu":
//                 case "четвер":
//                 System.Console.WriteLine("4");
//                 break;
//         case "friday":
//             case "fri":
//                 case "пʼятниця":
//                 System.Console.WriteLine("5");
//                 break;
//         case "saturday":
//             case "sat":
//                 case "субота":
//                 System.Console.WriteLine("6");
//                 break;
//         case "sunday":
//             case "sun":
//                 case "неділя":
//                 System.Console.WriteLine("7");
//                 break;
//         default:
//             System.Console.WriteLine("Wrong");
//             break;
// }
#endregion

#region switch

    System.Console.Write("Enter quantity: ");
    int n = int.Parse(Console.ReadLine());

    double minDouble1 = 0.0,
       minDouble2 = 0.0,
       maxDouble1 = 0.0,
       maxDouble2 = 0.0;

    for (int i = 0; i < n; i++)
    {
        System.Console.Write("Enter numbers{0}: ", i);
        double numbers = double.Parse(Console.ReadLine());
        System.Console.WriteLine();

        if (i == 0 & minDouble1 == 0)
        {
            minDouble1 = numbers;
            System.Console.WriteLine("minDouble1: {0}", minDouble1);
        }
        else if (i == 1 & minDouble2 == 0)
        {
            minDouble2 = numbers;
            System.Console.WriteLine("minDouble2: {0}", minDouble2);
        }
        else if (i == 2 & maxDouble1 == 0)
        {
            maxDouble1 = numbers;
            System.Console.WriteLine("maxDouble1: {0}", maxDouble1);
        }
        else if (i == 3 & maxDouble2 == 0)
        {
            maxDouble2 = numbers;
            System.Console.WriteLine("maxDouble2: {0}", maxDouble2);
        }

         if (minDouble1 > numbers)
            {
                minDouble1 = numbers;
            }
            else if (minDouble1 < numbers & numbers < minDouble2)
            {
                minDouble2 = maxDouble1;
                minDouble2 = numbers;
            }
            else if (minDouble1 < numbers & minDouble2 < numbers & maxDouble1 < numbers)
            {
                maxDouble2 = i;
            }
            else if (minDouble1 < numbers & minDouble2 < numbers & maxDouble1 < numbers & maxDouble2 < numbers)
            {
                maxDouble2 = maxDouble1;
                maxDouble1 = numbers;
            }

        // for (int y = 0; y < n; y++)
        // {
        //     if (minDouble1 > numbers)
        //     {
        //         minDouble1 = numbers;
        //     }
        //     else if (minDouble1 < numbers & numbers < minDouble2)
        //     {
        //         minDouble2 = numbers;
        //     }
        //     else if (minDouble1 < numbers & minDouble2 < numbers & maxDouble1 < numbers)
        //     {
        //         maxDouble1 = numbers;
        //     }
        //     else if (minDouble1 < numbers & minDouble2 < numbers & maxDouble1 < numbers & maxDouble2 < numbers)
        //     {
        //         maxDouble2 = numbers;
        //     }

        // }


        // else if (i == 0 & maxDouble1 == 0)
        // {
        //     maxDouble1 = numbers;
        //     System.Console.WriteLine("maxDouble1: {0}", maxDouble1);
        // }
        // else if (i == 0 & maxDouble2 == 0)
        // {
        //     maxDouble2 = numbers;
        //     System.Console.WriteLine("maxDouble2: {0}", maxDouble2);
        // }

        // if (i > 0 & minDouble1 < numbers & numbers < minDouble2 & numbers < maxDouble1 & numbers < maxDouble2)
        // {
        //     minDouble1 = numbers;
        //     System.Console.WriteLine("minDouble1: {0}", minDouble1);
        // }
        // else if (i > 0 & minDouble1 > numbers & numbers < minDouble2 & numbers < maxDouble1 & numbers < maxDouble2)
        // {
        //     minDouble2 = numbers;
        //     System.Console.WriteLine("minDouble2: {0}", minDouble2);
        // }
        // else if (i > 0 & minDouble1 > numbers & numbers > minDouble2 & numbers < maxDouble1 & numbers < maxDouble2)
        // {
        //     maxDouble1 = numbers;
        //     System.Console.WriteLine("maxDouble1: {0}", maxDouble1);
        // }
        // else if (i > 0 & minDouble1 > numbers & numbers > minDouble2 & numbers > maxDouble1 & numbers > maxDouble2)
        // {
        //     maxDouble2 = numbers;
        //     System.Console.WriteLine("maxDouble2: {0}", maxDouble2);
        // }
    }

    System.Console.WriteLine("minDouble1: {0}", minDouble1);
    System.Console.WriteLine("minDouble2: {0}", minDouble2);
    System.Console.WriteLine("maxDouble1: {0}", maxDouble1);
    System.Console.WriteLine("maxDouble2: {0}", maxDouble2);


    

#endregion
