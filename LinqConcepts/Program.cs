using System;
using System.Collections.Generic;
using System.Linq;
namespace Assignment3;
class Program
{
    public static void Main(string[] args)
    {
        int choice = 0;
        TraineeData obj = new TraineeData();
        Departments obj1 = new Departments();
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
        System.Console.WriteLine("Enter the choice : ");
        choice = int.Parse(Console.ReadLine());
        
        switch(choice){
            case 1:{
                IEnumerable<string> datas = from temp in obj.GetTraineeDetails() select temp.TraineeId.ToString();
                foreach(string data in datas){
                    System.Console.WriteLine($"{data}");
                }
                break;
            }
            case 2:{
                IEnumerable<TraineeDetails> datas = obj.GetTraineeDetails().Take(3) ;
                foreach(TraineeDetails data in datas){
                    System.Console.WriteLine($"{data.TraineeId}");
                }
                break;
            }
            case 3:{
                IEnumerable<TraineeDetails> datas = obj.GetTraineeDetails().Skip(obj.GetTraineeDetails().Count-2) ;
                foreach(TraineeDetails data in datas){
                    System.Console.WriteLine($"{data.TraineeId}");
                }
                break;
            }
            case 4:{
                IEnumerable<string> data = from temp in obj.GetTraineeDetails() select temp.TraineeId.ToString();
                System.Console.WriteLine("Count is " +data.Count());
                break;
            }
            case 5:{
                IEnumerable<string> datas = from temp in obj.GetTraineeDetails() where temp.YearPassedOut >= 2019 select temp.TraineeName;
                foreach(string data in datas){
                    System.Console.WriteLine($"{data}");
                }
                break;
            }
            case 6:{
                IEnumerable<TraineeDetails> datas = from temp in obj.GetTraineeDetails() orderby temp.TraineeName ascending select temp;
                foreach(TraineeDetails data in datas){
                    System.Console.WriteLine($"{data.TraineeId} - {data.TraineeName}");
                }
                break;
            }
            case 7:{
                IEnumerable<TraineeDetails> datas = from data in obj.GetTraineeDetails() select data;
                foreach(TraineeDetails trainee1 in datas){
                    IEnumerable<TraineeScore> traineesScore = from data in trainee1.ScoreDetails where data.Mark >= 4 select data;
                    foreach(TraineeScore traineeScore in traineesScore){
                        System.Console.WriteLine();
                        System.Console.WriteLine();
                        System.Console.WriteLine($"Trainee ID \t:{trainee1.TraineeId}");
                        System.Console.WriteLine($"Trainee Name\t:{trainee1.TraineeName}");
                        System.Console.WriteLine($"Topic Name\t:{traineeScore.TopicName}");
                        System.Console.WriteLine($"Exercise Name\t:{traineeScore.ExerciseName}");
                        System.Console.WriteLine($"Mark\t\t:{traineeScore.Mark}");
                        System.Console.WriteLine();
                    }
                }
                break;
            }
            case 8:{
                IEnumerable<int> datas = (from temp in obj.GetTraineeDetails() select temp.YearPassedOut).Distinct(); 
                foreach(int data in datas){
                    System.Console.WriteLine($"{data}");
                }
                break;
            }
            case 9:{
                System.Console.Write("Enter Trainee ID: ");
                string traineeid = Console.ReadLine().ToUpper();

                IEnumerable<TraineeDetails> datas = from data in obj.GetTraineeDetails() where data.TraineeId == traineeid select data;
                foreach(TraineeDetails trainee in datas){
                    IEnumerable<int> marks = from mark in trainee.ScoreDetails select mark.Mark;
                    int sum = marks.Aggregate((a,b)=>a+b);
                    System.Console.WriteLine("Sum : "+ sum);
                }
                break;
            }
            case 10:{
                TraineeDetails trainee = obj.GetTraineeDetails().First();
                System.Console.WriteLine($"{trainee.TraineeId}-----{trainee.TraineeName}");
                break;
            }
            case 11:{
                TraineeDetails trainee = obj.GetTraineeDetails().Last();
                System.Console.WriteLine($"{trainee.TraineeId}-----{trainee.TraineeName}");
                break;
            }
            case 12:{
                IEnumerable<TraineeDetails> datas = obj.GetTraineeDetails().Where(s=>true);
                foreach(TraineeDetails trainee in datas){
                    IEnumerable<int> traineeScores = from data in trainee.ScoreDetails select data.Mark; 
                    int sum = traineeScores.Aggregate((a,b) => a+b);
                    System.Console.WriteLine("Name : "+trainee.TraineeName+"\nSum : " +sum);
                }
                break;
            }
            case 13:{
                int sum = 0;
                List<int> sumList = new List<int>();

                foreach(TraineeDetails data in obj.GetTraineeDetails())
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
                int sum = 0;
                List<int> sumList = new List<int>();

                foreach(TraineeDetails data in obj.GetTraineeDetails())
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
                int sum = 0;
                List<int> sumList = new List<int>();

                foreach(TraineeDetails data in obj.GetTraineeDetails())
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
                List<int> sumList = new List<int>();
                IEnumerable<TraineeDetails> datas = obj.GetTraineeDetails().Select(s=>s);
                foreach(TraineeDetails trainee in datas){
                    IEnumerable<int> traineeScores = trainee.ScoreDetails.Select(s=>s.Mark);
                    int sum = traineeScores.Aggregate((a,b)=>a+b);
                    sumList.Add(sum);
                }
                bool result = sumList.Any(s=>s > 40);
                System.Console.WriteLine(result);
                break;
            }
            case 17:{
                List<int> sumList = new List<int>();
                IEnumerable<TraineeDetails> datas = obj.GetTraineeDetails().Select(s=>s);
                foreach(TraineeDetails trainee in datas){
                    IEnumerable<int> traineeScores = trainee.ScoreDetails.Select(s=>s.Mark);
                    int sum = traineeScores.Aggregate((a,b)=>a+b);
                    sumList.Add(sum);
                }
                bool result = sumList.All(s=>s>20);
                System.Console.WriteLine(result);
                break;
            }
            case 18:{
                IEnumerable<TraineeDetails> datas = obj.GetTraineeDetails().OrderByDescending(s=>s.TraineeName).Select(s=>s);
                foreach(var trainee in datas){
                    System.Console.WriteLine($"TraineID : {trainee.TraineeId}\nTrainee Name : {trainee.TraineeName}");
                    var traineeScores = trainee.ScoreDetails.Select(s=> new {Exercise = s.ExerciseName, Mark = s.Mark }).OrderByDescending(s=>s.Mark);
                    foreach(var score in traineeScores){
                        System.Console.WriteLine($"Exercise Name : {score.Exercise}\nMark : {score.Mark}");
                    }
                    System.Console.WriteLine();
                    System.Console.WriteLine();
                }
                break;
            }
            default:{
                System.Console.WriteLine("Invalid choice");
                break;
            }
        }
        Practices();
    }

