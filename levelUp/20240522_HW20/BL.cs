using System.ComponentModel;

namespace _20240522_HW20;

public class BL
{

    const int MaxMark = 100;
    const int MinStudyYear = 2010;
    const int MaxStudyYear = 10;
    const int MinDate = 1950;
    const int MaxDate = 2024;
    const int IdRecordLength = 8;

    public static Group CreateEmptyGroup(Supervisor[] supervisorList, string createGroupName = null)
    {
        System.Console.WriteLine();
        System.Console.WriteLine("Empty group creation...");
        System.Console.WriteLine();

        if (createGroupName == null)
        {
            System.Console.Write("Enter groupName: ");
            createGroupName = Console.ReadLine();
        }

        Group createEmptyGroup = new Group(){
            groupName = createGroupName,
            startDate = GetDateRandom("start date of enrollment", MinStudyYear, int.Parse(DateTime.Now.ToString("yyyy"))),
            currentYear = GetRandomInt(0, MaxStudyYear),
            groupSupervisor = UI.GetSupervisor(supervisorList),
            groupOfStudents = null,
            avrMarkOfGroup = 0,
            groupSubjects = GetListOfSubjects(),
            groupSpecialization = GetRandomSpecialization()
        };

        return createEmptyGroup;
    }

    public static DateTime GetDateRandom(string message, int yearMin = MinDate, int yearMax = MaxDate)
    {
        //System.Console.WriteLine("Enter {0}: ", message);
        int year = GetRandomInt(yearMin, yearMax);
        int month = GetRandomInt(1, 12);
        int day = GetRandomInt(1, 28);

        DateTime date = new DateTime(year, month, day);

        return date;
    }

    public static int GetAvarageMark(int[] marks = null)
    {
        if (marks != null)
        {
            int value = 0;

            for (int i = 0; i < marks.Length; i++)
            {
                value += marks[i];
            }

            return value;
        }

        return -1;
    }

    public static Supervisor[] GetSupervisorsArray(int value = 0)
    {
        if (value == 0)
        {
            value = UI.EnterIntValue("amount of supervisors");
        }

        Supervisor[] supervisorsArray = new Supervisor[value];

        for (int i = 0; i < supervisorsArray.Length; i++)
        {
            supervisorsArray[i] = UI.InitSupervisor();
        }

        return supervisorsArray;
    }

    public static string GetRandomFirstname()
    {
        Random rnd = new Random();

        int value = rnd.Next(1, Enum.GetValues(typeof(FirstNames)).Cast<int>().Max());

        string firstName = Convert.ToString((FirstNames)value);

        return firstName;
    }

    public static string GetRandomLastname()
    {
        Random rnd = new Random();

        int value = rnd.Next(1, Enum.GetValues(typeof(LastNames)).Cast<int>().Max());

        string lastName = Convert.ToString((LastNames)value);

        return lastName;
    }

    public static Student GetStudent(Group studentGroup, string[] idRecords)
    {
        Student studentCreate = new Student()
        {
            firstName = GetRandomFirstname(),
            lastName = GetRandomLastname(),
            idRecord = GenerateRandomRecordId(idRecords),
            avgMark = AvgMarkOfOneStudentRandom(studentGroup.groupSubjects),
            dateOfBirth = GetDateRandom("date of birth")
        };

        return studentCreate;
    }

    public static Student[] CreateStudentsArray(Group studentGroup, string[] idRecords, int amountOfStudents = 0)
    {
        if (amountOfStudents == 0)
        {
            amountOfStudents = UI.EnterIntValue("amount of students");
        }

        Student[] studentArray = new Student[amountOfStudents];

        for (int i = 0; i < studentArray.Length; i++)
        {
            studentArray[i] = GetStudent(studentGroup, idRecords);
        }

        return studentArray;
    }

    public static bool AddStudentArrayToGroup(ref Group groupName, Student[] studentsList = null, string[] idRecords = null)
    {
        if (studentsList == null)
        {
            studentsList = CreateStudentsArray(groupName, idRecords);
        }
        bool isTrasferToGroup = false;

        if (groupName.groupOfStudents == studentsList)
        {
            isTrasferToGroup = true;
            return isTrasferToGroup;
        }

        return false;
    }

    public static int GetRandomInt(int minValue = 0, int maxValue = int.MaxValue)
    {
        Random rnd = new Random();

        int value = rnd.Next(minValue, maxValue);

        return value;
    }

    public static Subject[] GetListOfSubjects(int amountOfSubjects = -1)
    {
        if (amountOfSubjects == -1)
        {
            amountOfSubjects = UI.EnterIntValue("amount of subjects");
        }

        Subject[] listOfSubjects = new Subject[amountOfSubjects];

        for (int i = 0; i < listOfSubjects.Length; i++)
        {
            listOfSubjects[i].subjectName = GetRandomSubjectList();
            listOfSubjects[i].subjectSpecialization = GetRandomSpecialization();
        }

        return listOfSubjects;
    }

    public static int[] GenerateMarkOfOneStudentRandom(Subject[] listOfSubjects)
    {
        int[] marks = new int[listOfSubjects.Length];

        for (int i = 0; i < listOfSubjects.Length; i++)
        {
            marks[i] = GetRandomInt(0, MaxMark);
        }

        return marks;
    }

