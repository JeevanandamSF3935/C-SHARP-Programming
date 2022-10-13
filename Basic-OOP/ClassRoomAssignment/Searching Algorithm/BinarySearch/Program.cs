namespace BinarySearch;
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
        bool numberSearchCheck = false;
        int count = 0 , start = 0, mid = 0, end = 0;
        System.Console.Write("Enter the size of array : ");
        count = int.Parse(Console.ReadLine());
        int[] numbersArray = new int[count];
        System.Console.WriteLine("Enter the numbers :");
        for(int iterator = 0;iterator < count ; iterator++){
            numbersArray[iterator] = int.Parse(Console.ReadLine());
        }
        numbersArray = NumberSort(numbersArray,count);
        System.Console.Write("Enter the number to be searched in the array : ");
        int searchElement = int.Parse(Console.ReadLine());
        start = 0;
        end = count-1;
        mid = (start + end) / 2;
        while(start <= end){
            numberSearchCheck = false;
            if(numbersArray[mid] == searchElement){
                numberSearchCheck = true;
                System.Console.WriteLine($"{searchElement} is found");
                break;
            }
            else if(searchElement > numbersArray[mid]){
                start = mid + 1;
                mid = (start + end) / 2;         
            }
            else if(searchElement < numbersArray[mid]){
                end = mid - 1;
                mid = (start + end) / 2;
            }
        }
        if(!numberSearchCheck){
            System.Console.WriteLine($"{searchElement} not found in array");
        }
    }

    public static void CharacterSearch(){
        bool searchCharCheck = true;
        int count = 0, start = 0, mid = 0, end = 0;
        System.Console.Write("Enter the size of array : ");
        count = int.Parse(Console.ReadLine());
        char[] charactersArray = new char[count];
        System.Console.WriteLine("Enter the characters :");
        for(int iterator = 0; iterator < count ; iterator++){
            charactersArray[iterator] = char.Parse(Console.ReadLine());
        }
        charactersArray = CharacterSort(charactersArray,count);
        System.Console.Write("Enter the character to be searched : ");
        char searchChar = char.Parse(Console.ReadLine());
        start = 0;
        end = count - 1;
        mid = (start + end) / 2;
        while(start <= end){
            searchCharCheck = true;
            if(charactersArray[mid] == searchChar){
                System.Console.WriteLine($"'{searchChar}' is found");
                break;
            }
            else if(searchChar > charactersArray[mid]){
                start = mid + 1;
                mid = (start + end) / 2;
                searchCharCheck = false;
            }
            else if(searchChar < charactersArray[mid]){
                end = mid - 1;
                mid = (start + end) / 2;
                searchCharCheck = false;
            }
        }
        if(!searchCharCheck){
            System.Console.WriteLine($"'{searchChar}' is not found in the array");
        }
    }


    public static void StringSearch(){
        bool stringSearchCheck = true;
        int count = 0 , start = 0, mid = 0, end = 0;
        System.Console.Write("Enter the size of array : ");
        count = int.Parse(Console.ReadLine());
        string[] stringsArray = new string[count];
        System.Console.WriteLine("Enter the strings :");
        for(int iterator = 0; iterator < count; iterator++){
            stringsArray[iterator] = Console.ReadLine().ToLower();
        }
        stringsArray = StringSort(stringsArray,count);
        System.Console.Write("Enter the string to be searched : ");
        string stringSearch = Console.ReadLine().ToLower();
        end = count - 1;
        mid = (start + end) / 2;
        while(start <= end){
            stringSearchCheck = true;
            if(stringsArray[mid] == stringSearch){
                System.Console.WriteLine($"'{stringSearch}' is found");
                break;
            }
            else if(stringSearch.CompareTo(stringsArray[mid]) > 0){
                start = mid + 1;
                mid = (start + end) / 2;
                stringSearchCheck = false;
            }
            else if(stringSearch.CompareTo(stringsArray[mid]) < 0){
                end = mid - 1;
                mid = (start + end) / 2;
                stringSearchCheck = false;
            }
        }
        if(!stringSearchCheck){
            System.Console.WriteLine($"'{stringSearch}' is not found in the array");
        }
        
    }

    public static int[] NumberSort(int[] numbersArray, int count){
        int temp = 0;
        for(int iterator = 0; iterator < count;iterator++){
            for(int iterator1 = iterator + 1; iterator1 < count;iterator1++){
                if(numbersArray[iterator] > numbersArray[iterator1]){
                    temp = numbersArray[iterator];
                    numbersArray[iterator] = numbersArray[iterator1];
                    numbersArray[iterator1] = temp;
                }
            }
        }
        return numbersArray;
    }

    public static char[] CharacterSort(char[] charactersArray,int count){
        char temp;
        for(int iterator = 0;iterator < count; iterator++){
            for(int iterator1 = iterator + 1; iterator1 < count;iterator1++){
                if(charactersArray[iterator] > charactersArray[iterator1]){
                    temp = charactersArray[iterator];
                    charactersArray[iterator] = charactersArray[iterator1];
                    charactersArray[iterator1] = temp;
                }
            }
        }
        return charactersArray;
    }

    public static string[] StringSort(string[] stringsArray,int count){
        string temp = "";
        for(int iterator = 0;iterator < count; iterator++){
            for(int iterator1 = iterator + 1;iterator1 < count;iterator1++){
                if(stringsArray[iterator].CompareTo(stringsArray[iterator1]) > 0){
                    temp = stringsArray[iterator];
                    stringsArray[iterator] = stringsArray[iterator1];
                    stringsArray[iterator1] = temp;
                }
            }
        }
        return stringsArray;
    }


}