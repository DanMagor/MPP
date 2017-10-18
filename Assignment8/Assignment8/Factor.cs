using System;

namespace Assignment8
{
    public class Factor : Expression
    {
        public enum Opcode
        {
            Multiply,
            Division,
            None
        }

        Opcode _op;


        public Factor(Opcode op, Expression left, Expression right)
        {
            _left = left;
            _right = right;
            _op = op;
        }

        public override long Calculate()
        {
            var left = Left.Calculate();
            var right = Right.Calculate();
            switch (_op)
            {
                case Opcode.Multiply: return left * right;
                case Opcode.Division: return left / right;
               
                default:
                    throw new ArgumentOutOfRangeException();
            }
            return 0;
        }
    }
}