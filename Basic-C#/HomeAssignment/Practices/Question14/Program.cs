namespace Question15;
class Program
{
    public static void Main(string[] args)
    {
        int count = 20, count1 = 0, count2 = 0, count3 = 0, count4 = 0, count5 = 0;
        double percentage1 = 0, percentage2 = 0, percentage3 = 0, percentage4 = 0, percentage5 = 0;

        System.Console.Write("Enter the number of elements : ");
        count = int.Parse(Console.ReadLine());

        int[] numbersArray = new int[count];
        System.Console.WriteLine("Enter the numbers : ");
        for(int iterator = 0;iterator < count;iterator++){
            numbersArray[iterator] = int.Parse(Console.ReadLine());
        }

        for(int iterator = 0;iterator < count; iterator++){
            if(numbersArray[iterator] < 200){
                count1++;
            }
            else if(numbersArray[iterator] >= 200 && numbersArray[iterator] < 400){
                count2++;
            }
            else if(numbersArray[iterator] >= 400 && numbersArray[iterator] < 600){
                count3++;
            }
            else if(numbersArray[iterator] >= 600 && numbersArray[iterator] < 800){
                count4++;
            }
            else if(numbersArray[iterator] >= 800){
                count5++;
            }
        }
        percentage1 = (double) count1 / count * 100;
        percentage2 = (double) count2 / count * 100;
        percentage3 = (double) count3 / count * 100;
        percentage4 = (double) count4 / count * 100;
        percentage5 = (double) count5 / count * 100;
        System.Console.WriteLine($"{percentage1.ToString("00.00")}%\n{percentage2.ToString("00.00")}%\n{percentage3.ToString("00.00")}%\n{percentage4.ToString("00.00")}%\n{percentage5.ToString("00.00")}%");
    }
}