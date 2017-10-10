namespace Assignment6.Properties
{
    public class Teacher:Person
    {
        
        protected LectureCourse[] _lectures;

        public Teacher(Name name) : base(name)
        {
        
        }

        public Teacher(Name name, LectureCourse[] lectures) : base(name)
        {
            _lectures = lectures;
        }
        
        
        public LectureCourse[] Lectures
        {
            get { return _lectures; }
            set { _lectures = value; }
        }
    }
}