using System.Data.Common;

namespace Assignment72
{
    public class Logical:Expression
    {
        
        public enum Opcode { And, Or, Xor, None }
        Opcode _op;
       

        public Logical(Logical.Opcode op, Expression left, Expression right)
        {
            _op = op;
            _left = left;
            _right = right;
        }

        
    }
}