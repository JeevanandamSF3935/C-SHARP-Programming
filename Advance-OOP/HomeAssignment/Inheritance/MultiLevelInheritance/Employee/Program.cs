namespace Execise3;

class Program 
{
    public static void Main(string[] args)
    {
        EmployeeInfo obj = new EmployeeInfo("EMP1001", "CSE", 3, 2000, 3, "Robert", "Downey" ,Gender.Male, 989868968, new DateTime(2021, 11, 12));
        obj.ShowDetails();
    }
}