namespace VaccinationDrive;
public class MenuClass
{
    public static void MainMenu(){
        int choice = 0;
        do{
            System.Console.WriteLine("Enter your choice:\n1.Registration\n2.Login \n3.Get Vaccine info\n4.Exit");
            choice = int.Parse(Console.ReadLine());
            switch(choice){
                case 1:{
                    Registration.BenficiaryRegister();
                    break;
                }
                case 2:{
                    Login.BenficiaryLogin();
                    break;
                }
                case 3:{
                    Vaccine.ShowVaccine();
                    break;
                }
                case 4:{
                    break;
                }
                default:{
                    System.Console.WriteLine("Invalid choice!\nEnter again\n");
                    break;
                }
            }
        }while(choice!=4);
    }

    public static void SubMenu(Benficiary benficiary){
        int choice = 0;
        do{
            System.Console.WriteLine("Enter your choice:\n1.Show my details\n2.Take Vaccination\n3.My Vaccination History\n4.Next Due Date\n5.Log out");
            choice = int.Parse(Console.ReadLine());
            switch(choice){
                case 1:{
                    Benficiary.ShowDetails(benficiary);
                    break;
                }
                case 2:{
                    Login.TakeVaccine(benficiary);
                    break;
                }
                case 3:{
                    Benficiary.ShowHistory(benficiary);
                    break;
                }
                case 4:{
                    Login.NextDue(benficiary);
                    break;
                }
                case 5:{
                    break;
                }
                default:{
                    System.Console.WriteLine("Invalid choice!\nEnter again\n");
                    break;
                }
            }
        }while(choice!=5);
    }
}
