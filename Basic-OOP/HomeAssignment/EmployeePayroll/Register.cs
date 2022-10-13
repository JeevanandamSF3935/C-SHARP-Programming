namespace EmployeePayroll
{
    public class Register
    {
        public static List<EmployeePayment> employeeList = new List<EmployeePayment>();
        public static void RegisterEmployee(){
            Gender employeeGender;
            WorkLocation employeeWorkLocation;
            System.Console.Write("Enter the employee name : ");
            string employeeName = Console.ReadLine();
            System.Console.Write("Enter the role : ");
            string role = Console.ReadLine();
            System.Console.Write("Enter the work location (Madura or Eymard) : ");
            bool locationTemp = WorkLocation.TryParse(Console.ReadLine(),true,out employeeWorkLocation);
            while(!locationTemp){
                System.Console.Write("Wrong input!\nEnter again : ");
                locationTemp = WorkLocation.TryParse(Console.ReadLine(),true,out employeeWorkLocation);
            }
            System.Console.Write("Enter the team name : ");
            string teamName = Console.ReadLine();
            System.Console.Write("Enter the Date of joining : ");
            DateTime dateOfJoining = DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy",null);
            System.Console.Write("Enter the gender (Male,Female,Transgender) : ");
            bool genderTemp = Gender.TryParse(Console.ReadLine(),true,out employeeGender);
            while(!genderTemp){
                System.Console.Write("Wrong input!\nEnter again : ");
                genderTemp = Gender.TryParse(Console.ReadLine(),true,out employeeGender);
            }
            System.Console.WriteLine("Employee Enrolled");
            EmployeePayment employee = new EmployeePayment(employeeName,role,employeeWorkLocation,teamName,dateOfJoining,employeeGender);
            System.Console.WriteLine($"Employee ID : {employee.EmployeeID}");
            employeeList.Add(employee);
        }
    }
}