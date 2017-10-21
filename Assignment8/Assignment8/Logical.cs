using System;

namespace Assignment8
{
    public class Logical : Expression
    {
        public enum Opcode
        {
            And,
            Or,
            Xor,
            None
        }

        Opcode _op;


        public Logical(Logical.Opcode op, Expression left, Expression right)
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
                case Opcode.And: return left != 0 && right != 0 ? 1 : 0;
                case Opcode.Or: return left != 0 || right != 0 ? 1 : 0;
                case Opcode.Xor: return left != right ? 1 : 0;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        public override string ToJson()
        {
            var result = "";
            result += "\t\n{\n\t\"Type\" : Logical,\n";
            result += "\t\"Operator\" : " + _op.ToString() + ",\n";
            result += "\t\"Left\" : " + _left.ToJson() + ",\n";
            result += "\t\"Right\" : " + _right.ToJson() + ",\n}";
            
            return result;
        }
    }
}