    public static int AvgMarkOfOneStudentRandom(Subject[] listOfSubjects)
    {
        int[] marks = GenerateMarkOfOneStudentRandom(listOfSubjects);

        int markSum = 0;

        for (int i = 0; i < marks.Length; i++)
        {
            markSum += marks[i];
        }

        markSum = markSum / (marks.Length - 1);

        return markSum;
    }

    public static int AvgMarkOfGroup(Group studentsGroup)
    {
        int markSum = 0;

        for (int i = 0; i < studentsGroup.groupOfStudents.Length; i++)
        {
            markSum += studentsGroup.groupOfStudents[i].avgMark;
        }

        markSum = markSum / (studentsGroup.groupOfStudents.Length - 1);

        return markSum;
    }

    public static Supervisor[] GetRandomSupervisors(int value = 0)
    {
        if (value == 0)
        {
            value = UI.EnterIntValue("amount of supervisors");
        }

        Supervisor[] supervisorsRandom = new Supervisor[value];

        for (int i = 0; i < supervisorsRandom.Length; i++)
        {
            supervisorsRandom[i].firstName = GetRandomFirstname();
            supervisorsRandom[i].lastName = GetRandomLastname();
            supervisorsRandom[i].supervisorsSpecialization = GetRandomSpecialization();           
        }

        return supervisorsRandom;
    }

    public static Specialization GetRandomSpecialization()
    {
        int value = GetRandomInt(1, Enum.GetValues(typeof(Specialization)).Cast<int>().Max());

        Specialization randomSpecilization = (Specialization)value;

        return randomSpecilization;
    }

    public static Group[] InitArrayOfEmptyGroups(Supervisor[] supervisorList, int value = 0)
    {
        if (value == 0)
        {
            value = UI.EnterIntValue("amount of groups");
        }

        Group[] groupList = new Group[value];

        for (int i = 0; i < groupList.Length; i++)
        {
            groupList[i] = CreateEmptyGroup(supervisorList);
        }

        return groupList;
    }

    public static bool DeleteGroupFromListBL(Group[] groupList, Group groupToDelete)
    {
        int position = 0;
        bool deleteStatus = false;

        for (int i = 0; i < groupList.Length; i++)
        {
            if (groupList[i].groupName == groupToDelete.groupName)
            {
                position = i;
                break;
            }
        }

        for (int i = position; i < groupList.Length - 1; i++)
        {
            groupList[i] = groupList[i + 1];
        }

        Array.Resize(ref groupList, groupList.Length - 1);
        deleteStatus = true;

        return deleteStatus;
    }

    public static void PrintAllGroups(Group[] groupList)
    {
        for (int i = 0; i < groupList.Length; i++)
        {
            System.Console.WriteLine();
            UI.PrintGroup(groupList[i]);
            System.Console.WriteLine();
        }
    }

    public static Group MoveGroupToNextYear(ref Group studentGroup)
    {
        studentGroup.currentYear++;

        return studentGroup;
    }

    public static SubjectList GetRandomSubjectList()
    {
        int value = GetRandomInt(1, Enum.GetValues(typeof(SubjectList)).Cast<int>().Max());

        return (SubjectList)value;
    }

    public static string GenerateRandomRecordId(string[] idRecords)
    {
        string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";

        char[] idRecordChar = new char[IdRecordLength];

        for (int i = 0; i < idRecordChar.Length; i++)
        {
            idRecordChar[i] = chars[GetRandomInt(0, chars.Length)];
        }

        string idRecord = new string(idRecordChar);

        if (!CheckUniqueString(idRecords, idRecord))
        {
            string anotherRecord = GenerateRandomRecordId(idRecords);
            return anotherRecord;
        }

        AddRecordToId(ref idRecords, idRecord);

        return idRecord;
    }

    public static bool CheckUniqueString(string[] idRecords, string idRecordToCheck)
    {
        bool test = false;

        for (int i = 0; i < idRecords.Length; i++)
        {
            if (string.Equals(idRecords[i], idRecordToCheck))
            {
                return test;
            }
        }

        test = true;

        return test;
    }

    public static void AddRecordToId(ref string[] idRecords, string idRecordToAdd)
    {
        Array.Resize(ref idRecords, idRecords.Length + 1);
        idRecords[idRecords.Length - 1] = idRecordToAdd;
    }

    public static void UpdateGroups(Group[] groupList, Group groupToUpdate, Group groupUpdated)
    {
        int value = 0;
        for (int i = 0; i < groupList.Length; i++)
        {
            if (groupList[i].groupName == groupToUpdate.groupName)
            {
                value = i;
                break;
            }
        }

        groupList[value] = groupUpdated;
    }

    public static void DeleteStudent(Group studentGroup, Student studentToDelete)
    {
        int studentIndex = 0;

        for (int i = 0; i < studentGroup.groupOfStudents.Length; i++)
        {
            if (studentGroup.groupOfStudents[i].idRecord == studentToDelete.idRecord)
            {
                studentIndex = i;
                break;
            }
        }

        for (int i = studentIndex; i < studentGroup.groupOfStudents.Length - 1; i++)
        {
            studentGroup.groupOfStudents[i] = studentGroup.groupOfStudents[i + 1];
        }

        Array.Resize(ref studentGroup.groupOfStudents, studentGroup.groupOfStudents.Length - 1);
    }

    public static Group[] AddGroup(ref Group[] groupList, Group groupToAdd)
    {
        Array.Resize(ref groupList, groupList.Length + 1);

        groupList[groupList.Length - 1] = groupToAdd;

        return groupList;
    }
}
