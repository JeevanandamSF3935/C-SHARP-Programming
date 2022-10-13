namespace Question18;
class Program
{
    public static void Main(string[] args)
    {
        int count = 0, twoDivisorCount = 0, threeDivisorCount = 0, fourDivisorCount = 0;
        double twoDivisorPercentage = 0, threeDivisorPercentage = 0, fourDivisorPercentage = 0;
        System.Console.Write("Enter the count of the numbers : ");
        count = int.Parse(Console.ReadLine());
        int[] numbersArray = new int[count];
        System.Console.WriteLine("Enter the numbers :");
        for(int iterator = 0;iterator < count;iterator++){
            numbersArray[iterator] = int.Parse(Console.ReadLine());
        }
        for(int iterator = 0;iterator < count;iterator++){
            if(numbersArray[iterator] % 2 == 0){
                twoDivisorCount++;
            }
            if(numbersArray[iterator] % 3 == 0){
                threeDivisorCount++;
            }
            if(numbersArray[iterator] % 4 == 0){
                fourDivisorCount++;
            }
        }
        twoDivisorPercentage = (double)twoDivisorCount / count * 100;
        threeDivisorPercentage = (double)threeDivisorCount / count * 100;
        fourDivisorPercentage = (double)fourDivisorCount / count * 100;
        System.Console.WriteLine(twoDivisorPercentage.ToString("0.00")+"%");
        System.Console.WriteLine(threeDivisorPercentage.ToString("0.00")+"%");
        System.Console.WriteLine(fourDivisorPercentage.ToString("0.00")+"%");
    }
}