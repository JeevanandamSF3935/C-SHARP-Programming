namespace Question19;
class Program
{
    public static void Main(string[] args)
    {
        int cargoCount = 0, minibusWeight = 0, truckWeight = 0, trainWeight = 0, sumOfWeight = 0;
        double averagePrice = 0, miniBusPercentage = 0, truckPercentage = 0, trainPercentage = 0;
        System.Console.Write("Enter the count of cargos : ");
        cargoCount = int.Parse(Console.ReadLine());
        int[] weightsOfCargos = new int[cargoCount];
        for(int iterator = 0;iterator < cargoCount;iterator++){
            weightsOfCargos[iterator] = int.Parse(Console.ReadLine());
        }
        for(int iterator = 0;iterator < cargoCount;iterator++){
            if(weightsOfCargos[iterator] <= 3){
                minibusWeight += weightsOfCargos[iterator];
            }
            else if(weightsOfCargos[iterator] > 3 && weightsOfCargos[iterator] <= 11){
                truckWeight += weightsOfCargos[iterator];
            }
            else if(weightsOfCargos[iterator] > 11){
                trainWeight += weightsOfCargos[iterator];
            }
            sumOfWeight += weightsOfCargos[iterator];
        }
        averagePrice = (double)((minibusWeight * 200) + (truckWeight * 175) + (trainWeight * 120)) / sumOfWeight;
        miniBusPercentage = (double)minibusWeight / sumOfWeight * 100;
        truckPercentage = (double)truckWeight / sumOfWeight * 100;
        trainPercentage = (double)trainWeight / sumOfWeight * 100;
        System.Console.WriteLine($"Average price is {averagePrice.ToString("0.00")}");
        System.Console.WriteLine($"{miniBusPercentage.ToString("0.00")}%");
        System.Console.WriteLine($"{truckPercentage.ToString("0.00")}%");
        System.Console.WriteLine($"{trainPercentage.ToString("0.00")}%");
    }
}