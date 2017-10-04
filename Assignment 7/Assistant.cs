namespace Assignment6
{
    public class Assistant
    {
        private Name _name;
        private LectureCourse[] _lectures;

        public Assistant(Name name, LectureCourse[] lectures)
        {
            _name = name;
            _lectures = lectures;
        }

        public Assistant(Name name)
        {
            _name = name;
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