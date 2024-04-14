using System.Reflection.PortableExecutable;
using System.Xml.XPath;

internal class Program
{
    private static void Main(string[] args)
    {

        #region byArray

            System.Console.WriteLine("Enter quantity of variables: ");
            int varQuantity = InputIntNumber("quantity");
    
            int[] var = new int[varQuantity];
    
            for (int i = 0; i < varQuantity; i++)
            {
                var[i] = InputIntNumber(Convert.ToString(i));
            }
    
            int minVarByArray = GetMinByArray(var, varQuantity);
            int maxVarByArray = GetMaxByArray(var, varQuantity);

            System.Console.WriteLine("Result GetMinByArray: {0}", minVarByArray);
            System.Console.WriteLine("Result GetMaxByArray: {0}", maxVarByArray);

        #endregion

        System.Console.WriteLine();

        #region byTask

            int var1 = InputIntNumber("var1");
            int var2 = InputIntNumber("var2");
            int var3 = InputIntNumber("var3");
            int var4 = InputIntNumber("var4");
            int var5 = InputIntNumber("var5");
            int var6 = InputIntNumber("var6");

            int quantity = 6;

            int minVarByTask = GetMinByTask(quantity, var1, var2, var3, minValue6: var4);
            int maxVarByTask = GetMaxByTask(quantity, var1, var2, var3, maxValue6: var4);

            System.Console.WriteLine("Result GetMinByTask: {0}", minVarByTask);
            System.Console.WriteLine("Result GetMaxByTask: {0}", maxVarByTask);

        #endregion
    }

    public static int InputIntNumber(string varName)
    {
        System.Console.Write("Enter {0} = ", varName);
        int result = int.Parse(Console.ReadLine());

        return result;
    }

    public static int GetMinByArray(int[] minVars, int varQuantity)
    {
        int minValueFinal = int.MaxValue;

        for (int i = 0; i < varQuantity; i++)
        {
            if (i == 0)
            {
                minValueFinal = minVars[0];
            }
            else if (i > 0 & minValueFinal > minVars[i])
            {
                minValueFinal = minVars[i];
            }
        }

        return minValueFinal;
    }

    public static int GetMaxByArray(int[] maxVars, int varQuantity)
    {
        int maxValueFinal = int.MaxValue;

        for (int i = 0; i < varQuantity; i++)
        {
            if (i == 0)
            {
                maxValueFinal = maxVars[0];
            }
            else if (i > 0 & maxValueFinal < maxVars[i])
            {
                maxValueFinal = maxVars[i];
            }
        }

        return maxValueFinal;
    }

    public static int GetMinByTask(int quantity, int minValue1 = int.MaxValue, int minValue2 = int.MaxValue, 
                                                 int minValue3 = int.MaxValue, int minValue4 = int.MaxValue, 
                                                 int minValue5 = int.MaxValue, int minValue6 = int.MaxValue)
    {
        int minValueFinal = 0;
        int[] minValues = new int[6];

        minValues[0] = minValue1;
        minValues[1] = minValue2;
        minValues[2] = minValue3;
        minValues[3] = minValue4;
        minValues[4] = minValue5;
        minValues[5] = minValue6;

        for (int i = 0; i < quantity; i++)
        {
            if (i == 0)
            {
                minValueFinal = minValues[i];
            }
            else if (i > 0 & minValues[i] !=int.MaxValue & minValueFinal > minValues[i])
            {
                minValueFinal = minValues[i];
            }
        }

        return minValueFinal;
    }

    public static int GetMaxByTask(int quantity, int maxValue1 = int.MinValue, int maxValue2 = int.MinValue, 
                                                 int maxValue3 = int.MinValue, int maxValue4 = int.MinValue, 
                                                 int maxValue5 = int.MinValue, int maxValue6 = int.MinValue)
    {
        int maxValueFinal = 0;
        int[] maxValues = new int[6];

        maxValues[0] = maxValue1;
        maxValues[1] = maxValue2;
        maxValues[2] = maxValue3;
        maxValues[3] = maxValue4;
        maxValues[4] = maxValue5;
        maxValues[5] = maxValue6;

        for (int i = 0; i < quantity; i++)
        {
            if (i == 0)
            {
                maxValueFinal = maxValues[i];
            }
            else if (i > 0 & maxValues[i] !=int.MinValue & maxValueFinal < maxValues[i])
            {
                maxValueFinal = maxValues[i];
            }
        }

        return maxValueFinal;
    }
}