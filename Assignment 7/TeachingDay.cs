namespace Assignment6
{
    public class TeachingDay
    {
        private Lecture[] _lectures;

        public TeachingDay(Lecture[] lectures)
        {
            _lectures = lectures;
        }

        public Lecture[] Lectures
        {
            get { return _lectures; }
            set { _lectures = value; }
        }
    }
}