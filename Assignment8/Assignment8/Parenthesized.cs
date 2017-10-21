namespace Assignment8
{
    public class Parenthesized:Primary
    {
        private Expression _expression;
        public override long Calculate()
        {
            return _expression.Calculate();
        }

        public Parenthesized(Expression expression)
        {
            _expression = expression;
        }
        
        public override string ToJson()
        {
            var result = _expression.ToJson();
            return result;
        }
    }
}