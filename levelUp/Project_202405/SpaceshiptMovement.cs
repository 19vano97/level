namespace Project_202405;

[Flags]

public enum SpaceshiptMovement : byte
{
    None = 0b00000000,
    Up = 0b00000001,
    Down = 0b00000010,
    Left = 0b00000100,
    Right = 0b00001000
}
