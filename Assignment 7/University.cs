namespace Assignment6
{
    public class University
    {
        private Student[] _students;
        private Assistant[] _assistants;
        private Instructor[] _instructors;
        private LectureCourse[] _courses;
        private TeachingSchedule _schedule;

        public University(Student[] students, Assistant[] assistants, Instructor[] instructors, LectureCourse[] courses,
            TeachingSchedule schedule)
        {
            _students = students;
            _assistants = assistants;
            _instructors = instructors;
            _courses = courses;
            _schedule = schedule;
        }

        public Student[] Students
        {
            get { return _students; }
            set { _students = value; }
        }

        public Assistant[] Assistants
        {
            get { return _assistants; }
            set { _assistants = value; }
        }

        public Instructor[] Instructors
        {
            get { return _instructors; }
            set { _instructors = value; }
        }

        public LectureCourse[] Courses
        {
            get { return _courses; }
            set { _courses = value; }
        }

        public TeachingSchedule Schedule
        {
            get { return _schedule; }
            set { _schedule = value; }
        }
    }
}