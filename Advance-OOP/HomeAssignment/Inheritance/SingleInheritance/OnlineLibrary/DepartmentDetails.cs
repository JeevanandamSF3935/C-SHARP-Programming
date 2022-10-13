

namespace Exercise4
{
    public class DepartmentDetails
    {
        public string DeptName { get; set; }

        public string Degree { get; set; }

        public DepartmentDetails(string deptname, string degree)
        {
            DeptName = deptname;
            Degree = degree;
        }
    }
}