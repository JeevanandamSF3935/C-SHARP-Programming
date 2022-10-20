using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment3
{
    public class Departments
    {
        public int ID { get; set; }
        public string DeptName { get; set; }

        public List<Departments> GetDepartments(){
            List<Departments> departmentsList = new List<Departments>{
                new Departments{ID = 1,DeptName = "IT"},
                new Departments{ID = 2,DeptName = "CSE"},
                new Departments{ID = 3,DeptName = "CIVIL"},
                new Departments{ID = 4,DeptName = "EEE"},
            };

            return departmentsList;
        }
    }
}