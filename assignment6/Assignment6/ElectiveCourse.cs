namespace Assignment6
{
    public class ElectiveCourse:LectureCourse
    {
        public ElectiveCourse(string title, Year year, Instructor instructor, Assistant[] assistants) : base(title, year, instructor, assistants)
        {
        }
    }
}