
namespace Exercise2
{
    public class DepartmentDetails
    {
        public string DepartmentName { get; set; } 

        public string Degree { get; set; }

        public DepartmentDetails()
        {

        }

        public DepartmentDetails(string deptName, string degree)
        {
            DepartmentName = deptName;
            Degree = degree;
        }
    }
}