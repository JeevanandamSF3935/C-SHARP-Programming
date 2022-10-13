namespace Question15;
class Program
{
    public static void Main(string[] args)
    {
        int age = 0;
        double washingMachinePrice = 0 , toysPrice = 0, recievedMoney = 0, toysMoney = 0, totalMoney = 0;
        System.Console.Write("Enter the age : ");
        age = int.Parse(Console.ReadLine());
        System.Console.Write("Enter the Washing machine price : ");
        washingMachinePrice = double.Parse(Console.ReadLine());
        System.Console.Write("Enter the toys price : ");
        toysPrice = double.Parse(Console.ReadLine());
        
        int moneyRecieved = age / 2;
        int toysRecieved = age - moneyRecieved;
        for(int iterator = 1;iterator <= moneyRecieved;iterator++){
            recievedMoney += (10*iterator);
        }
        toysMoney = toysRecieved * toysPrice;
        totalMoney = recievedMoney + toysMoney;

        if(totalMoney >= washingMachinePrice){
            System.Console.WriteLine($"Yes!\n{totalMoney-washingMachinePrice}");
        }
        else{
            System.Console.WriteLine($"No!\n{washingMachinePrice-totalMoney}");
        }
    }
}