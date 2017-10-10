namespace Assignment6
{
    public class Student : Person
    {
        private Year _year;
        private LectureCourse[] _lectures;

        public Student(Name name, Year year, LectureCourse[] lectures) : base(name)
        {
            _year = year;
            _lectures = lectures;
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