namespace _20240503_HW17;

[Flags]

public enum Weather : byte
{
    None = 0b0000000000000000,
    Sun = 0b0000000000000001,
    Cloudy = 0b0000000000000010,
    Rainy = 0b0000000000000100,
    Windy = 0b0000000000001000,
    Fog = 0b0000000000010000,
    Snow = 0b0000000000100000
}
