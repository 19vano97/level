//namespace _20240329_Lesson7;

namespace _20240401_Lesson8;

//public enum Direction : int by default
//public enum Direction : ushort
[Flags] //Attrabite - shows using several vals simitenuesly 
public enum Direction : byte
{
    Empty = 0b00000000, //0
    Left = 0b00000001, //1
    Top = 0b00000010,  //2
    Right = 0b00000100,  //3
    Bottom = 0b00001000 //4
}