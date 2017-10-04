namespace Assignment6
{
    public class Instructor
    {
        private Name _name;
        private LectureCourse[] _lectures;

        public Instructor(Name name, LectureCourse[] lectures)
        {
            _name = name;
            _lectures = lectures;
        }

        public Instructor(Name name)
        {
            Name = name;
        }

        public Name Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public LectureCourse[] Lectures
        {
            get { return _lectures; }
            set { _lectures = value; }
        }
    }
}