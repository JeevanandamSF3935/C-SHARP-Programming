
namespace Exercise3
{
    public class Attendance
    {
        public DateTime Date { get; set; }

        public int WorkedHours { get; set; }

        public Attendance()
        {

        }

        public Attendance(DateTime date, int worked)
        {
            Date = date;
            WorkedHours = worked;
        }
    }
}