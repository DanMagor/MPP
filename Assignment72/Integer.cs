namespace Assignment72
{
    public class Integer:Primary
    {
        private long _value;

        public Integer(long value)
        {
            _value = value;
        }

        public long Value => _value;
    }
}