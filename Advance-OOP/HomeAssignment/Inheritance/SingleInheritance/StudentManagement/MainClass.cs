namespace StudentManagement;
class MainClass
{
    public static void Main(string[] args)
    {
        int choice = 0;
        StudentInfo student = new StudentInfo("Jeeva","Perumal",8526764646,"jeeva@gmail.com",new DateTime(2001,01,24),Gender.Male,6,Branch.CSE,new DateTime(2022,01,01));
        do{
            System.Console.WriteLine("\nEnter the choice :\n1.Show details\n2.Update info\n3.Exit");
            choice = int.Parse(Console.ReadLine());
            switch(choice){
                case 1:{
                    System.Console.WriteLine("Student Details");
                    student.ShowInfo();
                    break;
                }
                case 2:{
                    student.UpdateInfo("Jeevanandam","Perumal",8526764646,"jeevanandam@gmail.com",new DateTime(2001,01,24),Gender.Male,8,Branch.CSE,new DateTime(2023,01,01));
                    break;
                }
                case 3:{
                    break;
                }
                default:{
                    System.Console.WriteLine("Invalid choice!");
                    break;
                }
            }
        }while(choice!=3);
    }
}

/*

        student.ShowInfo();
        student.ShowInfo();
*/