    public static void Practices(){
        TraineeData obj = new TraineeData();
        Departments obj1 = new Departments();
        
        //ToDictonary
        System.Console.WriteLine();
        Dictionary<string,TraineeDetails> trainees1 = obj.GetTraineeDetails().OrderBy(s=>s.DOJ).ThenByDescending(s=>s.TraineeId).ToDictionary(s=>s.TraineeId,s=>s);
        foreach(KeyValuePair<string,TraineeDetails> trainee in trainees1){
            System.Console.WriteLine(trainee.Key+ "----"+trainee.Value.TraineeName+ "----" +trainee.Value.DOJ);
        }


        //ToLookUp
        var studentByPassedOut = obj.GetTraineeDetails().ToLookup(s=>s.YearPassedOut,s=>s);
        System.Console.WriteLine("Trainee ordered by passed out year");
        foreach(var v in studentByPassedOut){
            System.Console.WriteLine(v.Key);
            foreach(var v1 in studentByPassedOut[v.Key]){
                System.Console.WriteLine(v1.TraineeId+"---"+v1.TraineeName);
            }
            System.Console.WriteLine();
        }
        System.Console.WriteLine();
        
        
        //Aggregate function
        System.Console.WriteLine();
        string[] str = {"India","America","Africa","Afganistan"};
        string str1 = "";
        str1 = str.Aggregate((a,b)=>a+","+b);
        foreach(string str2 in str){
            str1 += str2 + ",";
        }
        str1 = str1.Remove((str1.Length)-1);
        System.Console.WriteLine(str1);


        var traineesValue = obj.GetTraineeDetails().AsQueryable().Where(s=>s.YearPassedOut==2018).Select(s=>s);
        foreach(var v in traineesValue){
            System.Console.WriteLine(v.TraineeId+"-----"+v.TraineeName);
        }

        
        //GroupBy
        //var trainees = obj.GetTraineeDetails().GroupBy(s=>s.YearPassedOut).Select(s=>new{Key = s.Key, Trainee = s.OrderBy(s=>s.TraineeName)});
        var trainees = from data in obj.GetTraineeDetails() group data by data.YearPassedOut into groupTrainee
                        orderby groupTrainee.Key select new{ Key = groupTrainee.Key, Trainee = groupTrainee.OrderBy(s=>s.TraineeName)};
        foreach(var trainee in trainees){
            System.Console.WriteLine($"{trainee.Key}----{trainee.Trainee.Count()}");
            foreach(var trainee1 in trainee.Trainee){
                System.Console.WriteLine($"{trainee1.TraineeName}");
            }
        }


        //GroupBy for multiple key
        var trainees2 = obj.GetTraineeDetails().GroupBy(g => new {g.DOJ,g.YearPassedOut}).Select(s=>new{Key = s.Key,Trainee = s.OrderBy(s=>s.TraineeId)});
        foreach(var trainee in trainees2){
            System.Console.WriteLine($"{trainee.Key.DOJ}***{trainee.Key.YearPassedOut}***{trainee.Trainee.Count()}");
            System.Console.WriteLine("---------------------------------------");
            foreach(var trainee1 in trainee.Trainee){
                System.Console.WriteLine($"{trainee1.TraineeId}---{trainee1.TraineeName}---{trainee1.YearPassedOut}");
            }
            System.Console.WriteLine();
            System.Console.WriteLine();
        }

        //Group Join
        var trainees3 = obj1.GetDepartments().GroupJoin(obj.GetTraineeDetails(),d=>d.ID,t=>t.DeptID,
                                            (department,trainee)=>new{Department = department.DeptName,Trainee = trainee.OrderBy(t=>t.TraineeName)});
        foreach(var trainee in trainees3){
            System.Console.WriteLine($"{trainee.Department}");
            foreach(var trainee1 in trainee.Trainee){
                System.Console.WriteLine($"{trainee1.TraineeName}");
            }
            System.Console.WriteLine();
        }

        //Join
        var trainees4 = obj.GetTraineeDetails().Join(obj1.GetDepartments(),t=>t.DeptID,d=>d.ID,
                                    (trainee,department) => new{Trainee = trainee.TraineeName,Department = department.DeptName});
        foreach(var trainee in trainees4){
            System.Console.WriteLine($"{trainee.Trainee}---{trainee.Department}");
        }

        //LeftOuterJoin
        System.Console.WriteLine("LeftOuterJoin");
        var trainees5 = from data in obj1.GetDepartments() join data1 in obj.GetTraineeDetails() 
                        on data.ID equals data1.DeptID into groupedTrainee
                        from d in groupedTrainee.DefaultIfEmpty()
                        select new{
                            Trainee = data.DeptName,
                            Department = d == null ? "No Trainee" : d.TraineeName
                        };

        var trainees6 = obj.GetTraineeDetails().GroupJoin(obj1.GetDepartments(),t=>t.DeptID,d=>d.ID,
                        (trainee,department)=>new{trainee,department}
                        ).SelectMany(s=>s.department.DefaultIfEmpty(),(a,b)=>new {Trainee = a.trainee.TraineeName,Department = b==null?"No department":b.DeptName});
        foreach(var trainee in trainees5){
            System.Console.WriteLine($"{trainee.Trainee}----{trainee.Department}");
        }
        System.Console.WriteLine();
        System.Console.WriteLine();
        foreach(var trainee in trainees6){
            System.Console.WriteLine($"{trainee.Trainee}----{trainee.Department}");
        }
        

        //CrossJoin
        var trainees7 = from t in obj.GetTraineeDetails()
                        from d in obj1.GetDepartments()
                        select new{t,d};
        

        var trainees8 = obj1.GetDepartments().Join(obj.GetTraineeDetails(),d=>true,t=>true,
                        (d,t)=>new{d,t});
        foreach(var trainee in trainees7){
            System.Console.WriteLine($"{trainee.t.TraineeName}\t{trainee.d.DeptName}");
        }
        System.Console.WriteLine();
        System.Console.WriteLine();
        foreach(var trainee in trainees8){
            System.Console.WriteLine($"{trainee.t.TraineeName}\t{trainee.d.DeptName}");
        }

        //Union
        List<TraineeDetails> list = obj.GetTraineeDetails();
        List<TraineeDetails> list1 = obj.GetTraineeDetails();
        list1.Add(new TraineeDetails{TraineeId ="SF2006" , TraineeName = "Guru" , DOJ ="17/09/2019" , YearPassedOut = 2020,
                                    ScoreDetails = new List<TraineeScore>
                                    {
                                        new TraineeScore {TopicName="HTML",ExerciseName="HTML Elements", Mark=5 },
                                        new TraineeScore {TopicName="HTML",ExerciseName="HTML Table Format", Mark=5 },
                                        new TraineeScore {TopicName="CSS",ExerciseName="Colors and Styles", Mark=4 },
                                        new TraineeScore {TopicName="JavaScript",ExerciseName="Cookies", Mark=5 },
                                        new TraineeScore {TopicName="C#",ExerciseName="String Operations", Mark=4 },
                                        new TraineeScore {TopicName="C#",ExerciseName="List and Properties", Mark=5 },
                                        new TraineeScore {TopicName="MVC",ExerciseName="Controllers", Mark=4 }
                                    }});
        var trainees9 = list.Select(x=>x).UnionBy(list1.Select(x=>x),s=>s.TraineeId);
        foreach(var trainee in trainees9){
            System.Console.WriteLine(trainee.TraineeId+"\t"+trainee.TraineeName);
        }

        //Intersect
        List<TraineeDetails> list2 = obj.GetTraineeDetails();
        List<TraineeDetails> list3 = obj.GetTraineeDetails();
        list3.Add(new TraineeDetails{TraineeId ="SF2006" , TraineeName = "Guru" , DOJ ="17/09/2019" , YearPassedOut = 2020,
                                    ScoreDetails = new List<TraineeScore>
                                    {
                                        new TraineeScore {TopicName="HTML",ExerciseName="HTML Elements", Mark=5 },
                                        new TraineeScore {TopicName="HTML",ExerciseName="HTML Table Format", Mark=5 },
                                        new TraineeScore {TopicName="CSS",ExerciseName="Colors and Styles", Mark=4 },
                                        new TraineeScore {TopicName="JavaScript",ExerciseName="Cookies", Mark=5 },
                                        new TraineeScore {TopicName="C#",ExerciseName="String Operations", Mark=4 },
                                        new TraineeScore {TopicName="C#",ExerciseName="List and Properties", Mark=5 },
                                        new TraineeScore {TopicName="MVC",ExerciseName="Controllers", Mark=4 }
                                    }});
        var trainees10 = list2.IntersectBy(list3.Select(s=>s.TraineeId),s=>s.TraineeId);
        foreach(var trainee in trainees10){
            System.Console.WriteLine(trainee.TraineeId+"\t"+trainee.TraineeName);
        }

        //distinct 
        List<TraineeDetails> list4 = obj.GetTraineeDetails();
        list4.Add(new TraineeDetails{TraineeId ="SF2001" , TraineeName = "Rekha" , DOJ ="17/08/2019" , YearPassedOut = 2020,
                                    ScoreDetails = new List<TraineeScore>
                                    {
                                        new TraineeScore {TopicName="HTML",ExerciseName="HTML Elements", Mark=5 },
                                        new TraineeScore {TopicName="HTML",ExerciseName="HTML Table Format", Mark=5 },
                                        new TraineeScore {TopicName="CSS",ExerciseName="Colors and Styles", Mark=4 },
                                        new TraineeScore {TopicName="JavaScript",ExerciseName="Cookies", Mark=5 },
                                        new TraineeScore {TopicName="C#",ExerciseName="String Operations", Mark=4 },
                                        new TraineeScore {TopicName="C#",ExerciseName="List and Properties", Mark=5 },
                                        new TraineeScore {TopicName="MVC",ExerciseName="Controllers", Mark=4 }
                                    }});
        var trainees11 = list4.DistinctBy(s=>s.DOJ);
        foreach(var trainee in trainees11){
            System.Console.WriteLine(trainee.TraineeId+"\t"+trainee.TraineeName);
        }

        //Except
        List<TraineeDetails> list5 = obj.GetTraineeDetails();
        List<TraineeDetails> list6 = obj.GetTraineeDetails();
        list6.Add(new TraineeDetails{TraineeId ="SF2006" , TraineeName = "Guru" , DOJ ="17/09/2019" , YearPassedOut = 2020,
                                    ScoreDetails = new List<TraineeScore>
                                    {
                                        new TraineeScore {TopicName="HTML",ExerciseName="HTML Elements", Mark=5 },
                                        new TraineeScore {TopicName="HTML",ExerciseName="HTML Table Format", Mark=5 },
                                        new TraineeScore {TopicName="CSS",ExerciseName="Colors and Styles", Mark=4 },
                                        new TraineeScore {TopicName="JavaScript",ExerciseName="Cookies", Mark=5 },
                                        new TraineeScore {TopicName="C#",ExerciseName="String Operations", Mark=4 },
                                        new TraineeScore {TopicName="C#",ExerciseName="List and Properties", Mark=5 },
                                        new TraineeScore {TopicName="MVC",ExerciseName="Controllers", Mark=4 }
                                    }});
        var trainees12 = list6.ExceptBy(list5.Select(s=>s.TraineeId),s=>s.TraineeId);
        foreach(var trainee in trainees12){
            System.Console.WriteLine(trainee.TraineeId+"\t"+trainee.TraineeName);
        }


        //SequenceEqual
        List<TraineeDetails> list7 = obj.GetTraineeDetails();
        List<TraineeDetails> list8 = obj.GetTraineeDetails();
        var check = list7.Select(s=>s.TraineeId).SequenceEqual(list8.Select(s=>s.TraineeId));
        System.Console.WriteLine(check);
        


        //Contains
        var result = (obj.GetTraineeDetails().Select(s=>s.TraineeName)).Contains("jeeva",StringComparer.OrdinalIgnoreCase);
        System.Console.WriteLine(result);
        
    }

}