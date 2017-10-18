namespace Assignment8
{
    public class Parenthesized:Primary
    {
        private Expression _expression;
        public override long Calculate()
        {
            return _expression.Calculate();
        }
    }
}