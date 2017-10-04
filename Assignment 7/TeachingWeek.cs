namespace Assignment6
{
    public class TeachingWeek
    {
        private TeachingDay _monday;
        private TeachingDay _tuesday;
        private TeachingDay _wednesday;
        private TeachingDay _thursday;
        private TeachingDay _friday;
        private TeachingDay _saturday;
        private TeachingDay _sunday;

        public TeachingWeek(TeachingDay monday, TeachingDay tuesday, TeachingDay wednesday, TeachingDay thurshay,
            TeachingDay friday, TeachingDay saturday, TeachingDay sunday)
        {
            _monday = monday;
            _tuesday = tuesday;
            _wednesday = wednesday;
            _thursday = thurshay;
            _friday = friday;
            _saturday = saturday;
            _sunday = sunday;
        }

        public TeachingDay Monday
        {
            get { return _monday; }
            set { _monday = value; }
        }

        public TeachingDay Tuesday
        {
            get { return _tuesday; }
            set { _tuesday = value; }
        }

        public TeachingDay Wednesday
        {
            get { return _wednesday; }
            set { _wednesday = value; }
        }

        public TeachingDay Thursday
        {
            get { return _thursday; }
            set { _thursday = value; }
        }

        public TeachingDay Friday
        {
            get { return _friday; }
            set { _friday = value; }
        }

        public TeachingDay Saturday
        {
            get { return _saturday; }
            set { _saturday = value; }
        }

        public TeachingDay Sunday
        {
            get { return _sunday; }
            set { _sunday = value; }
        }
    }
}