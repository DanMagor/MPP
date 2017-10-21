namespace Assignment8
{
    public class Integer:Primary
    {
        private long _value;

        public Integer(long value)
        {
            _value = value;
        }

        public long Value => _value;
        public override long Calculate()
        {
            return _value;
        }
        
        public override string ToJson()
        {
            var result = "";
            result += "\t\n{\n\t\"Type\" : Integer,\n";
            result += "\t\"Value\" : " + _value + ",\n}";
            return result;
        }
    }
}