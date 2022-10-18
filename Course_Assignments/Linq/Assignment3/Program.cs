using System;
using System.Collections.Generic;
using System.Linq;
namespace Assignment3;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the choice : ");
        System.Console.WriteLine("1.Show the list of Trainee Id");
        System.Console.WriteLine("2.Show the first 3 Trainee Id using Take");
        System.Console.WriteLine("3.Show the last 2 Trainee Id using Skip");
        System.Console.WriteLine("4.Show the count of Trainee");
        System.Console.WriteLine("5.Show the Trainee Name who are all passed out 2019 or later");
        System.Console.WriteLine("6.Show the Trainee Id and Trainee Name by alphabetic order of the trainee name.");
        System.Console.WriteLine("7.Show the Trainee Id, Trainee Name, Topic Name, Exercise Name and Mark who are all scores the more than or equal to 4 mark");
        System.Console.WriteLine("8.Show the unique passed out year using distinct");
        System.Console.WriteLine("9.Show the total marks of single user (get the Trainee Id from User), if Trainee Id does not exist, show the invalid message");
        System.Console.WriteLine("10.Show the first Trainee Id and Trainee Name");
        System.Console.WriteLine("11.Show the last Trainee Id and Trainee Name");
        System.Console.WriteLine("12.Print the total score of each trainee");
        System.Console.WriteLine("13.Show the maximum total score");
        System.Console.WriteLine("14.Show the minimum total score");
        System.Console.WriteLine("15.Show the average of total score");
        System.Console.WriteLine("16.Show true or false if any one has the more than 40 score using any()");
        System.Console.WriteLine("17.Show true of false if all of them has the more than 20 using all()");
        System.Console.WriteLine("18.Show the Trainee Id, Trainee Name, Topic Name, Exercise Name and Mark by show the Trainee Name as descending order and then show the Mark as descending order");
        int choice = int.Parse(Console.ReadLine());
        
        switch(choice){
            case 1:{
                TraineeData trainee = new TraineeData();
                List<TraineeDetails> traineeList = trainee.GetTraineeDetails();
                IEnumerable<string> data = from temp in traineeList select temp.TraineeId.ToString();
                for(int iterator = 0;iterator < traineeList.Count; iterator++){
                    System.Console.WriteLine($"{data.ElementAt(iterator)}");
                }
                break;
            }
            case 2:{
                TraineeData trainee = new TraineeData();
                List<TraineeDetails> traineeList = trainee.GetTraineeDetails();
                IEnumerable<TraineeDetails> data = traineeList.Take(3) ;
                for(int iterator = 0;iterator < data.Count(); iterator++){
                    System.Console.WriteLine($"{data.ElementAt(iterator).TraineeId}");
                }
                break;
            }
            case 3:{
                TraineeData trainee = new TraineeData();
                List<TraineeDetails> traineeList = trainee.GetTraineeDetails();
                IEnumerable<TraineeDetails> data = traineeList.Skip(3) ;
                for(int iterator = 0;iterator < data.Count(); iterator++){
                    System.Console.WriteLine($"{data.ElementAt(iterator).TraineeId}");
                }
                break;
            }
            case 4:{
                TraineeData trainee = new TraineeData();
                List<TraineeDetails> traineeList = trainee.GetTraineeDetails();
                IEnumerable<string> data = from temp in traineeList select temp.TraineeId.ToString();
                System.Console.WriteLine("Count is " +data.Count());
                break;
            }
            case 5:{
                TraineeData trainee = new TraineeData();
                List<TraineeDetails> traineeList = trainee.GetTraineeDetails();
                IEnumerable<string> data = from temp in traineeList where temp.YearPassedOut >= 2019 select temp.TraineeName;
                for(int iterator = 0;iterator < data.Count(); iterator++){
                    System.Console.WriteLine($"{data.ElementAt(iterator)}");
                }
                break;
            }
            case 6:{
                TraineeData trainee = new TraineeData();
                List<TraineeDetails> traineeList = trainee.GetTraineeDetails();
                IEnumerable<TraineeDetails> data = from temp in traineeList orderby temp.TraineeName ascending select temp;
                for(int iterator = 0;iterator < traineeList.Count; iterator++){
                    System.Console.WriteLine($"{data.ElementAt(iterator).TraineeId} - {data.ElementAt(iterator).TraineeName}");
                }
                break;
            }
            case 7:{
                TraineeData trainee = new TraineeData();
                List<TraineeDetails> traineeList = trainee.GetTraineeDetails();
                foreach(TraineeDetails trainee1 in traineeList){
                    foreach(TraineeScore score in trainee1.ScoreDetails){
                        if(score.Mark >= 4){
                            System.Console.WriteLine();
                            System.Console.WriteLine($"Trainee ID \t:{trainee1.TraineeId}");
                            System.Console.WriteLine($"Trainee Name\t:{trainee1.TraineeName}");
                            System.Console.WriteLine($"Topic Name\t:{score.TopicName}");
                            System.Console.WriteLine($"Exercise Name\t:{score.ExerciseName}");
                            System.Console.WriteLine($"Mark\t\t:{score.Mark}");
                            System.Console.WriteLine();
                        }
                    }
                }
                break;
            }
            case 8:{
                TraineeData trainee = new TraineeData();
                List<TraineeDetails> traineeList = trainee.GetTraineeDetails();
                IEnumerable<int> data = (from temp in traineeList select temp.YearPassedOut).Distinct(); 
                for(int iterator = 0;iterator < data.Count(); iterator++){
                    System.Console.WriteLine($"{data.ElementAt(iterator)}");
                }
                break;
            }
            case 9:{
                TraineeData obj = new TraineeData();
                    List<TraineeDetails> traineeDataList = obj.GetTraineeDetails();
                    int sum = 0;

                    System.Console.Write("Enter Trainee ID: ");
                    string traineeid = Console.ReadLine();

                    TraineeDetails tempTraineeDetails = null;
                    bool flag = false;
                    foreach(TraineeDetails data in traineeDataList)
                    {
                        if(data.TraineeId == traineeid)
                        {
                            tempTraineeDetails = data;
                            flag = true;
                            break;
                        }   
                    }

                    if(flag)
                    {
                        foreach(TraineeScore tempScore in tempTraineeDetails.ScoreDetails)
                        {
                            sum += tempScore.Mark;
                        }

                        System.Console.WriteLine();
                        System.Console.WriteLine($"Total Marks: {sum}");
                    }
                    else
                    {
                        System.Console.WriteLine("User Doesn't Exits");
                    }
                break;
            }
            case 10:{
                TraineeData trainee = new TraineeData();
                List<TraineeDetails> traineeList = trainee.GetTraineeDetails();
                IEnumerable<TraineeDetails> data = from temp in traineeList where temp == traineeList.First() select temp; 
                for(int iterator = 0;iterator < data.Count(); iterator++){
                    System.Console.WriteLine($"{data.ElementAt(iterator).TraineeId} - {data.ElementAt(iterator).TraineeName}");
                }
                break;
            }
            case 11:{
                TraineeData trainee = new TraineeData();
                List<TraineeDetails> traineeList = trainee.GetTraineeDetails();
                IEnumerable<TraineeDetails> data = from temp in traineeList where temp == traineeList.Last() select temp; 
                for(int iterator = 0;iterator < data.Count(); iterator++){
                    System.Console.WriteLine($"{data.ElementAt(iterator).TraineeId} - {data.ElementAt(iterator).TraineeName}");
                }
                break;
            }
            case 12:{
                    TraineeData obj = new TraineeData();
                    List<TraineeDetails> traineeDataList = obj.GetTraineeDetails();
                    int sum = 0;
                    foreach(TraineeDetails data in traineeDataList)
                    {
                        foreach(TraineeScore tempScore in data.ScoreDetails)
                        {
                            sum += tempScore.Mark;
                        }
                        System.Console.WriteLine($"Trainee Name: {data.TraineeName}");
                        System.Console.WriteLine($"Total Marks: {sum}");
                    }
                break;
            }
            case 13:{
                TraineeData obj = new TraineeData();
                List<TraineeDetails> traineeDataList = obj.GetTraineeDetails();
                int sum = 0;
                List<int> sumList = new List<int>();

                foreach(TraineeDetails data in traineeDataList)
                {
                    foreach(TraineeScore tempScore in data.ScoreDetails)
                    {
                        sum += tempScore.Mark;
                    }
                    sumList.Add(sum);
                }

                System.Console.WriteLine($"Maximum Score is {sumList.Max()}");
                break;
            }
            case 14:{
                TraineeData obj = new TraineeData();
                List<TraineeDetails> traineeDataList = obj.GetTraineeDetails();
                int sum = 0;
                List<int> sumList = new List<int>();

                foreach(TraineeDetails data in traineeDataList)
                {
                    foreach(TraineeScore tempScore in data.ScoreDetails)
                    {
                        sum += tempScore.Mark;
                    }
                    sumList.Add(sum);
                }

                System.Console.WriteLine($"Minimum Score is {sumList.Min()}");
                break;
            }
            case 15:{
                TraineeData obj = new TraineeData();
                List<TraineeDetails> traineeDataList = obj.GetTraineeDetails();
                int sum = 0;
                List<int> sumList = new List<int>();

                foreach(TraineeDetails data in traineeDataList)
                {
                    foreach(TraineeScore tempScore in data.ScoreDetails)
                    {
                        sum += tempScore.Mark;
                    }
                    sumList.Add(sum);
                }

                int totalScoreSum = 0;
                for(int i=0; i<sumList.Count; i++)
                {
                    totalScoreSum += sumList[i];
                }

                System.Console.WriteLine($"Average: {(double)totalScoreSum / sumList.Count()}");
                break;
            }
            case 16:{
                TraineeData obj = new TraineeData();
                List<TraineeDetails> traineeDataList = obj.GetTraineeDetails();
                int sum = 0;
                List<int> sumList = new List<int>();

                foreach(TraineeDetails data in traineeDataList)
                {
                    foreach(TraineeScore tempScore in data.ScoreDetails)
                    {
                        sum += tempScore.Mark;
                    }
                    sumList.Add(sum);
                }

                bool result = (from data in sumList where data > 40 select data).Any();
                System.Console.WriteLine($"If any one has more than 40 score: {result}");
                break;
            }
            case 17:{
                TraineeData obj = new TraineeData();
                List<TraineeDetails> traineeDataList = obj.GetTraineeDetails();
                int sum = 0;
                List<int> sumList = new List<int>();

                foreach(TraineeDetails data in traineeDataList)
                {
                    foreach(TraineeScore tempScore in data.ScoreDetails)
                    {
                        sum += tempScore.Mark;
                    }
                    sumList.Add(sum);
                }

                IEnumerable<int> QueryResult = sumList;
                bool result = QueryResult.All(data => data > 20);
                System.Console.WriteLine($"If any one has more than 20 score: {result}");
                break;
            }
            case 18:{
                TraineeData data = new TraineeData();
                TraineeDetails traineeData = new TraineeDetails();
                List<TraineeDetails> traineeDataList = data.GetTraineeDetails();
                List<TraineeScore> traineeScoreList = traineeData.ScoreDetails;

                IEnumerable<TraineeDetails> QueryResult = (from data1 in  traineeDataList orderby data1.TraineeName ascending select data1);

                for(int i=0; i<QueryResult.Count();i++)
                {
                    System.Console.WriteLine($"TraineeName: {QueryResult.ElementAt(i).TraineeName}");
                    System.Console.WriteLine($"TraineeID: {QueryResult.ElementAt(i).TraineeId}");
                    for(int j =0; j<QueryResult.ElementAt(i).ScoreDetails.Count(); i++)
                    {
                        System.Console.WriteLine($"Topic Name: {QueryResult.ElementAt(i).ScoreDetails[j].TopicName}");
                        System.Console.WriteLine($"Exercise Name: {QueryResult.ElementAt(i).ScoreDetails[j].ExerciseName}");
                        System.Console.WriteLine($"Mark: {QueryResult.ElementAt(i).ScoreDetails[j].Mark}");
                    }
                }
                break;
            }
            default:{
                System.Console.WriteLine("Invalid choice");
                break;
            }
        }
    }
}