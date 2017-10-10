namespace Assignment6
{
    public class LectureCourse
    {
        private string _title;
        private Year _year;
        private Instructor _instructor;
        private Assistant[] _assistants;
        

        public LectureCourse(string title, Year year, Instructor instructor, Assistant[] assistants)
        {
            _title = title;
            _year = year;
            _instructor = instructor;
            _assistants = assistants;
        }

        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }

        public Year Year
        {
            get { return _year; }
            set { _year = value; }
        }

        public Instructor Instructor
        {
            get { return _instructor; }
            set { _instructor = value; }
        }

        public Assistant[] Assistants
        {
            get { return _assistants; }
            set { _assistants = value; }
        }

           
    }
}