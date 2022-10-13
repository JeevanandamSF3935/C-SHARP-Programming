using AdmissionLibrary;
namespace StudentApplication
{
    public static class Login
    {
        public static void LoginStudent(){
            System.Console.Write("Enter your register number : ");
            long register = long.Parse(Console.ReadLine());
            foreach(StudentsDetails student in Register.studentList){
                if(student.RegisterNumber == register){
                    System.Console.WriteLine("Login Successfully!");
                }
            }
        }
    }
}