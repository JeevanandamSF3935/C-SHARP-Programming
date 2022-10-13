

namespace Exercise2
{
    public class RackInfo : DepartmentDetails
    {
        public int RackNumber { get; set; }

        public int ColumnNumber { get; set; }

        public RackInfo()
        {

        }

        public RackInfo(int rackno, int colmnno, string deptName, string degree):base(deptName, degree)
        {
            RackNumber = rackno;
            ColumnNumber = colmnno;
        }
    }
}