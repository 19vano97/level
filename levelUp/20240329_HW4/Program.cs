// See https://aka.ms/new-console-template for more information
using System.Formats.Asn1;

internal class ProgramHW3
{
    private static void Main(string[] args)
    {
        #region compering2stings

        Console.WriteLine("String 1 = ");
        string s1 = Console.ReadLine();

        Console.WriteLine("String 2 = ");
        string s2 = Console.ReadLine();

        if (s1.Length < s2.Length)
        {
            Console.WriteLine("s2 is greater than s1");
        }
        else
        {
            Console.WriteLine("s1 is greater than s2");
        }

        int indexOfComparisonFinal = 0,
            length = 0;

        if (s1.Length <= s2.Length)
        {
            length = s1.Length;
            indexOfComparisonFinal = length - s2.Length;
        }
        else
        {
            length = s2.Length;
            indexOfComparisonFinal = length - s1.Length;
        }

        int indexOfComparison1 = 0,
            indexOfComparison2 = 0;

        for (int i = 0; i < length; i++)
        {
            if (s1[i].CompareTo(s2[i]) > 0)
            {
                Console.WriteLine("s1[{0}]: {1} > s2[{2}]: {3}", i, s1[i], i, s2[i]);
                indexOfComparison1++;
            }
            else if (s1[i].CompareTo(s2[i]) < 0)
            {
                Console.WriteLine("s1[{0}]: {1} < s2[{2}]: {3}", i, s1[i], i, s2[i]);
                --indexOfComparison2;
            }
            else if (s1[i].CompareTo(s2[i]) == 0)
            {
                Console.WriteLine("s1[{0}]: {1} = s2[{2}]: {3}", i, s1[i], i, s2[i]);
            }
        }

        indexOfComparisonFinal = indexOfComparisonFinal + indexOfComparison1 + indexOfComparison2;

        if (s1.Length < s2.Length)
        {
            System.Console.WriteLine("Totan index of comparation {0}\nString1 - index of comparation: {1}\nString2 - index of comparation: {2}\nString 2 wins", indexOfComparisonFinal, indexOfComparison1, indexOfComparison2);
        }
        else if (s1.Length > s2.Length)
        {
            System.Console.WriteLine("Totan index of comparation {0}\nString1 - index of comparation: {1}\nString2 - index of comparation: {2}\nString 1 wins", indexOfComparisonFinal, indexOfComparison1, indexOfComparison2);
        }
        else if (s1.Length == s2.Length & indexOfComparison1 < indexOfComparison2)
        {
            System.Console.WriteLine("Totan index of comparation {0}\nString1 - index of comparation: {1}\nString2 - index of comparation: {2}\nString 2 wins", indexOfComparisonFinal, indexOfComparison1, indexOfComparison2);
        }
        else if (s1.Length == s2.Length & indexOfComparison1 > indexOfComparison2)
        {
            System.Console.WriteLine("Totan index of comparation {0}\nString1 - index of comparation: {1}\nString2 - index of comparation: {2}\nString 1 wins", indexOfComparisonFinal, indexOfComparison1, indexOfComparison2);
        }
        else if (s1.Length == s2.Length & indexOfComparison1 == 0 & indexOfComparison2 == 0)
        {
            System.Console.WriteLine("Totan index of comparation {0}\nString1 - index of comparation: {1}\nString2 - index of comparation: {2}\nString 1 and String 2 are equal", indexOfComparisonFinal, indexOfComparison1, indexOfComparison2);
        }

        #endregion

        #region equationValidator
            
        char[] signs = ['+', '-', '/', '*', '='],
               roundBrackets = ['(', ')'],
               squareBrackets = ['[', ']'],
               braces = ['{', '}'];

        //System.Console.WriteLine("Enter your equation:");
        //string equation = Console.ReadLine();
        
        string equation = "a * b - (1 + [c - d]) + [(e + f)] * ([g + h] + (j + k))";

        string equationWithoutSpace = equation.Replace(" ", "");
        System.Console.WriteLine("New equation without white spaces: {0}", equationWithoutSpace);

        int indexRoundBracketsOpen = 0,
            indexRoundBracketsClose = 0,
            countRoundBrackets = 0,
            indexSquareBracketsOpen = 0,
            indexSquareBracketsClose = 0,
            countSquareBrackets = 0,
            indexBracesOpen = 0,
            indexBracesClose = 0,
            countBraces = 0,
            errorCounterBrackets = 0,
            errorCounterSigns = 0;

        for (int i = 0; i < equationWithoutSpace.Length; i++)
        {
            if (equationWithoutSpace[i] == roundBrackets[0])
            {
                indexRoundBracketsOpen = i;
                countRoundBrackets++;
            }
            else if (equationWithoutSpace[i] == roundBrackets[1])
            {
                indexRoundBracketsClose = i;
                countRoundBrackets--;
            }
            else if (equationWithoutSpace[i] == squareBrackets[0])
            {
                indexSquareBracketsOpen = i;
                countSquareBrackets++;
            }
            else if (equationWithoutSpace[i] == squareBrackets[1])
            {
                indexSquareBracketsClose = i;
                countSquareBrackets--;
            }
            else if (equationWithoutSpace[i] == braces[0])
            {
                indexBracesOpen = i;
                countBraces++;
            }
            else if (equationWithoutSpace[i] == braces[1])
            {
                indexBracesClose = i;
                countBraces--;
            }

            if (equationWithoutSpace[i] == signs[0]
                | equationWithoutSpace[i] == signs[1]
                | equationWithoutSpace[i] == signs[2]
                | equationWithoutSpace[i] == signs[3]
                | equationWithoutSpace[i] == signs[4])
            {
                if (i == 0)
                {
                    System.Console.WriteLine("ERROR. Sign: Symbol {0}, Index {1}", equationWithoutSpace[i], i);
                    errorCounterSigns++;
                }
                else if (i == (equationWithoutSpace.Length - 1))
                {
                    System.Console.WriteLine("ERROR. Sign: Symbol {0}, Index {1}", equationWithoutSpace[i], i);
                    errorCounterSigns++;
                }
                else if (equationWithoutSpace[i-1] == signs [0] || equationWithoutSpace[i+1] == signs[0]
                    || equationWithoutSpace [i-1] == signs[1] || equationWithoutSpace [i+1] == signs[1]
                    || equationWithoutSpace [i-1] == signs[2] || equationWithoutSpace [i+1] == signs[2]
                    || equationWithoutSpace [i-1] == signs[3] || equationWithoutSpace [i+1] == signs[3]
                    || equationWithoutSpace [i-1] == signs[4] || equationWithoutSpace [i+1] == signs[4])
                {
                    System.Console.WriteLine("ERROR. Sign: Symbol {0}, Index {1}", equationWithoutSpace[i], i);
                    errorCounterSigns++;
                }
            }

            if (equationWithoutSpace[i] == roundBrackets[0]
               | equationWithoutSpace[i] == roundBrackets[1]
               | equationWithoutSpace[i] == squareBrackets[0]
               | equationWithoutSpace[i] == squareBrackets[1]
               | equationWithoutSpace[i] == braces[0]
               | equationWithoutSpace[i] == braces[1])
            {
                if ((indexRoundBracketsOpen < indexRoundBracketsClose //  [(])
                        & indexRoundBracketsOpen > indexSquareBracketsOpen
                        & indexRoundBracketsOpen < indexSquareBracketsClose
                        & indexSquareBracketsClose < indexRoundBracketsClose
                        & indexSquareBracketsOpen < indexSquareBracketsClose)
                    | (indexRoundBracketsOpen < indexRoundBracketsClose // ([)]
                        & indexRoundBracketsOpen < indexSquareBracketsOpen
                        & indexRoundBracketsClose > indexSquareBracketsOpen
                        & indexRoundBracketsClose < indexSquareBracketsClose
                        & indexSquareBracketsOpen < indexSquareBracketsClose)
                    | (indexBracesOpen < indexBracesClose //  [{]}
                        & indexBracesOpen > indexSquareBracketsOpen
                        & indexBracesOpen < indexSquareBracketsClose
                        & indexSquareBracketsClose < indexBracesClose
                        & indexSquareBracketsOpen < indexSquareBracketsClose)
                    | (indexBracesOpen < indexBracesClose // {[}]
                        & indexBracesOpen < indexSquareBracketsOpen
                        & indexBracesClose > indexSquareBracketsOpen
                        & indexBracesClose < indexSquareBracketsClose
                        & indexSquareBracketsOpen < indexSquareBracketsClose)
                    | (indexRoundBracketsOpen < indexRoundBracketsClose //  {(})
                        & indexRoundBracketsOpen > indexBracesOpen
                        & indexRoundBracketsOpen < indexBracesClose
                        & indexSquareBracketsClose < indexBracesClose
                        & indexBracesOpen < indexBracesClose)
                    | (indexRoundBracketsOpen < indexRoundBracketsClose // ({)}
                        & indexRoundBracketsOpen < indexBracesOpen
                        & indexRoundBracketsClose > indexBracesOpen
                        & indexRoundBracketsClose < indexBracesClose
                        & indexBracesOpen < indexBracesClose))
                {
                    System.Console.WriteLine("ERROR. Brackets: Symbol {0}, Index {1}", equationWithoutSpace[i], i);
                    errorCounterBrackets++;
                }
            }

            if ((countRoundBrackets != 0 | countSquareBrackets != 0 | errorCounterBrackets != 0) & (equationWithoutSpace.Length - 1) == i)
            {
                System.Console.WriteLine("ERROR - Brackets. Check your equation again. Score: {0}", errorCounterBrackets);
            }
            
            if (errorCounterSigns != 0 & (equationWithoutSpace.Length - 1) == i)
            {
                System.Console.WriteLine("ERROR - Signs. Check your equation again. Score: {0}", errorCounterSigns);
            }
            
            if (countRoundBrackets == 0 & countSquareBrackets == 0 & errorCounterBrackets == 0 & errorCounterSigns == 0 & (equationWithoutSpace.Length - 1) == i)
            {
                System.Console.WriteLine("Your equation withoutSpaces is valid!");
            }

        }
        #endregion


    }
}