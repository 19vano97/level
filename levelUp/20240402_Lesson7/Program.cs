// See https://aka.ms/new-console-template for more information
//Left shift
// byte e = 0b00001111;


// System.Console.WriteLine("Left shift");
// byte res = (byte)(e << 2);
// System.Console.WriteLine("      e: [{0,8}], ({1,2:X} - 16os), {1, 3}", Convert.ToString(e, 2), e);
// System.Console.WriteLine("    res: [{0,8}], ({1,2:X} - 16os), {1, 3}", Convert.ToString(res, 2), res);

// System.Console.WriteLine();
// byte y = 0b00000110;

// for (int i = 0; i < 4; i++)
// {
//     y = (byte)(y << 1);
//     System.Console.WriteLine("      y: [{0,8}], ({1,2:X} - 16os), {1, 3}", Convert.ToString(y, 2), y);
// }


// //right shift
// byte t = 0b00001111;


// System.Console.WriteLine("Right shift");
// byte res1 = (byte)(e >> 2);
// System.Console.WriteLine("      t: [{0,8}], ({1,2:X} - 16os), {1, 3}", Convert.ToString(t, 2), t);
// System.Console.WriteLine("      res1: [{0,8}], ({1,2:X} - 16os), {1, 3}", Convert.ToString(res1, 2), res1);

// System.Console.WriteLine();

// byte f = 0b10101010;

// for (int i = 0; i < 4; i++)
// {
//     f = (byte)(f >> 1);
//     System.Console.WriteLine("      f: [{0,8}], ({1,2:X} - 16os), {1, 3}", Convert.ToString(f, 2), f);
// }

const byte MASK_01 = 0b00000001;
const byte MASK_02 = 0b00000010;
const byte MASK_03 = 0b00000100;
const byte MASK_04 = 0b00001000;
const byte MASK_05 = 0b00010000;
const byte MASK_06 = 0b00100000;
const byte MASK_07 = 0b01000000;
const byte MASK_08 = 0b10000000;

byte flags = 0;

#region setBits
    
    //1) separate bit    
    flags |= MASK_02;
    System.Console.WriteLine("flags: = {0, 10}, {1}", Convert.ToString(flags, 2), flags);

    //2) setup several masks (OR)
    flags |= MASK_04 | MASK_05;
    System.Console.WriteLine("flags: = {0, 10}, {1}", Convert.ToString(flags, 2), flags);

    //3) check bits (AND)
    if ((flags & MASK_01) > 0)
    {
        System.Console.WriteLine("1st bit set");
    }
    if ((flags & MASK_02) > 0)
    {
        System.Console.WriteLine("2nd bit set");
    }
    if ((flags & MASK_03) > 0)
    {
        System.Console.WriteLine("3rd bit set");
    }
    if ((flags & MASK_04) > 0)
    {
        System.Console.WriteLine("4th bit set");
    }
    if ((flags & MASK_05) > 0)
    {
        System.Console.WriteLine("5th bit set");
    }
    if ((flags & MASK_06) > 0)
    {
        System.Console.WriteLine("6th bit set");
    }
    if ((flags & MASK_07) > 0)
    {
        System.Console.WriteLine("7th bit set");
    }
    if ((flags & MASK_08) > 0)
    {
        System.Console.WriteLine("8th bit set");
    }

    //4)clear bits
    unchecked
    {
        byte negMask4 = (byte)(~MASK_04);
        flags &= negMask4;
    }
    System.Console.WriteLine("flags MASK4: = {0, 10}, {1}", Convert.ToString(flags, 2), flags);

    unchecked
    {
        byte negMask2 = (byte)(~MASK_02);
        flags &= negMask2;
    }
    System.Console.WriteLine("flags MASK2: = {0, 10}, {1}", Convert.ToString(flags, 2), flags);

    //byte k = 0;

    // for (int i = 0; i < 1000; i++)
    // {
    //     k++;
    //     System.Console.Write("{0} ,", k);
    // }

    // checked //stops if overloading
    // {
    //         for (int i = 0; i < 1000; i++)
    //     {
    //         k++;
    //         System.Console.Write("{0} ,", k);
    //     }
    // }
    
    //set/unset bit
    System.Console.WriteLine();
    
    for (int i = 0; i < 7; i++)
    {
        flags ^= MASK_02;
        System.Console.WriteLine("flags MASK2: = {0, 10}, {1}", Convert.ToString(flags, 2), flags);
    }

#endregion