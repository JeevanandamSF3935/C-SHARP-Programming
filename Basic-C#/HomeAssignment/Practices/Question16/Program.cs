namespace Question16;
class Program
{
    public static void Main(string[] args)
    {
        double inheritedMoney = 0, requiredMoney = 0;
        int year = 0, age = 18;
        System.Console.Write("Enter the inherited money : ");
        inheritedMoney = double.Parse(Console.ReadLine());
        System.Console.Write("Enter the year until he has to live in past : ");
        year = int.Parse(Console.ReadLine());
        for(int year1 = 1800; year1 <= year;year1++){
            if(year1 % 2 == 0){
                requiredMoney += 12000;
            }
            else{
                requiredMoney += (12000 + (50 * age));
            }
            age++;
        }
        if(requiredMoney <= inheritedMoney){
            System.Console.WriteLine($"Yes!He will live a carefree life and will have {(inheritedMoney-requiredMoney).ToString("0.00")}");
        }
        else{
            System.Console.WriteLine($"No!He will need {(requiredMoney-inheritedMoney).ToString("0.00")} to survive");
        }
    }
}