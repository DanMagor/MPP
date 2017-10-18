using System;

namespace Assignment8
{
    public class Term : Expression
    {
        public enum Opcode
        {
            Plus,
            Minus,
            None
        }

        private Opcode _op;

        public Term(Opcode op, Expression left, Expression right)
        {
            _op = op;
            _left = left;
            _right = right;
        }

        public override long Calculate()
        {
            var left = Left.Calculate();
            var right = Right.Calculate();
            switch (_op)
            {
                case Opcode.Plus: return left + right;
                case Opcode.Minus: return left - right;

                default:
                    throw new ArgumentOutOfRangeException();
            }
            return 0;
        }
    }
}