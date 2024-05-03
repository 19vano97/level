namespace _20240503_HW17;

[Flags]

public enum Weather : ushort
{
    None = 0b0000000000000000,
    Sun = 0b0000000000000001,
    Cloudy = 0b0000000000000010,
    Rainy = 0b0000000000000100,
    Snow = 0b0000000000001000,
    Windy = 0b0000000000010000
}
