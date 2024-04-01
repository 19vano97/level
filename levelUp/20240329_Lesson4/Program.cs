// See https://aka.ms/new-console-template for more information
using System.Net.WebSockets;

string s1 = "abc aabb";
//string s2 = null;

System.Console.WriteLine(s1);

//s1.Length - number of symbols in the s1

// for (int i = 0; i < s1.Length; i++)
// {
//     System.Console.WriteLine("s1[{0}]: {1}", i, s1[i]);
// }
// s1[0]: a
// s1[1]: b
// s1[2]: c

string s1Copy = s1;

System.Console.WriteLine("s1 = {0}", s1);

s1Copy = s1Copy.Remove(3, 2);

Console.ForegroundColor = ConsoleColor.DarkGreen;
System.Console.WriteLine("s1Copy = {0}", s1Copy);

Console.ForegroundColor = ConsoleColor.Black;

string s2 = string.Concat(s1Copy, s1);
int s3 = string.Compare(s1, s1Copy);
string s4 = s1Copy + s1;

int ab = 6;
double abD = 7.5;
float abF = 6.43f;
string s5 = string.Format("{0} - {1} - {2}", ab, abD, abF);

string s6 = s1.Replace("ab", "4564563453");

string s7 = s1.Insert(4, "test");
string s8 = s1.ToUpper();
string s9 = s8.ToLower();

if (s1.CompareTo(s7) > 0)
{
    System.Console.WriteLine($"{s1} > {s7}");
}
else
{
    System.Console.WriteLine($"{s1} < {s7}");
}

int s10 = string.Compare(s7, s1);

System.Console.WriteLine(s2);
System.Console.WriteLine(s3);
System.Console.WriteLine(s4);
System.Console.WriteLine(s5);
System.Console.WriteLine(s6);
System.Console.WriteLine(s7);
System.Console.WriteLine(s8);
System.Console.WriteLine(s9);
System.Console.WriteLine(s10);

// string s3 = s1.Replace('b', 'V');
// System.Console.WriteLine(s3);
// //aVc

// s1 = s1.Replace('a', 'A');
// System.Console.WriteLine(s1);
// //Abc