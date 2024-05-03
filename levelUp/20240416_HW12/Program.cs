internal class Program
{
    private static void Main(string[] args)
    {
        #region isPalindrome

            System.Console.Write("Enter text: ");
            string input = Console.ReadLine();

            string prepareForAction = RemoveSpacesUpperCase(input);
    
            int i = prepareForAction.Length - 1;
    
            string[] resultByCharecter = new string[prepareForAction.Length];
    
            string palindrome = GetPalindromeByRec(prepareForAction, i, resultByCharecter);
    
            bool isPalindrome = CompareStrings(prepareForAction, palindrome);
            System.Console.WriteLine("isPalindrome: {0}", isPalindrome);

        #endregion

        System.Console.WriteLine();

        #region hanoyTowers

            
            // int a = 3;
            // int b = 2;
            // int c = 1;
            // //int numberOfVariables = 3-1;

            // int[] tower1 = new int[] {a, b, c};
            // int[] tower2 = new int[3];
            // int[] tower3 = new int[3];

            // Stack<int> tower11 = new Stack<int>(tower1);
            // Stack<int> tower12 = new Stack<int>();
            // tower12.Push(0);
            // Stack<int> tower13 = new Stack<int>();
            // tower13.Push(0);

            // // bool isSuccess = MoveInt(tower1, tower2, tower3, numberOfVariables);
            // bool isSuccess = MoveIntByStack(tower11, tower12, tower13);

        #endregion
    }

    public static string RemoveSpacesUpperCase(string str)
    {
        string strSmallLetter = str.ToLower();
        string strSmallLetterWithoutSpaces = strSmallLetter.Replace(" ", "");

        return strSmallLetterWithoutSpaces;
    }
    
    public static string GetPalindromeByRec(string message, int length, string[] resultByCharecter, int startPalindrome = 0)
    {
        resultByCharecter[startPalindrome] = Convert.ToString(message[length]);;

        if (length == 0 && startPalindrome == message.Length-1)
        {
            return message;
        }

        GetPalindromeByRec(message, length - 1, resultByCharecter, startPalindrome + 1);

        string result = String.Join("", resultByCharecter);

        return result;
    }

    public static bool CompareStrings(string str1, string str2)
    {
        bool result = false;

        if (str1.CompareTo(str2) == 0)
        {
            result = true;
        }

        return result;
    }

    // public static bool MoveInt(int[] tower1, int[] tower2, int[] tower3, 
    //                            int numberOfVariables, int stepTree = 0)
    // {
    //     bool res = false;

    //     // tower2[stepTree] = tower1[numberOfVariables];
    //     // System.Console.WriteLine("T1: {0}, T2: {1}", tower1[stepTree], tower2[stepTree]);
    //     // tower1[numberOfVariables] = 0;

    //     if (stepTree == 0)
    //     {
    //         tower3[numberOfVariables] = tower1[stepTree];
    //         tower1[stepTree] = 0;
    //     }
    //     else if (stepTree > 0)
    //     {
    //         if (tower1[stepTree] < tower2[numberOfVariables])
    //         {
    //             tower2[numberOfVariables] = tower1[stepTree];
    //             tower1[stepTree] = 0;
    //         }
    //     }

    //     if (numberOfVariables == 0)
    //     {
    //         res = true;
    //         return res;
    //     }

    //     res = MoveInt(tower1, tower2, tower3, numberOfVariables - 1, stepTree + 1);

    //     //System.Console.WriteLine("Tower 1: {0} index: {2}, Tower 2: {1} index {2}", tower1[numberOfVariables], tower2[stepTree], numberOfVariables, stepTree);

        

    //     return res;
    // }

    public static bool MoveIntByStack(Stack<int> tower1, Stack<int> tower2, Stack<int> tower3, int step1 = 3, int step2 = 0, int step3 = 0)
    {
        bool res = false;

        //tower3.Pop();
        tower3.Push(tower1.Peek());
        tower1.Pop();

        //tower2.Pop();
        tower2.Push(tower1.Peek());
        tower1.Pop();

        if (step1 == 1)
        {
            res = true;
            return res;
        }

        bool result = MoveIntByStack(tower1, tower2, tower3, step1--, step2, step3);

        return result;
    }
}