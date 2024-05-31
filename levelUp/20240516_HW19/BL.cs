namespace _20240516_HW19;

public class BL
{
    public static Student InputStudent()
    {
        Student studentInput = new Student()
        {
            firstName = UI.EnterString("first name"),
            lastName = UI.EnterString("last name"),
            idRecord = UI.EnterString("student identification code"),
            studyDirection = UI.GetSpecialization(),
            avgMark = UI.EnterIntValue("avarage mark"),
            dateOfBirth = UI.GetDate("Date of birth")
        };

        return studentInput;
    }

    public static Group CreateEmptyBook()
    {
        int numberOfRecords = UI.EnterIntValue("number of records");

        Group recordBook = new Group()
        {
            students = new Student[numberOfRecords]
        };

        return recordBook;
    }

}
