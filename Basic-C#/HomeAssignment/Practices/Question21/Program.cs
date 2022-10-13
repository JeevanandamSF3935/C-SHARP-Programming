namespace Question21;
class Program
{
    public static void Main(string[] args)
    {
        int count = 0;
        System.Console.Write("Enter the count : ");
        count = int.Parse(Console.ReadLine());
        for(int iterator = 1;iterator <= count + 1;iterator++){
            for(int iterator1 = count-iterator;iterator1 >=0;iterator1--){
                System.Console.Write(" ");
            }
            for(int iterator1 = 1;iterator1 < iterator;iterator1++){
                System.Console.Write("*");
            }
            System.Console.Write(" | ");
            for(int iterator1 = 1;iterator1 < iterator;iterator1++){
                System.Console.Write("*");
            }
            System.Console.WriteLine();
        }
    }
}