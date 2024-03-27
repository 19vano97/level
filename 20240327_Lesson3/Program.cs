// See https://aka.ms/new-console-template for more information

class lesson3
{
    static void Main(string[] args)
    {
        Console.WriteLine(uint.MaxValue);

        #region UINT

        //uint k = 0; // there is transitions, therefore it will take more time/resorces to work, because of Uint = int

        //uint k1 = 0u; //takes less resources to work with since, there is no transitionsbecause of Uint = Uint (number with U-ending)

        #endregion

        #region ConvertByteToString

        //byte x = byte.MinValue;
        //while (x < byte.MaxValue)
        //{
        //    string sOut2 = Convert.ToString(x, 2); //converting binary to string
        //    string sOut8 = Convert.ToString(x, 8);
        //    string sOut16 = Convert.ToString(x, 16);

        //    Console.WriteLine("{0,3} - {1,8} - {2,12} - {3,16}", x, sOut2, sOut8, sOut16); //coma and number adds space  ex "    0 -            0"
        //    x++;
        //}

        #endregion

        #region float



        #endregion

    }
}

