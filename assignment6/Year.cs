using System.Linq;

namespace Assignment6
{
    public class Year
    {
        private readonly string[] PossibleYears = {"BS1","BS2","BS3","BS4","MS1","MS2"};
        private string _value;
        private const string DefaultYear = "BS1";
        
        public Year(string value)
        {
            _value = PossibleYears.Contains(value) ? value : DefaultYear;
        }

        public string Value
        {
            get { return _value; }
            set
            {
                if (PossibleYears.Contains(value)) _value = value;
            }
        }
    }
}