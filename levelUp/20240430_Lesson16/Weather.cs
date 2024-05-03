namespace _20240430_Lesson16;

[Flags]

public enum Weather : ushort
{
    None,
    Rain = 0b0000000000000001,
    Snow = 0b0000000000000010,
    Sun = 0b0000000000000100

}
