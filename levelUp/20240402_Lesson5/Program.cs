// See https://aka.ms/new-console-template for more information
using System.Collections;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

Console.WriteLine("Hello, World!");

string src = Console.ReadLine();

switch (src)
{
    case "fgege":
        System.Console.WriteLine("1");
        break;

    case "test":
        case "test1":
        System.Console.WriteLine("2");
        break;    
    default:
        System.Console.WriteLine("Wrong");
        break;
}

//precondition

int p = 0;

while (p <10 ) //true/false
{
    System.Console.Write("{0}", p);
    p++;
}

System.Console.WriteLine();
//aftercondition

int p1 = 10-1;

do
{
    System.Console.Write("{0}", p1);
    p1--;
} while (p1 >= 0);

System.Console.Write("Enter quantity: ");
int n = int.Parse(Console.ReadLine());

uint sum = 0;

while (n > 0)
{
    System.Console.Write("Enter numbers: ");
    int numbers = int.Parse(Console.ReadLine());

    if (numbers <  0)
    {
        System.Console.WriteLine("enter one more time");
        //break; - exit from cycle
        continue; //trying to follow to confition numbers > 0 (goes to beggining of the cycle)
    }

    sum = (uint)(numbers + sum);

    --n;
}

System.Console.WriteLine(sum);