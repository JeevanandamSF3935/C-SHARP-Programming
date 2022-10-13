namespace Question17;
class Program
{
    public static void Main(string[] args)
    {
        int days = 0, treatedPatients = 0, unTreatedPatients = 0, doctorsCount = 7;
        System.Console.Write("Enter the days to be calculated : ");
        days = int.Parse(Console.ReadLine());
        int[] patientsCount = new int[days];
        System.Console.WriteLine("Enter the patients count :");
        for(int iterator = 0; iterator < days;iterator++){
            patientsCount[iterator] = int.Parse(Console.ReadLine());
        }
        for(int iterator = 0; iterator < days;iterator++){
            if((iterator+1) % 3 == 0){
                doctorsCount++;
            }
            if(patientsCount[iterator] <= doctorsCount){
                treatedPatients += patientsCount[iterator];
            }
            else{
                treatedPatients += doctorsCount;
                unTreatedPatients += (patientsCount[iterator] - doctorsCount);
            }
        }
        System.Console.WriteLine($"Treated patients : {treatedPatients}\nUntreated patients : {unTreatedPatients}");
    }
}