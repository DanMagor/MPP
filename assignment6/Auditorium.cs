using System.Linq;

namespace Assignment6
{
    public class Auditorium
    {

        private string DefaultDay = "Mon";
        private string DefaultTime = "09:00";
        private readonly string[] PossibleDays = {"Mon", "Tue", "Wed", "Thu", "Fri", "Sat", "Sun"};
        private readonly string[] PossibleTime = {"09:00", "10:40", "12:20", "14:00", "15:40", "17:20", "19:00"};
        private string _dayTime; // format "ddd/hh:mm"
        private uint _roomNo;


        public Auditorium(string day, string time, uint roomNo)
        {
            var tempDay = PossibleDays.Contains(day) ? day : DefaultDay;
            var tempTime = PossibleTime.Contains(time) ? time : DefaultTime;
            _dayTime = tempDay + "/" + tempTime;
            RoomNo = roomNo;
        }

        public string DayTime
        {
            get {  return _dayTime; }
            set
            {
                var day = value.Substring(0, 3);
                var time = value.Substring(4);
                if (PossibleDays.Contains(day) && PossibleTime.Contains(time)) _dayTime = value;
            }
        }

        public uint RoomNo
        {
            get { return _roomNo; }
            set { _roomNo = value; }
        }
    }
    
}