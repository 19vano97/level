using System.Security.Cryptography;
using _20240516_HW19;

internal class Program
{
    private static void Main(string[] args)
    {
        Group recordBook = BL.CreateEmptyBook();

        recordBook = UI.InputStudentsToRecordBook(ref recordBook, "Student");

        UI.PrintStudentsRecordBook(recordBook);
    }
}