namespace SortingAlgorithm;
class Program
{
    public static void Main(string[] args)
    {
        int count = 0, choice = 0;
        System.Console.Write("Enter the length of array : ");
        count = int.Parse(Console.ReadLine());
        int[] numbersArray = new int[count];
        System.Console.WriteLine("Enter the elements :");
        for(int iterator = 0;iterator < count;iterator++){
            numbersArray[iterator] = int.Parse(Console.ReadLine());
        }
        do
        {
            System.Console.WriteLine("\nEnter the choice :\n1.Bubble Sort\n2.Insertion Sort\n3.Selection sort\n4.Merge Sort\n5.Quick Sort\n6.Exit");
            choice = int.Parse(Console.ReadLine());
            switch(choice){
                case 1:{
                    BubbleSort(numbersArray,count);
                    PrintArray(numbersArray);
                    break;
                }
                case 2:{
                    InsertionSort(numbersArray,count);
                    PrintArray(numbersArray);
                    break;
                }
                case 3:{
                    SelectionSort(numbersArray,count);
                    PrintArray(numbersArray);
                    break;
                }
                case 4:{
                    MergeSort(numbersArray,count);
                    PrintArray(numbersArray);
                    break;
                }
                case 5:{
                    QuickSort(numbersArray,0,count-1);
                    PrintArray(numbersArray);
                    break;
                }
                case 6:{
                    break;
                }
                default:{
                    System.Console.WriteLine("Invalid choice!\nEnter again!!!");
                    break;
                }
            }
        } while (choice!=6);
    }

    public static void BubbleSort(int[] numbersArray,int count){
        int iterator = 0, iterator1 = 0, temp = 0;
        for(iterator = 0;iterator < count - 1;iterator++){
            for(iterator1 = 0;iterator1 < count - iterator - 1;iterator1++){
                if(numbersArray[iterator1] > numbersArray[iterator1 + 1]){
                    temp = numbersArray[iterator1];
                    numbersArray[iterator1] = numbersArray[iterator1 + 1];
                    numbersArray[iterator1 + 1] = temp;
                }
            }
        }
    }

    public static void InsertionSort(int[] numbersArray,int count){
        int iterator = 0, iterator1 = 0, temp = 0;
        for(iterator = 1;iterator < count;iterator++){
            for(iterator1 = iterator-1;iterator1 >= 0;iterator1--){
                if(numbersArray[iterator] < numbersArray[iterator1]){
                    temp = numbersArray[iterator];
                    numbersArray[iterator] = numbersArray[iterator1];
                    numbersArray[iterator1] = temp;
                    iterator--;
                }
            }
        }
    }

    public static void SelectionSort(int[] numbersArray,int count){
        bool changeChecker = false;
        int minimum = 0, temp = 0, tempIterator = 0, iterator = 0, iterator1 = 0;
        for(iterator = 0;iterator < count;iterator++){
            minimum = numbersArray[iterator];
            changeChecker = false;
            for(iterator1 = iterator + 1;iterator1 < count;iterator1++){
                if(minimum > numbersArray[iterator1]){
                    minimum = numbersArray[iterator1];
                    tempIterator = iterator1;
                    changeChecker = true;
                }
            }
            if(changeChecker){
                temp = numbersArray[iterator];
                numbersArray[iterator] = numbersArray[tempIterator];
                numbersArray[tempIterator] = temp;
            }
        }
    }

    public static void MergeSort(int[] numbersArray,int count){
        int mid = count / 2;
        if(count < 2){
            return;
        }

        int[] leftHalf = new int[mid];
        int[] rightHalf = new int[count-mid];
        for(int i = 0;i < mid;i++){
            leftHalf[i] = numbersArray[i];
        }
        for(int i = mid;i < count;i++){
            rightHalf[i-mid] = numbersArray[i];
        }
        MergeSort(leftHalf,mid);
        MergeSort(rightHalf,count-mid);
        Merge(numbersArray,leftHalf,rightHalf);
    }
    public static void Merge(int[] numbersArray,int[] leftHalf,int[] rightHalf){
        int leftSize = leftHalf.Length;
        int rightSize = rightHalf.Length;
        int i = 0, j = 0, k = 0;
        while(i < leftSize && j < rightSize){
            if(leftHalf[i] <= rightHalf[j]){
                numbersArray[k] = leftHalf[i];
                i++;
            }
            else{
                numbersArray[k] = rightHalf[j];
                j++;
            }
            k++;
        }
        while(i < leftSize){
            numbersArray[k] = leftHalf[i];
            k++;
            i++;
        }
        while(j < rightSize){
            numbersArray[k] = rightHalf[j];
            k++;
            j++;
        }
    }

    public static void PrintArray(int[] numbersArray){
        System.Console.WriteLine("Sorted Array :");
        for(int iterator = 0;iterator < numbersArray.Length;iterator++){
            System.Console.Write($"{numbersArray[iterator]} ");
        }
    }

    public static void QuickSort(int[] numbersArray, int start, int end){
        if(start >= end){
            return;
        }
        int pivot = numbersArray[end];
        int leftPointer = start;
        int rightPointer = end;
        while(leftPointer < rightPointer){
            while(numbersArray[leftPointer] <= pivot && leftPointer < rightPointer){
                leftPointer++;
            }
            while(numbersArray[rightPointer] >= pivot && leftPointer < rightPointer){
                rightPointer--;
            }
            swap(numbersArray,leftPointer,rightPointer);
        }
        swap(numbersArray,leftPointer,end);
        QuickSort(numbersArray,start,leftPointer-1);
        QuickSort(numbersArray,leftPointer+1,end);
    }

    public static void swap(int[] numbersArray, int index1, int index2){
        int temp = numbersArray[index1];
        numbersArray[index1] = numbersArray[index2];
        numbersArray[index2] = temp;
    }

}