using System.Linq;

namespace Assignment6
{
    public class Grade
    {
        private string[] PossibleGrades = {"A", "B", "C", "D"};
        private string _value;
        private const string DefaultGrade = "C";

        public Grade(string value)
        {
            _value = PossibleGrades.Contains(value) ? value : DefaultGrade;
        }
        

        public string Value
        {
            get { return _value; }
            set
            {
                if (PossibleGrades.Contains(value)) _value = value;
            }
        }
    }
}