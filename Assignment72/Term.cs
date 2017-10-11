namespace Assignment72
{
    public class Term:Expression
    {
        
        public enum Opcode { Plus, Minus, None }
        private Opcode _op;

        public Term(Opcode op, Expression left, Expression right)
        {
            _op = op;
            _left = left;
            _right = right;
        }
    }
}