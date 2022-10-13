

namespace Execise3
{
    public class Attendance
    {
        public DateTime Date { get; set; }

        public int HoursWorked { get; set; }

        public Attendance()
        {

        }

        public Attendance(DateTime date, int worked)
        {
            Date = date;
            HoursWorked = worked;
        }
    }
}