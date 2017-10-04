namespace Assignment6
{
    public class Student
    {
        private Name _name;
        private Year _year;
        private LectureCourse[] _lectures;

        public Student(Name name, Year year, LectureCourse[] lectures)
        {
            _name = name;
            _year = year;
            _lectures = lectures;
        }

        public Name Name
        {
            get { return _name; }
            set { _name = value; }
        }


        public Year Year
        {
            get { return _year; }
            set { _year = value; }
        }

        public LectureCourse[] Lectures
        {
            get { return _lectures; }
            set { _lectures = value; }
        }
    }
}