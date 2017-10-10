namespace Assignment6
{
    public class TeachingSchedule
    {
        private TeachingWeek[] _weeks;

        public TeachingSchedule(TeachingWeek[] teachingWeek)
        {
            _weeks = teachingWeek;
        }


        public TeachingWeek[] Weeks
        {
            get { return _weeks; }
            set { _weeks = value; }
        }
    }
}