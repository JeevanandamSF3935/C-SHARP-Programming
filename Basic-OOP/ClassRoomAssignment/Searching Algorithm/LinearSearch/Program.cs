namespace LinearSearch;
class Program
{
    public static void Main(string[] args)
    {
        int choice = 0;
        do
        {
            System.Console.WriteLine("Enter the coice :\n1.Number Search\n2.Character Search\n3.String Search\n4.Exit");
            choice = int.Parse(Console.ReadLine());
            switch(choice){
                case 1:{
                    NumberSearch();
                    break;
                }
                case 2:{
                    CharacterSearch();
                    break;
                }
                case 3:{
                    StringSearch();
                    break;
                }
                case 4:{
                    break;
                }
                default:{
                    System.Console.WriteLine("Invalid choice!\nEnter again");
                    break;
                }
            }
        } while (choice!=4);
    }

    public static void NumberSearch(){
        int count = 0, searchElement = 0;
        bool searchElementCheck = true;
        System.Console.Write("Enter the size of array : ");
        count = int.Parse(Console.ReadLine());
        int[] numbersArray = new int[count];
        System.Console.WriteLine("Enter the numbers of array :");
        for(int iterator = 0; iterator < count; iterator++){
            numbersArray[iterator] = int.Parse(Console.ReadLine());
        }
        System.Console.Write("Enter the number to be searched in array : ");
        searchElement = int.Parse(Console.ReadLine());
        for(int iterator = 0; iterator < count; iterator++){
            searchElementCheck = true;
            if(numbersArray[iterator] == searchElement){
                System.Console.WriteLine($"{searchElement} found at the index of {iterator}");
                break;
            }
            else{
                searchElementCheck = false;
            }
        }
        if(!searchElementCheck){
            System.Console.WriteLine($"{searchElement} not found in the array");
        }
    }

    public static void CharacterSearch(){
        int count = 0;
        bool searchCharacterCheck = true;
        System.Console.Write("Enter the size of array : ");
        count = int.Parse(Console.ReadLine());
        char[] charactersArray = new char[count];
        System.Console.WriteLine("Enter the characters : ");
        for(int iterator = 0;iterator < count;iterator++){
            charactersArray[iterator] = char.Parse(Console.ReadLine());
        }
        System.Console.Write("Enter the character to be searched : ");
        char searchCharacter = char.Parse(Console.ReadLine());
        for(int iterator = 0;iterator < count; iterator++){
            searchCharacterCheck = true;
            if(charactersArray[iterator] == searchCharacter){
                System.Console.WriteLine($"{searchCharacter} found at the index of {iterator}");
                break;
            }
            else{
                searchCharacterCheck = false;
            }
        }
        if(!searchCharacterCheck){
            System.Console.WriteLine($"{searchCharacter} not found in the array");
        }
    }

    public static void StringSearch(){
        int count = 0;
        bool searchStringCheck = true;
        System.Console.Write("Enter the size of array : ");
        count = int.Parse(Console.ReadLine());
        string[] stringsArray = new string[count];
        System.Console.WriteLine("Enter the strings :");
        for(int iterator = 0; iterator < count; iterator++){
            stringsArray[iterator] = Console.ReadLine().ToLower();
        }
        System.Console.Write("Enter the string to be searched : ");
        string searchString = Console.ReadLine().ToLower();
        for(int iterator = 0; iterator < count;iterator++){
            searchStringCheck = true;
            if(stringsArray[iterator] == searchString){
                System.Console.WriteLine($"'{searchString}' found at the index of {iterator}");
                break;
            }
            else{
                searchStringCheck = false;
            }
        }
        if(!searchStringCheck){
            System.Console.WriteLine($"'{searchString}' not found in the array");
        }
    }

}