namespace Assignment72
{
    public class Factor:Expression
    {
        public enum Opcode { Multiply, Division, None }
        Opcode _op;
        

        public Factor(Opcode op, Expression left, Expression right)
        {
            _left = left;
            _right = right;
            _op = op;
        }

    }
}