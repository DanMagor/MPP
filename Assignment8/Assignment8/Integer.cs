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
    }
}