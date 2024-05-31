using System.ComponentModel;

namespace _20240516_HW19;

public class UI
{
    public static string EnterString(string message)
    {
        System.Console.Write("Enter {0}: ", message);
        string str = Console.ReadLine();

        return str;
    }

    public static int EnterIntValue(string message)
    {
        System.Console.Write("Enter {0}: ", message);
        
        string str = Console.ReadLine();

        if (!int.TryParse(str, out int value))
        {
            System.Console.WriteLine("Enter correct value!");
            value = EnterIntValue(message + " again");
            return value;
        }

        return value;
    }

    public static Specialization GetSpecialization()
    { 
        System.Console.Write("Choose a specialzation from the list: ");

        for (int i = 1; i <= Enum.GetValues(typeof(Specialization)).Cast<int>().Max(); i++)
        {
            if (Enum.IsDefined(typeof(Specialization), i))
            {
                System.Console.Write("{0} - {1}, ", (Specialization)i, i);
            }
        }

        System.Console.WriteLine("Enter your choice: ");
        string str = Console.ReadLine();

        if (!int.TryParse(str, out int value) || !Enum.IsDefined(typeof(Specialization), value))
        {
            System.Console.WriteLine();
            System.Console.WriteLine("Wrong! Enter again!");
            value = (int)GetSpecialization();
            return (Specialization)value;
        }

        return (Specialization)value;
    }

    public static DateTime GetDate(string message = null)
    {
        System.Console.WriteLine("{0}", message);
        int year = EnterIntValue("year");
        int month = EnterIntValue("month");
        int day = EnterIntValue("day");

        DateTime date = new DateTime(year, month, day);

        return date;
    }

    public static void PrintStudent(Student key)
    {
        System.Console.WriteLine("Name: {0} {1}", key.firstName, key.lastName);
        System.Console.WriteLine("Student identification code: {0}", key.idRecord);
        System.Console.WriteLine("Specilization: {0}", key.studyDirection);
        System.Console.WriteLine("Avarage Mark: {0}", key.avgMark);
        System.Console.WriteLine("Date of birth: {0}", key.dateOfBirth.ToString("yyyy-MM-dd"));
    }

    public static void PrintStudentsRecordBook(Group recordBook)
    {
        for (int i = 0; i < recordBook.students.Length; i++)
        {
            PrintStudent(recordBook.students[i]);
            System.Console.WriteLine();
        }
    }

    public static Group InputStudentsToRecordBook(ref Group recordBook, string message = null)
    {
        for (int i = 0; i < recordBook.students.Length; i++)
        {
            System.Console.WriteLine();
            System.Console.WriteLine("{0}: {1}", message, i + 1);
            recordBook.students[i] = BL.InputStudent();
        }

        return recordBook;
    }
}
