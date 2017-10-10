namespace Assignment6.Properties
{
    public class CoreCourse:LectureCourse
    {
        public CoreCourse(string title, Year year, Instructor instructor, Assistant[] assistants) : base(title, year, instructor, assistants)
        {
        }
    }
}