﻿namespace _20240403_HW9;

[Flags]

public enum DayWeek : byte
{
    None = 0b00000000,
    Monday = 0b00000001,
    Tuesday = 0b00000010,
    Wednesday = 0b00000100,
    Thursday = 0b00001000,
    Friday = 0b00010000,
    Saturday = 0b00100000,
    Sunday = 0b01000000
}
