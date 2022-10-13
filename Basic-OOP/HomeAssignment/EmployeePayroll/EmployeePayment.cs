using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeePayroll{
    public class EmployeePayment
    {
        private static int s_employeeId = 1000;
        public string EmployeeID { get; }
        public string EmployeeName { get; set; }
        public string Role { get; set; }
        public WorkLocation EmployeeWorkLocation { get; set; }
        public string TeamName { get; set; }
        public DateTime DateOfJoining { get; set; }
        public int WorkingDays { get; set; }
        public double LeaveTaken { get; set; }
        public Gender EmployeeGender { get; set; }
    
        public EmployeePayment(string employeeName, string role,WorkLocation employeeWorkLocation, string teamName, DateTime dateOfJoining, int workingDays, double leaveTaken, Gender employeeGender){
            s_employeeId++;
            EmployeeID = "SF"+s_employeeId;
            EmployeeName = employeeName;
            Role = role;
            EmployeeWorkLocation = employeeWorkLocation;
            TeamName = teamName;
            DateOfJoining = dateOfJoining;
            WorkingDays = workingDays;
            LeaveTaken = leaveTaken;
            EmployeeGender = employeeGender;

        }
        public void CalculateSalary(){
            double salary = (WorkingDays - LeaveTaken) * 500;
            System.Console.WriteLine($"The salary of {WorkingDays-LeaveTaken} is {salary}");
        }
    }

}