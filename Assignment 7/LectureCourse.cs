namespace Assignment6
{
    public class LectureCourse
    {
        private string _title;
        private Year _year;
        private Instructor _instructor;
        private Assistant[] _assistants;
        private bool _isCore;


        public LectureCourse(string title, Year year, Instructor instructor, Assistant[] assistants, bool isCore)
        {
            _title = title;
            _year = year;
            _instructor = instructor;
            _assistants = assistants;
            _isCore = isCore;
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

        public bool IsCore
        {
            get { return _isCore; }
            set { _isCore = value; }
        }
    }
}