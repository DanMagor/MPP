namespace Assignment6
{
    public class Lecture
    {
        private Auditorium _room;
        private LectureCourse _course;

        public Lecture(LectureCourse lecture, Auditorium room)
        {
            _course = lecture;
            _room = room;
        }


        public LectureCourse Course
        {
            get { return _course; }
            set { _course = value; }
        }

        public Auditorium Room
        {
            get { return _room; }
            set { _room = value; }
        }
    }
}